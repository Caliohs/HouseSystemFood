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
    public partial class Categorias_View : Form
    {

        private DataTable datos;
        private Categorias categorias;
        private CategoriasHelper categoriasH;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;

        public int UserId;

        public Categorias_View()
        {
            InitializeComponent();
        }
        public Categorias_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        private void Categorias_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }
        public void cargarDatosDtg()
        {
            try
            {
                categorias = new Categorias();
                categorias.Opc = 2;
                categoriasH = new CategoriasHelper(categorias);
                datos = categoriasH.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgCategorias.DataSource = datos;
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
                //valido campo llenos
                if (this.txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else   //hago el isert o update
                {
                    categorias = new Categorias();
                    categorias.Nombre = this.txtNombre.Text;
                    categorias.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());

                    if (this.btnAceptar.Text.Equals("Aceptar"))
                    {
                        categorias.Opc = 1;
                        categoriasH = new CategoriasHelper(categorias);
                        categoriasH.Guardar();
                        RegistarEnBitacora("INSERT");
                        MessageBox.Show("Se ha almacenado una categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        datos = (DataTable)dtgCategorias.DataSource;
                        int indice = dtgCategorias.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        categorias.Opc = 4;
                        categorias.Id = int.Parse(fila["IdCategoria"].ToString());
                        categoriasH = new CategoriasHelper(categorias);
                        categoriasH.Actualizar();
                        RegistarEnBitacora("UPDATE");
                        MessageBox.Show("Se actualizó la categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.btnAceptar.Text = "Aceptar";
                    }

                    cargarDatosDtg();
                    this.txtNombre.Text = "";
                }
                   
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
                categorias = new Categorias();
                categorias.Opc = 3;
                categorias.Nombre = this.txtBuscar.Text;
                categoriasH = new CategoriasHelper(categorias);
                datos = categoriasH.Buscar();

                if (datos.Rows.Count > 0)
                {
                    dtgCategorias.DataSource = datos;
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
                datos = (DataTable)dtgCategorias.DataSource;

                int indice = dtgCategorias.CurrentRow.Index;
                DataRow fila = datos.Rows[indice];
               
                this.txtNombre.Text = fila["NombreCategoria"].ToString();
              
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

                datos = (DataTable)dtgCategorias.DataSource;
                if (datos == null)
                {
                    MessageBox.Show("No hay registros por Eliminar","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result.Equals(DialogResult.Yes))
                    {
                        int indice = dtgCategorias.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        categorias = new Categorias();
                        categorias.Opc = 5;
                        categorias.Id = int.Parse(fila["IdCategoria"].ToString());
                        categoriasH = new CategoriasHelper(categorias);
                        categoriasH.Eliminar();
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


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RegistarEnBitacora(string accion)
        {
            try
            {
                bitacoras = new Bitacoras();
                //registro el evento
                bitacoras.Opc = 1;
                bitacoras.IdUser = UserId;
                bitacoras.Accion = accion;
                bitacoras.Tabla = "CATEGORIAS";
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
