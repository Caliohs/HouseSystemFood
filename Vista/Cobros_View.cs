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
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;
        public int UserId;


        public Cobros_View()
        {
            InitializeComponent();
        }
        public Cobros_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        private void Cobros_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtgOrdenes();
            CargarTipoCambio();
        }

        public void cargarDatosDtgOrdenes()
        {
            try
            {
                
                ordenes = new Ordenes();
                ordenes.Opc = 2;
                ordenesH = new OrdenesHelper(ordenes);
                datos = ordenesH.Listar();
                if (datos.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No hay Ordenes por cobrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgOrdenesPorCobrar.DataSource = datos;
                    this.dtgOrdenesPorCobrar.Columns[2].Visible = false;
                }            
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
                if (datos.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No hay Ordenes para esta mesa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgOrdenesPorCobrar.DataSource = datos;
                    this.dtgOrdenesPorCobrar.Columns[2].Visible = false;
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
                double n1 = 0;
                double n2 = 0;
                string radioselect = String.Empty;
                foreach (RadioButton radio in gbox3.Controls)
                {
                    if (radio.Checked)
                        radioselect = radio.Text;
                }
                if (!this.mskMonto.Text.Equals("")) // para darle un valor 0 si esta en blanco
                {
                    n1 = double.Parse(this.mskMonto.Text);
                }              
                n2 = double.Parse(this.lbApagar.Text);
                //restrcciones y validaciones
                if (this.lbTotal.Text.Equals("0"))
                {
                    MessageBox.Show("Información incompleta!, revise el TOTAL","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.mskMonto.Text.Equals(""))
                {
                    MessageBox.Show("Información incompleta!, revise PAGAR CON", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioselect.Equals(""))
                {
                    MessageBox.Show("Información incompleta!, revise el Metodo de pago", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
                else if (n1 < n2)
                {
                    MessageBox.Show("El monto ingresado es menor al total a pagar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else  //haga el proceso
                {
                    string fecha = DateTime.Today.ToString("dd-MM-yyyy");
                    //guarda nuevo cobro/venta/pago              
                    cobros = new Cobros();

                    cobros.Num_Orden = int.Parse(this.lbNorden.Text);
                    cobros.Subtotal = int.Parse(this.lbSubtotal.Text);
                    cobros.Descuento = int.Parse(this.lbDescuento.Text);
                    cobros.Iva = float.Parse(this.lbIva.Text);
                    cobros.Total = int.Parse(this.lbTotal.Text);
                    cobros.MetodoPago = radioselect;
                    cobros.FechaVenta = Convert.ToDateTime(fecha);
                    cobros.UsuarioId = UserId;
                    cobros.Opc = 1;
                    cobrosH = new CobrosHelper(cobros);
                    cobrosH.Guardar();
 
                    RegistarEnBitacora("INSERT");

                    string cambio = ((float.Parse(this.mskMonto.Text)) - (float.Parse(this.lbApagar.Text))).ToString("0.00");   
                    this.lbCambio.Text = cambio;
                  
                    MessageBox.Show("Pago registrado exitosamente","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                  
                    ReiniciarCobros();
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

                datos = (DataTable)dtgOrdenesPorCobrar.DataSource;
                if (datos == null)
                {
                    MessageBox.Show("No hay registros por Eliminar","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
                    if (result.Equals(DialogResult.Yes))
                    {
                        MessageBox.Show("Debe devolver estos productos al Stock", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        int indice = dtgOrdenesPorCobrar.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        ordenes = new Ordenes();
                        ordenes.Opc = 5;
                        ordenes.Num_Orden  = int.Parse(fila["num_Orden"].ToString());
                        ordenesH = new OrdenesHelper(ordenes);
                        ordenesH.Eliminar();
                        RegistarEnBitacora("DELETE");
                        MessageBox.Show("Se ha eliminado la Orden","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatosDtgOrdenes();
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

        //limpia los valores 
        public void ReiniciarCobros()
        {
            try
            {
            this.dtgOrdenesPorCobrar.DataSource = null;
            cargarDatosDtgOrdenes();
            this.dtgOrdenDetalle.DataSource = null;
            this.lbSubtotal.Text = "0";
            this.lbIva.Text = "0";
            this.lbDescuento.Text = "0";
            this.lbTotal.Text = "0";
            this.lbNorden.Text = "0";
            this.lbApagar.Text = "0";              
            this.mskMonto.Text = "";
            this.mskMonto.Enabled=true;
            this.btnAceptar.Text = "Pagar";           
            this.cmbDescuento.SelectedIndex = 0;
            this.lbC.Text = "Cambio ₡ ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarCobros();
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
                this.lbCambio.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        //calcula montos de la orden
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
        //gestiono las acciones de los radio BUtton
        private void rdbColon_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            this.lbPag.Text = "A pagar ₡";
            this.lbApagar.Text =this.lbTotal.Text;
            this.btnAceptar.Text = "Pagar ₡" + this.lbApagar.Text;
            this.mskMonto.Text = "";
            this.mskMonto.Enabled=true;
            }
            catch
            {
                MessageBox.Show("No se puede calcular un monto a pagar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbDolar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.lbPag.Text = "A pagar $";
                this.lbApagar.Text = (double.Parse(this.lbTotal.Text) / double.Parse(this.mskDolar.Text)).ToString("0.00");
                this.btnAceptar.Text = "Pagar $" + this.lbApagar.Text;
                this.mskMonto.Text = "";
                this.mskMonto.Enabled = true;
                this.lbC.Text = "Cambio $";
            }
            catch
            {
                MessageBox.Show("No se puede calcular un monto a pagar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbSinpe_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            this.lbPag.Text = "A pagar ₡";
            this.lbApagar.Text = this.lbTotal.Text;
            this.mskMonto.Enabled = false;
            this.btnAceptar.Text = "Pagar ₡" + this.lbApagar.Text;
            this.mskMonto.Text = this.lbApagar.Text;
            }
            catch
            {
                MessageBox.Show("No se puede calcular un monto a pagar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //inserta en txt del boton a pagar, el monto
        private void mskMonto_TextChanged(object sender, EventArgs e)
        {
            try {
            if (this.rdbDolar.Checked == true)
            {
                this.btnAceptar.Text = "Pagar $" + this.lbApagar.Text;
            }
            else
            {
                this.btnAceptar.Text = "Pagar ₡" + this.lbApagar.Text;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //gestiono el tipo de cambio a nivel de base de datos
        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkEnable.Checked.Equals(true))
                  {
                    cobros = new Cobros();
            
                    cobros.Opc = 3;
                    cobros.Id = int.Parse(this.mskDolar.Text);
                    cobrosH = new CobrosHelper(cobros);
                    cobrosH.ActualizaTipoCambio();
                    RegistarEnBitacora("UPDATE-TIPOCAMBIO");
                 MessageBox.Show("Se actualizó el tipo de cambio a " + int.Parse(this.mskDolar.Text));
                    CargarTipoCambio();
                this.mskDolar.Enabled = false;
                 }
                 else
                 {
                this.mskDolar.Enabled = true;
                 }
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarTipoCambio()
        {
            try {
                cobros = new Cobros();

                cobros.Opc = 2;
                cobrosH = new CobrosHelper(cobros);
               datos= cobrosH.CargarTipoCambio();
               this.mskDolar.Text = datos.Rows[0][0].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.dtgOrdenesPorCobrar.DataSource = null;
            cargarDatosDtgOrdenes();
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
                bitacoras.Tabla = "VENTAS";
                bitacoras.Fecha = DateTime.Now;
                bitacorasH = new BitacorasHelper(bitacoras);
                bitacorasH.InsertarEnBitacora();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dtgOrdenesPorCobrar_SelectionChanged(object sender, EventArgs e)
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
                this.lbNorden.Text = nOrden.ToString();
                this.lbCambio.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
