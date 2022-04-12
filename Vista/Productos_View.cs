using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseSystemFood.Controlador;

namespace HouseSystemFood.Vista
{
    public partial class Productos_View : Form
    {

        private DataTable datos;
        private Productos productos;
        private ProductosHelper productosH;
        private Categorias categorias;
        private CategoriasHelper categoriasH;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;

        public int UserId;

        public Productos_View()
        {
            InitializeComponent();
        }
        public Productos_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        private void Productos_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
            cargarCmbCategorias();
        }
        public void cargarDatosDtg()
        {
            try
            {
                productos = new Productos();
                productos.Opc = 2;
                productosH = new ProductosHelper(productos);
                datos = productosH.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgProductos.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos().Equals(1))        //si la bandera es 1 hay campos vacios y no hago el insert
            {
                MessageBox.Show("Debe completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Guardar();
            }
           
        }

        public void Guardar()
        {
            //guarda nueva producto
            try
            {
                //obtengo categoriaId
                datos = categoriasH.GetIdCat(this.cmbCategorias.Text);
                string[] dt = new string[datos.Rows.Count];
                dt[0] = datos.Rows[0]["IdCategoria"].ToString();

                productos = new Productos();
                    productos.Nombre = this.txtNombre.Text;
                    productos.Descripcion = this.txtDescripcion.Text;
                    productos.Precio = int.Parse(this.mskPrecio.Text);
                    productos.Stock = int.Parse(this.mskStock.Text);
                    productos.IdCat = int.Parse(dt[0]);
                    productos.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());

                    if (this.btnAceptar.Text.Equals("Aceptar"))
                    {
                        productos.Opc = 1;
                        productosH = new ProductosHelper(productos);
                        productosH.Guardar();
                         RegistarEnBitacora("INSERT");

                    cargarDatosDtg();
                    MessageBox.Show("Se ha almacenado un nuevo Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        datos = (DataTable)dtgProductos.DataSource;
                        int indice = dtgProductos.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        productos.Opc = 4;                      
                        productos.Id = int.Parse(fila["IdProducto"].ToString());
                        productosH = new ProductosHelper(productos);
                        productosH.Actualizar();
                        RegistarEnBitacora("UPDATE");

                    cargarDatosDtg();
                    MessageBox.Show("Se actualizó el Producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.btnAceptar.Text = "Aceptar";
                    }

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                productos = new Productos();
                productos.Opc = 3;
                productos.Nombre = this.txtBuscar.Text;
                productosH = new ProductosHelper(productos);
                datos = productosH.Buscar();

                if (datos.Rows.Count > 0)
                {
                    dtgProductos.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnAceptar.Text = "Actualizar";
                datos = (DataTable)dtgProductos.DataSource;

                int indice = dtgProductos.CurrentRow.Index;
                DataRow fila = datos.Rows[indice];
               
                this.txtNombre.Text = fila["NombreProducto"].ToString();
                this.txtDescripcion.Text = fila["DescProducto"].ToString();
                this.mskPrecio.Text = fila["Precio"].ToString();
                this.mskStock.Text = fila["EnStockDisponibles"].ToString();
                this.cmbCategorias.Text = fila["NombreCategoria"].ToString();
               

                if (fila["Estado"].Equals(true))
                {
                    this.cmbEstado.SelectedItem = "Activo";
                }
                else
                {
                    this.cmbEstado.SelectedItem = "Inactivo";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                datos = (DataTable)dtgProductos.DataSource;
                if (datos == null)
                {
                    MessageBox.Show("No hay registros por Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo);
                    if (result.Equals(DialogResult.Yes))
                    {
                        int indice = dtgProductos.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        productos = new Productos();
                        productos.Opc = 5;
                        productos.Id = int.Parse(fila["IdProducto"].ToString());
                        productosH = new ProductosHelper(productos);
                        productosH.Eliminar();
                        RegistarEnBitacora("DELETE");
                        cargarDatosDtg();
                        MessageBox.Show("Se ha eliminado el registro","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void cargarCmbCategorias()
        {
            try
            {
                categorias = new Categorias();
                categorias.Opc = 2;
                categoriasH = new CategoriasHelper(categorias);
                datos = categoriasH.Listar();

                string[] dt = new string[datos.Rows.Count];
               
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    dt[i] = datos.Rows[i]["NombreCategoria"].ToString();
                   
                }
                this.cmbCategorias.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //registro el evento
        public void RegistarEnBitacora(string accion)
        {
            try
            {
                bitacoras = new Bitacoras();
                //registro el evento
                bitacoras.Opc = 1;
                bitacoras.IdUser = UserId;
                bitacoras.Accion = accion;
                bitacoras.Tabla = "PRODUCTOS";
                bitacoras.Fecha = DateTime.Today;
                bitacorasH = new BitacorasHelper(bitacoras);
                bitacorasH.InsertarEnBitacora();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //valida los campos vacios y no permite una ejecucion
        public int validarCampos()
        {
            int bandera = 0;
            string[] dato = new string[6];

            dato[0] = this.txtNombre.Text;
            dato[1] = this.txtDescripcion.Text;
            dato[2] = this.mskPrecio.Text;
            dato[3] = this.mskStock.Text;
            dato[4] = this.cmbCategorias.Text;
            dato[5] = this.cmbEstado.Text;
            for (int i = 0; i < 6; i++)
            {
                if (dato[i].Equals(""))
                {
                    bandera = 1;
                }
            }
            return bandera;
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Limpiar()
        {
            this.txtNombre.Clear();
            this.txtDescripcion.Clear();
            this.mskPrecio.Clear();
            this.mskStock.Clear();
            this.cmbCategorias.SelectedIndex = 1;
            this.cmbEstado.SelectedIndex = 1;
        }
    }

}
