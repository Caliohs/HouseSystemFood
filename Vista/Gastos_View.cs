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
    public partial class Gastos_View : Form
    {
        private Gastos gastos;
        private GastosHelper gastosH;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;
        private DataTable datos;
        public int UserId;
        public Gastos_View()
        {
            InitializeComponent();
        }
        public Gastos_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        public void cargarDatosDtg()
        {
            try
            {
                gastos = new Gastos();
                gastos.Opc = 2;
                gastosH = new GastosHelper(gastos);
                datos = gastosH.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgGastos.DataSource = datos;
                    dtgGastos.Columns[0].Visible = false;
                    dtgGastos.Columns[3].Width = 200;
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
                //valido los campos
                if (this.txtJustificacion.Text.Equals("") || this.mskMonto.Text.Equals(""))
                {
                    MessageBox.Show("Debe completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else // campos , ejecuto
                {
                   
                    gastos = new Gastos();
                    gastos.Tipo = ObtenerTipo();
                    gastos.Justificacion = this.txtJustificacion.Text;
                    gastos.Monto = int.Parse(this.mskMonto.Text);

                    if (this.rdbColon.Checked.Equals(true)) { gastos.Moneda = "Colones"; }
                    else { gastos.Moneda = "Dolares"; }

                    gastos.Fecha = Convert.ToDateTime(this.dtpFecha.Value.ToString("dd/MM/yyyy"));
                    
                    if (this.btnAceptar.Text.Equals("Aceptar"))
                    {
                        gastos.Opc = 1;
                        gastosH = new GastosHelper(gastos);
                        gastosH.Guardar();
                        RegistarEnBitacora("INSERT");
                        cargarDatosDtg();
                        MessageBox.Show("Se ha almacenado un nuevo Gasto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        datos = (DataTable)dtgGastos.DataSource;
                        int indice = dtgGastos.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        gastos.Opc = 4;
                        gastos.Id = int.Parse(fila["IdGasto"].ToString());
                        gastosH = new GastosHelper(gastos);
                        gastosH.Actualizar();
                        RegistarEnBitacora("UPDATE");
                        cargarDatosDtg();
                        MessageBox.Show("Se actualizó el Gasto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.btnAceptar.Text = "Aceptar";
                    }

                   
                    //limpio
                    this.txtJustificacion.Text="";
                    this.mskMonto.Text = "";
                    this.chkRetiro.Checked = false;
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
                datos = (DataTable)dtgGastos.DataSource;
                
                int indice = dtgGastos.CurrentRow.Index;
                DataRow fila = datos.Rows[indice];

                string radioselect = fila["Tipo"].ToString();
                foreach (RadioButton radio in gbox3.Controls)
                {
                    switch (radioselect)  //obtengo el tipo
                    {
                        case "PR" : rdbProd.Checked = true; break;
                        case "UT": rdbUten.Checked = true; break;
                        case "PL": rdbPlanilla.Checked = true; break;
                        case "SE": rdbServ.Checked = true; break;
                        case "OT": rdbOtro.Checked = true; break;
                    }
                    // para saber si es un retiro de caja
                    if (radioselect.Equals("R" + radioselect))
                    {
                        chkRetiro.Checked = true;
                    }

                }
                string moneda = fila["Moneda"].ToString();
                this.txtJustificacion.Text = fila["Justificacion"].ToString();
                this.mskMonto.Text= fila["Monto"].ToString();

                if (moneda.Equals("Colones")) { this.rdbColon.Checked=true; }
                else { this.rdbDolar.Checked = true; }

                this.dtpFecha.Text = fila["FechaIngreso"].ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public string ObtenerTipo()
        {

            string tipo = String.Empty;
            try
            {           
                foreach (RadioButton radio in gbox3.Controls)
                {
                    if (radio.Checked)
                        switch (radio.Name)
                        {
                            case "rdbProd" : tipo = "PR"; break; 
                            case "rdbUten" : tipo = "UT"; break; 
                            case "rdbPlanilla" : tipo = "PL"; break; 
                            case "rdbServ" : tipo = "SE"; break; 
                            case "rdbOtro" : tipo = "OT"; break; 
                        }
                }
                //saber si es un retiro de Caj
                if (this.chkRetiro.Checked.Equals(true))
                {
                    tipo = "R" + tipo;
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tipo;
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
                bitacoras.Tabla = "GASTOS";
                bitacoras.Fecha = DateTime.Today;
                bitacorasH = new BitacorasHelper(bitacoras);
                bitacorasH.InsertarEnBitacora();
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
                gastos = new Gastos();
                gastos.Opc = 3;
                gastos.Justificacion = this.txtBuscar.Text;
                gastosH = new GastosHelper(gastos);
                datos = gastosH.Buscar();

                if (datos.Rows.Count > 0)
                {
                    dtgGastos.DataSource = datos;
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

                datos = (DataTable)dtgGastos.DataSource;
                if (datos == null)
                {
                    MessageBox.Show("No hay registros por Eliminar");

                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (result.Equals(DialogResult.Yes))
                    {
                        int indice = dtgGastos.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        gastos = new Gastos();
                        gastos.Opc = 5;
                        gastos.Id = int.Parse(fila["IdGasto"].ToString());
                        gastosH = new GastosHelper(gastos);
                        gastosH.Eliminar();
                        RegistarEnBitacora("DELETE");
                        cargarDatosDtg();
                        MessageBox.Show("Se ha eliminado el registro","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gastos_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }

        private void gBox_Enter(object sender, EventArgs e)
        {

        }

        private void dtgGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gboxMoneda_Enter(object sender, EventArgs e)
        {

        }

        private void gbox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
