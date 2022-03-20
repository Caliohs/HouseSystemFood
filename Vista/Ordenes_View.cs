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
    public partial class Ordenes_View : Form
    {

        private DataTable datos;
        private Productos productos;
        private ProductosHelper productosH;
        private Categorias categorias;
        private CategoriasHelper categoriasH;
        private Ordenes ordenes;
        private OrdenesHelper ordenesH; 
        private Cobros_View cobros_View;
        private Principal principal;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;

        public int UserId;

        public Ordenes_View()
        {
            InitializeComponent();
        }
        public Ordenes_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        private void Ordenes_View_Load(object sender, EventArgs e)
        {
         
            CrearDataGridOrdenes();
            cargarCmbCategorias();
        }
        public void cargarDatosDtg()
        {
            try
            {
                productos = new Productos();
                productos.Opc = 6;
                productosH = new ProductosHelper(productos);
                datos = productosH.ListarDtgProductos(this.cmbCategorias.Text);              
                if (datos.Rows.Count > 0)
                {
                    dtgProductos.DataSource = datos;
                }
                this.dtgProductos.Columns[0].Visible = false;
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
            try
            {
                //guarda nueva orden
                if (!this.cmbMesa.Text.Equals(""))
            {
                    //genero un numero de orden aleatorio con el num_mesa + random 
                    string Num_orden = "0";
                    Random rnd = new Random();
                    Num_orden = this.cmbMesa.Text + (rnd.Next().ToString().Substring(0,4));
                    
                    int n_indices = dtgOrdenes.RowCount;
                    for (int i = 0; i < n_indices; i++)
                    {

                        if (dtgOrdenes.CurrentRow != null)
                        {
                            ordenes = new Ordenes();

                            ordenes.Num_Orden = int.Parse(Num_orden);
                            ordenes.IdProducto = int.Parse(dtgOrdenes.Rows[i].Cells[0].Value.ToString());
                            ordenes.Cantidad = int.Parse(dtgOrdenes.Rows[i].Cells[1].Value.ToString());
                            ordenes.Total = int.Parse(dtgOrdenes.Rows[i].Cells[4].Value.ToString());
                            ordenes.Num_Mesa = int.Parse(this.cmbMesa.Text);

                        }
                        ordenes.Opc = 1;
                        ordenesH = new OrdenesHelper(ordenes);
                        ordenesH.Guardar();
                        
                    }
                    RegistarEnBitacora("INSERT");
                    MessageBox.Show("Se ha almacenado la orden n° " + Num_orden);
                    ReiniciarOrdenes();
                }
            else
            {
                MessageBox.Show("Selecciones el numero de mesa","Alerta");
            }
           
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // elimina un item y recalcula el total
        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //ellimna la linea
                this.dtgOrdenes.Rows.Remove(dtgOrdenes.CurrentRow);

                //recalcula
                int subt = 0;
                int n_indices = dtgOrdenes.RowCount;
                for (int i = 0; i < n_indices; i++)
                {

                    if (dtgOrdenes.CurrentRow != null)
                    {
                        ordenes = new Ordenes();
                        subt = subt + int.Parse(dtgOrdenes.Rows[i].Cells[4].Value.ToString());
                    }

                }               
                this.lbMontoT.Text = subt.ToString();
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

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (!this.txtProductoSelecionado.Text.Equals(""))
            {
                
                    if (int.Parse(this.lbCont.Text) >= 1)
                    {
                        this.lbCont.Text = (int.Parse(this.lbCont.Text) - 1).ToString();
                    }
             }
            else
            {
                MessageBox.Show("Seleccione un producto a la Izquierda con un click", "Alerta");
            }        
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (!this.txtProductoSelecionado.Text.Equals(""))
            {

                if (int.Parse(this.lbCont.Text) >= 0)
                {
                    this.lbCont.Text = (int.Parse(this.lbCont.Text) + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto a la Izquierda con un click", "Alerta");
            }
        }
    

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }

        public void CrearDataGridOrdenes()
        {
            dtgOrdenes.Columns.Add("Id", "Id");
            dtgOrdenes.Columns.Add("Cantidad", "Cantidad");
            dtgOrdenes.Columns.Add("Producto", "Producto");
            dtgOrdenes.Columns.Add("Precio", "Precio");
            dtgOrdenes.Columns.Add("Total", "Total");
            dtgOrdenes.Columns[0].Visible = false;
        }

        private  int idP =0;
        private int precio = 0;
        private int cantidad = 0;
        private int totalXproducto = 0;

        public void AgregarAOrden()
        {
            try
            {
                cantidad = int.Parse(this.lbCont.Text);
                totalXproducto = precio * cantidad;
              //averiguo si hay disponibles
                int stock = int.Parse(dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells[4].Value.ToString());
                if (cantidad != 0 && stock >= cantidad)
                {
                    dtgOrdenes.Rows.Add(idP,cantidad, this.txtProductoSelecionado.Text, precio, totalXproducto);

                    int total = int.Parse(this.lbMontoT.Text);
                    this.lbMontoT.Text = (total + totalXproducto).ToString();
                }
                else
                {
                   MessageBox.Show("Verifique la cantidad seleccionada o el Stock del producto", "Alerta");
                }
             
            }
            catch
            {
                MessageBox.Show("Error al agregar a Orden", "Alerta");
            }
            this.lbCont.Text = "0";
            idP = 0;
            precio = 0;
            cantidad = 0;
            totalXproducto = 0;
            this.txtProductoSelecionado.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AgregarAOrden();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //capturo id producto
                idP = int.Parse(this.dtgProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                //capturo  producto
                this.txtProductoSelecionado.Text = dtgProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                //capturo id precio
                precio = int.Parse(this.dtgProductos.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {
                this.txtProductoSelecionado.Text = "";
                precio = 0;
            }
        }

        public void ReiniciarOrdenes()
        {
            this.dtgOrdenes.Columns.Clear();
            this.dtgOrdenes.Rows.Clear();
            this.txtProductoSelecionado.Text="";
            this.lbCont.Text = "0";
            this.lbMontoT.Text = "0";
            this.cmbMesa.SelectedIndex = -1;
            CrearDataGridOrdenes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarOrdenes();
        }

        private void dtgProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //capturo id producto
                idP = int.Parse(this.dtgProductos.CurrentRow.Cells[0].Value.ToString());
                //capturo  producto
                this.txtProductoSelecionado.Text = dtgProductos.CurrentRow.Cells[1].Value.ToString();
                //capturo id precio
                precio = int.Parse(this.dtgProductos.CurrentRow.Cells[3].Value.ToString());
            }
            catch
            {
                this.txtProductoSelecionado.Text = "";
                precio = 0;
            }
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
                bitacoras.Tabla = "ORDENES";
                bitacoras.Fecha = DateTime.Now;
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
