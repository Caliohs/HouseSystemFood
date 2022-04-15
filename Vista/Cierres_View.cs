using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseSystemFood.Controlador;

namespace Vista
{
    public partial class Cierres_View : Form
    {
        private Cierres cierres;
        private CierresHelper cierresH;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;
        private DataTable datos;

        private int UserId;

        public Cierres_View()
        {
            InitializeComponent();
        }
        public Cierres_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        private void Cierres_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtgCierresCol();
            cargarDatosDtgCierresDol();
            CargarMontosIniciales();
        }

        public void cargarDatosDtgCierresCol()
        {
            try
            {

                cierres = new Cierres();
                cierres.Opc = 4;
                cierresH = new CierresHelper(cierres);
                datos = cierresH.Listar();
                if (datos.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No hay Cierres por listar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgCierresColon.DataSource = datos;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarDatosDtgCierresDol()
        {
            try
            {

                cierres = new Cierres();
                cierres.Opc = 8;
                cierresH = new CierresHelper(cierres);
                datos = cierresH.Listar();
                if (datos.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No hay Cierres por listar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgCierresDolar.DataSource = datos;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarDatosDtgRetiros()
        {
            try
            {

                cierres = new Cierres();
                cierres.Opc = 6;
                cierres.FechaCierre = DateTime.Today;
                cierresH = new CierresHelper(cierres);
                datos = cierresH.Buscar();
                if (datos.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No hay retiros de caja por listar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgRetiros.DataSource = datos;
                    this.dtgRetiros.Columns[0].Visible = false;
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarDatosDtgVentas()
        {
            try
            {

                cierres = new Cierres();
                cierres.Opc = 7;
                cierres.FechaCierre = DateTime.Today;
                cierresH = new CierresHelper(cierres);
                datos = cierresH.Buscar();
                if (datos.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No hay ventas  por listar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgVentas.DataSource = datos;
                    this.dtgVentas.Columns[0].Visible = false;
                    this.dtgVentas.Columns[8].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarDtgCierresFiltroColon()
        {
            try
            {
                cierres = new Cierres();
                cierres.Opc = 5;
                cierres.FechaCierre = this.dtpFechaCol.Value;
                cierresH = new CierresHelper(cierres);
                datos = cierresH.Buscar();
                if (datos.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No hay Cierres para esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgCierresColon.DataSource = datos;
                    this.dtgCierresColon.Columns[0].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarDtgCierresFiltroDolar()
        {
            try
            {
                cierres = new Cierres();
                cierres.Opc = 9;
                cierres.FechaCierre = this.dtpFechaDol.Value;
                cierresH = new CierresHelper(cierres);
                datos = cierresH.Buscar();
                if (datos.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No hay Cierres para esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgCierresDolar.DataSource = datos;
                    this.dtgCierresDolar.Columns[0].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //actualiza tipo cambio
        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkEnable.Checked.Equals(true))
                {
                    cierres = new Cierres();

                    cierres.Opc = 3;
                    cierres.Id = 1;
                    cierres.InicialColon = int.Parse(this.mskTipoCambio.Text);
                    cierresH = new CierresHelper(cierres);
                    cierresH.ActualizaMontosIniciales();
                    RegistarEnBitacora("UPDATE-TIPOCAMBIO");
                    this.mskTipoCambio.Enabled = false;
                    MessageBox.Show("Se actualizó el tipo de cambio a " + int.Parse(this.mskTipoCambio.Text));
                    CargarMontosIniciales();
                   
                }
                else
                {
                    this.mskTipoCambio.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //carga montos iniciales
        public void CargarMontosIniciales()
        {
            try
            {
                cierres = new Cierres();

                cierres.Opc = 2;
                cierresH = new CierresHelper(cierres);
                datos = cierresH.CargarMontosIniciales();
                this.mskTipoCambio.Text = datos.Rows[0][0].ToString();
                this.mskColon.Text= datos.Rows[1][0].ToString();
                this.mskDolar.Text = datos.Rows[2][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //actualiza inicial colon
        private void chkCol_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkCol.Checked.Equals(true))
                {
                    cierres = new Cierres();

                    cierres.Opc = 3;
                    cierres.Id = 2;
                    cierres.InicialColon = int.Parse(this.mskColon.Text);
                    cierresH = new CierresHelper(cierres);
                    cierresH.ActualizaMontosIniciales();
                    RegistarEnBitacora("UPDATE-INICIAL_COLON");
                    this.mskColon.Enabled = false;
                    MessageBox.Show("Se actualizó el monto inicial a " + int.Parse(this.mskColon.Text));
                    CargarMontosIniciales();
                  
                }
                else
                {
                    this.mskColon.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //actualiza inicial dolar
        private void chkDol_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkDol.Checked.Equals(true))
                {
                    cierres = new Cierres();

                    cierres.Opc = 3;
                    cierres.Id = 3;
                    cierres.InicialColon = int.Parse(this.mskDolar.Text);
                    cierresH = new CierresHelper(cierres);
                    cierresH.ActualizaMontosIniciales();
                    RegistarEnBitacora("UPDATE-INICIAL_DOLAR");
                    this.mskDolar.Enabled = false;
                    MessageBox.Show("Se actualizó el monto inicial a " + int.Parse(this.mskDolar.Text));
                    CargarMontosIniciales();
                   
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
        // registra los eventos
        public void RegistarEnBitacora(string accion)
        {
            try
            {
                bitacoras = new Bitacoras();
                //registro el evento
                bitacoras.Opc = 1;
                bitacoras.IdUser = UserId;
                bitacoras.Accion = accion;
                bitacoras.Tabla = "CIERRES";
                bitacoras.Fecha = DateTime.Now;
                bitacorasH = new BitacorasHelper(bitacoras);
                bitacorasH.InsertarEnBitacora();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
               this.Close();
            }
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            calcular();
        }

        public void calcular()
        {
            try
            {
                if(this.mskFColon.Text.Equals("0") || this.mskFDolar.Text.Equals("0"))
                {
                    MessageBox.Show("Debe completar los montos finales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cargarDatosDtgRetiros();
                    cargarDatosDtgVentas();
                    int ventasC = 0;
                    double ventasD = 0;

                    int n_indices = dtgVentas.RowCount;
                
                    for (int i = 0; i < n_indices; i++)
                    {
                              
                            string moneda = dtgVentas.Rows[i].Cells[6].Value.ToString();
                            if (moneda.Equals("Dolares"))
                            {
                                ventasD = ventasD + (float.Parse(dtgVentas.Rows[i].Cells[5].Value.ToString()) / float.Parse(this.mskTipoCambio.Text));
                            }
                            else
                            {
                                ventasC = ventasC + int.Parse(dtgVentas.Rows[i].Cells[5].Value.ToString());
                            }
                
                    }
                    this.lbAcumC.Text = ventasC.ToString();      
                    this.lbAcumD.Text = ventasD.ToString("0.00");
                    
                    int retiroC = 0;
                    double retiroD = 0;

                    int Rn_indices = dtgRetiros.RowCount;

                    for (int i = 0; i < Rn_indices; i++)
                    {
                       
                            string moneda = dtgRetiros.Rows[i].Cells[3].Value.ToString();
                            if (moneda.Equals("Dolares"))
                            {

                                retiroD = retiroD + (int.Parse(dtgRetiros.Rows[i].Cells[2].Value.ToString()) /*/ int.Parse(this.mskTipoCambio.Text)*/);
                            }
                            else
                            {
                                retiroC = retiroC + int.Parse(dtgRetiros.Rows[i].Cells[2].Value.ToString());
                            }

                    }
                    this.lbAcumRC.Text = retiroC.ToString();
                    this.lbAcumRD.Text = retiroD.ToString("0.00");

                    //calcula colones
                    int compareC = (int.Parse(this.mskColon.Text) + int.Parse(this.lbAcumC.Text) - int.Parse(this.lbAcumRC.Text));
                    this.lbCompareC.Text = (int.Parse(this.mskFColon.Text)  - compareC ).ToString();
                    this.lbNinicialC.Text = (int.Parse(this.mskColon.Text) - int.Parse(this.lbAcumRC.Text)).ToString();
                    //calcula dolares
                    float compareD = (float.Parse(this.mskDolar.Text) + float.Parse(this.lbAcumD.Text) - float.Parse(this.lbAcumRD.Text));                  
                    this.lbCompareD.Text = (float.Parse(this.mskFDolar.Text) - compareD).ToString("0.00");                  
                    this.lbNinicialD.Text = (float.Parse(this.mskDolar.Text) - float.Parse(this.lbAcumRD.Text)).ToString("00.00");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            try
            {
              
                string fecha = DateTime.Today.ToString("dd/MM/yyyy");
                //guarda nuevo cierre            
                cierres = new Cierres();

                cierres.InicialColon = int.Parse(this.mskColon.Text);
                cierres.InicialDolar = float.Parse(this.mskDolar.Text);
                cierres.FinalColon = int.Parse(this.mskFColon.Text);
                cierres.FinalDolar = float.Parse(this.mskFDolar.Text);
                cierres.VentasColon = int.Parse(this.lbAcumC.Text);
                cierres.VentasDolar = float.Parse(this.lbAcumD.Text);
                cierres.RetiroColon = int.Parse(this.lbAcumRC.Text);
                cierres.RetiroDolar = float.Parse(this.lbAcumRD.Text);
                cierres.DiferenciasColon = int.Parse(this.lbCompareC .Text);
                cierres.DiferenciasDolar = float.Parse(this.lbCompareD.Text);
                cierres.FechaCierre =  Convert.ToDateTime(fecha);   
                cierres.Opc = 1;
                cierresH = new CierresHelper(cierres);
                cierresH.Guardar();

                RegistarEnBitacora("INSERT");
                cargarDatosDtgCierresCol();
                cargarDatosDtgCierresDol();
                MessageBox.Show("Cierre registrado exitosamente","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //cargar busquedas de cierres
        private void dtpFechaDol_ValueChanged(object sender, EventArgs e)
        {
            cargarDtgCierresFiltroDolar();
        }

        private void dtpFechaCol_ValueChanged(object sender, EventArgs e)
        {
            cargarDtgCierresFiltroColon();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarDatosDtgCierresCol();
            cargarDatosDtgCierresDol();
           
        }
    }
}
