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
            Guardar();
        }

        public void Guardar()
        {
            //guarda nueva categoria
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
                        MessageBox.Show("Se ha almacenado un nuevo Producto");
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
                        MessageBox.Show("Se actualizó el Producto");

                        this.btnAceptar.Text = "Aceptar";
                    }
                    
               
                cargarDatosDtg();
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
                    MessageBox.Show("No hay registros por Eliminar");

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
                        MessageBox.Show("Se ha eliminado el registro");
                        cargarDatosDtg();
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
    }

}
