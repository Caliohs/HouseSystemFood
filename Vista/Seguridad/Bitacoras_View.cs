using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseSystemFood.Controlador;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

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
                    else
                    {
                        MessageBox.Show("No han encontrado registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        public void GenerarReporte()
        {

           string inicio = this.dtpFecha.Value.ToString("dd-MM-yyyy");
           
            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            BaseColor colorf = new BaseColor(51, 204, 0);
            Font fuente = new Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);
            Image jpg = Image.GetInstance(@"C:\Restaurant\FRONTEND\img\snacklogo1.png"); jpg.Alignment = Image.RIGHT_ALIGN;
            string filename = "C:\\Reportes\\Bitacora_" + inicio + ".pdf";
            Chunk encab = new Chunk(" HOUSE RESTAURANT FOOD ", FontFactory.GetFont("ARIAL", 15, colorf));
          
            try
            {

                FileStream file = new FileStream
               (filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, file);
                doc.Open();
                doc.Add(jpg);
                doc.Add(new Paragraph(encab));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Bitacora de seguridad"));
                doc.Add(new Paragraph(" "));
                GenerarDocumento(doc);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("**FIN DEL REPORTE**"));
                Process.Start(filename);
                doc.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GenerarDocumento(Document document)
        {
            PdfPTable datatable = new PdfPTable(dtgBitacoras.ColumnCount);
            datatable.DefaultCell.Padding = 5;
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;

            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);

            DataGridViewCellStyle style = this.dtgBitacoras.ColumnHeadersDefaultCellStyle;

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (int i = 0; i < dtgBitacoras.ColumnCount; i++)
            {

                objP = new Phrase(dtgBitacoras.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);
            }
            datatable.HeaderRows = 1;

            datatable.DefaultCell.BorderColor = BaseColor.WHITE;
            datatable.DefaultCell.BorderWidth = 1;



            for (int i = 0; i < dtgBitacoras.RowCount; i++)
            {
                for (int j = 0; j < dtgBitacoras.ColumnCount; j++)
                {
                    objP = new Phrase(dtgBitacoras[j, i].Value.ToString(), fuente);

                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }

            document.Add(datatable);
        }
    }
}
