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

namespace Vista.Seguridad
{
    public partial class Bitacoras_View : Form
    {
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;
        private DataTable datos;
        public Bitacoras_View()
        {
            InitializeComponent();
        }

        private void Bitacoras_View_Load(object sender, EventArgs e)
        {

        }
        public void cargarDatosDtg()
        {
            try
            {
                dtgBitacoras.DataSource = null;
                bitacoras = new Bitacoras();
                string radioselect = String.Empty;
                foreach (RadioButton radio in gbox3.Controls)
                {
                    if (radio.Checked)
                        radioselect = radio.Text;
                }
                if (radioselect.Equals("Movimientos"))
                {
                    bitacoras.Tabla = "M";
                }
                else
                {
                    bitacoras.Tabla = "S";
                }
               
                bitacoras.Opc = 3;
                bitacoras.Fecha = DateTime.Today;               
                bitacorasH = new BitacorasHelper(bitacoras);
                datos = bitacorasH.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgBitacoras.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdbM_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }

        private void rdbS_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }

        public void cargarDatosDtgFiltro()
        {
            try
            {
                if (this.cmbDato.Text.Equals(""))
                {
                    MessageBox.Show("Debe seleccionar el campo buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgBitacoras.DataSource = null;
                    bitacoras = new Bitacoras();

                    //para ver cual tabla cargar
                    string radioselect = String.Empty;
                    foreach (RadioButton radio in gbox3.Controls)
                    {
                        if (radio.Checked)
                            radioselect = radio.Text;
                    }
                    if (radioselect.Equals("Movimientos"))
                    {
                        bitacoras.Tabla = "M";
                    }
                    else
                    {
                        bitacoras.Tabla = "S";
                    }

                    //para filtrar busqueda
                    bitacoras.Accion = this.cmbDato.Text;
                    bitacoras.Opc = 4;
                    bitacoras.Fecha = this.dtpFecha.Value;
                    bitacorasH = new BitacorasHelper(bitacoras);
                    datos = bitacorasH.Buscar();

                    if (datos.Rows.Count > 0)
                    {
                        dtgBitacoras.DataSource = datos;
                    }
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarDatosDtgFiltro();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
