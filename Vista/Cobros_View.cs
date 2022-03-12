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
    public partial class Cobros_View : Form
    {

        private DataTable datos;
        private Ordenes ordenes;
        private OrdenesHelper ordenesH;
        private Cobros cobros;
        private CobrosHelper cobrosH;


        public Cobros_View()
        {
            InitializeComponent();
        }

        private void Cobros_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtgOrdenes();
        }

        public void cargarDatosDtgOrdenes()
        {
            try
            {
                ordenes = new Ordenes();
                ordenes.Opc = 2;
                ordenesH = new OrdenesHelper(ordenes);
                datos = ordenesH.Listar();              
                if (datos.Rows.Count > 0)
                {
                    dtgOrdenesPorCobrar.DataSource = datos;
                }
                this.dtgOrdenesPorCobrar.Columns[2].Visible = false;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarDatosDtgOrdenesFiltro()
        {
            try
            {
                ordenes = new Ordenes();
                ordenes.Opc = 3;
                ordenes.Num_Mesa = int.Parse(this.cmbMesa.Text);
                ordenesH = new OrdenesHelper(ordenes);
                datos = ordenesH.Buscar();
                if (datos.Rows.Count > 0)
                {
                    dtgOrdenesPorCobrar.DataSource = datos;
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
            try
            {
                string radioselect = String.Empty;
                foreach (RadioButton radio in gbox3.Controls)
                {
                    if (radio.Checked)
                        radioselect = radio.Text;
                }
                //guarda nuevo cobro/venta/pago              
                cobros = new Cobros();

                cobros.Num_Orden = int.Parse(this.lbNorden.Text);
                cobros.Subtotal= int.Parse(this.lbSubtotal.Text);
                cobros.Descuento = int.Parse(this.lbDescuento.Text);
                cobros.Iva = float.Parse(this.lbIva.Text);
                cobros.Total = int.Parse(this.lbTotal.Text);
                cobros.MetodoPago = radioselect;
                cobros.FechaVenta = DateTime.Today;
                cobros.UsuarioId = 2;
                cobros.Opc = 1;
                cobrosH = new CobrosHelper(cobros);
                cobrosH.Guardar();
                    
                MessageBox.Show("Pago registrado exitosamente exitosamente");                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    datos = (DataTable)dtgOrdenesPorCobrar.DataSource;
            //    if (datos == null)
            //    {
            //        MessageBox.Show("No hay registros por Eliminar");

            //    }
            //    else
            //    {
            //        DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo);
            //        if (result.Equals(DialogResult.Yes))
            //        {
            //            int indice = dtgOrdenesPorCobrar.CurrentRow.Index;
            //            DataRow fila = datos.Rows[indice];

            //            productos = new Productos();
            //            productos.Opc = 5;
            //            productos.Id = int.Parse(fila["IdProducto"].ToString());
            //            productosH = new ProductosHelper(productos);
            //            productosH.Eliminar();

            //            MessageBox.Show("Se ha eliminado el registro");
            //            cargarDatosDtg();
            //        }


            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private  int idP =0;
        private int precio = 0;
        private int cantidad = 0;
        private int totalXproducto = 0;

        public void AgregarAOrden()
        {
            //try
            //{
            //    cantidad = int.Parse(this.lbCont.Text);
            //    totalXproducto = precio * cantidad;
            //  //averiguo si hay disponibles
            //    int stock = int.Parse(dtgOrdenesPorCobrar.Rows[dtgOrdenesPorCobrar.CurrentRow.Index].Cells[4].Value.ToString());
            //    if (cantidad != 0 && stock >= cantidad)
            //    {
            //        dtgOrdenDetalle.Rows.Add(idP,cantidad, this.txtMonto.Text, precio, totalXproducto);

            //        int total = int.Parse(this.lbMontoT.Text);
            //        this.lbMontoT.Text = (total + totalXproducto).ToString();
            //    }
            //    else
            //    {
            //       MessageBox.Show("Verifique la cantidad seleccionada o el Stock del producto", "Alerta");
            //    }
             
            //}
            //catch
            //{
            //    MessageBox.Show("Error al agregar a Orden", "Alerta");
            //}
            //this.lbCont.Text = "0";
            //idP = 0;
            //precio = 0;
            //cantidad = 0;
            //totalXproducto = 0;
            //this.txtMonto.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AgregarAOrden();
        }

        public void ReiniciarOrdenes()
        {
            //this.dtgOrdenDetalle.Columns.Clear();
            //this.dtgOrdenDetalle.Rows.Clear();
            //this.txtMonto.Text="";
            //this.lbCont.Text = "0";
            //this.lbMontoT.Text = "0";
            //this.cmbMesa.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarOrdenes();
        }

        private void dtgOrdenesPorCobrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int nOrden= int.Parse(dtgOrdenesPorCobrar.Rows[dtgOrdenesPorCobrar.CurrentRow.Index].Cells[0].Value.ToString());
                ordenes = new Ordenes();
                ordenes.Opc = 4;
                ordenes.Num_Orden = nOrden;
                ordenesH = new OrdenesHelper(ordenes);
                datos = ordenesH.ListarOrden();
                if (datos.Rows.Count > 0)
                {
                    dtgOrdenDetalle.DataSource = datos;
                    this.cmbDescuento.SelectedIndex = 0;                 
                    calcular();
                }
                this.lbNorden.Text = nOrden.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        public void calcular()
        {
            try {

                int subt = 0;

                int n_indices = dtgOrdenDetalle.RowCount;
             for (int i = 0; i < n_indices; i++)
             {

                if (dtgOrdenDetalle.CurrentRow != null)
                {
                    ordenes = new Ordenes();                 
                    subt = subt +  int.Parse(dtgOrdenDetalle.Rows[i].Cells[2].Value.ToString());
                }
                
             }
                this.lbSubtotal.Text = subt.ToString();
                this.lbDescuento.Text = (subt * (float.Parse(this.cmbDescuento.Text) / 100)).ToString();
                this.lbTotal.Text = (subt - int.Parse(this.lbDescuento.Text)).ToString();
                this.lbIva.Text = (int.Parse(this.lbTotal.Text) * 0.13).ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatosDtgOrdenesFiltro();
        }

        private void cmbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void cmbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosDtgOrdenesFiltro();
        }

        private void dtgOrdenesPorCobrar_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int nOrden = int.Parse(dtgOrdenesPorCobrar.Rows[dtgOrdenesPorCobrar.CurrentRow.Index].Cells[0].Value.ToString());
                ordenes = new Ordenes();
                ordenes.Opc = 4;
                ordenes.Num_Orden = nOrden;
                ordenesH = new OrdenesHelper(ordenes);
                datos = ordenesH.ListarOrden();
                if (datos.Rows.Count > 0)
                {
                    dtgOrdenDetalle.DataSource = datos;
                    this.cmbDescuento.SelectedIndex = 0;
                    calcular();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rdbColon_CheckedChanged(object sender, EventArgs e)
        {
            this.lbPag.Text = "A pagar ₡";
            this.lbApagar.Text =this.lbTotal.Text;
            this.btnAceptar.Text = "Pagar " + "₡" + this.lbApagar.Text;
            this.mskMonto.Text = "0";
        }

        private void rdbDolar_CheckedChanged(object sender, EventArgs e)
        {
            this.lbPag.Text = "A pagar $";
            this.lbApagar.Text = (int.Parse(this.lbTotal.Text) / int.Parse(this.mskDolar.Text)).ToString();
            this.btnAceptar.Text = "Pagar $" + this.lbApagar.Text;
            this.mskMonto.Text = "0";
        }

        private void rdbSinpe_CheckedChanged(object sender, EventArgs e)
        {
            this.lbPag.Text = "A pagar ₡";
            this.lbApagar.Text = this.lbTotal.Text;
            this.mskMonto.Enabled = false;
            this.btnAceptar.Text = "Pagar ₡" + this.lbApagar.Text;
            this.mskMonto.Text = "0";
        }

        private void mskMonto_TextChanged(object sender, EventArgs e)
        {
            if (this.rdbDolar.Checked == true)
            {
                this.btnAceptar.Text = "Pagar $" + this.lbTotal.Text;
            }
            else
            {
                this.btnAceptar.Text = "Pagar ₡" + this.lbTotal.Text;
            }
           
        }

        private void lbDescuento_Click(object sender, EventArgs e)
        {

        }
    }

}
