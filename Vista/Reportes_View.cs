using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseSystemFood.Controlador;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Vista
{
    public partial class Reportes_View : Form
    {

        private Reportes reportes;
        private ReportesHelper reportesH;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;
        private DataTable datos;
        private DataTable datosAcum;
        public int UserId;

       
        public Reportes_View()
        {
            InitializeComponent();
        }
        public Reportes_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            generarData();
        }

        public void generarData()
        {
            try
            {
                dtgReportes.DataSource = null;
                //selecciono tipo cierre
                int tipo = ObtenerTipoReporte();
               
                //selecciono tipo moneda
                int moneda = ObtenerTipoMoneda();
               
                reportes = new Reportes();

                reportes.Opc = tipo;
                reportes.FechaInicial = this.dtpInicio.Value;
                reportes.FechaFinal = this.dtpHasta.Value;
                reportes.Moneda = moneda;
                reportesH = new ReportesHelper(reportes);
                datos = reportesH.Buscar();

                if (datos.Rows.Count > 0)
                {
                    dtgReportes.DataSource = datos;                                
                }
                else{
                    MessageBox.Show("No hay datos por generar","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                this.lbCantidad.Text = datos.Rows.Count.ToString();
                //OBTENGO EL ACUMULADO DEL REPORTE SUMANDO LA COLLUMNA MONTO
                datosAcum = reportesH.calcularAcumulado(tipo);
                string Acum = "";
                //VALIDO SI ES DOLAR O COLON PARA CAMBIAR EL LENGHT SI ES MUY GRANDE
                if (moneda.Equals(2) && Acum.Length > 4)
                {
                   Acum = datosAcum.Rows[0][0].ToString();
                   this.lbAcum.Text = Acum.Substring(0, 4);
                }
                else
                {
                    this.lbAcum.Text = datosAcum.Rows[0][0].ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int ObtenerTipoReporte()
        {
            int tipo = 0;
            try
            {
                foreach (RadioButton radio in gbox3.Controls)
                {
                    if (radio.Checked)
                    {
                        this.lbReporte.Text = "Reporte de " + radio.Text;
                        switch (radio.Text)
                        {
                            case "Gastos": tipo = 1; break;
                            case "Ventas": tipo = 2; break;
                            case "Cierres": tipo = 3; break;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tipo;
        }

        public int ObtenerTipoMoneda()
        {
            int moneda = 0;
            try
            {
                foreach (RadioButton radio in gboxM.Controls)
                {
                    if (radio.Checked)
                    {
                        this.lbMoneda.Text = "en " + radio.Text;
                        switch (radio.Text)
                        {
                            case "Colones":
                                moneda = 1;
                                this.lbSimbol.Text = "₡";
                                break;
                            case "Dolares":
                                moneda = 2;
                                this.lbSimbol.Text = "$";
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return moneda;
        }

        public void GenerarReporte()
        {
           
            string inicio = this.dtpInicio.Value.ToString("dd-MM-yyyy");
            string fin = this.dtpHasta.Value.ToString("dd-MM-yyyy");
            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            BaseColor colorf = new BaseColor(51, 204, 0);
            Font fuente = new Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);
            Image jpg = Image.GetInstance(@"C:\Users\cca\Documents\..Universidad\..PROYECTO_PROFESIONAL\HouseSystemFood\Vista\img\logo_rest.jpg"); jpg.Alignment = Image.RIGHT_ALIGN;
            string filename = "C:\\Reportes\\"+this.lbReporte.Text+" "+this.lbMoneda.Text+inicio+" al "+fin+".pdf";
            Chunk encab = new Chunk(" HOUSE RESTAURANT FOOD ", FontFactory.GetFont("ARIAL", 15, colorf));
            Chunk acumulado = new Chunk("Acumulado: " + this.lbSimbol.Text+ this.lbAcum.Text, FontFactory.GetFont("ARIAL", 20));
            Chunk cantidad = new Chunk("Cantidad : " + this.lbCantidad.Text, FontFactory.GetFont("ARIAL", 20));
            string Titulo = this.lbReporte.Text + " " + this.lbMoneda.Text + " " + inicio  +" al "+ fin;
            
            try
            {

                FileStream file = new FileStream
               (filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, file);              
                doc.Open();
                doc.Add(jpg);
                doc.Add(new Paragraph(encab));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(Titulo));
                doc.Add(new Paragraph(" "));
                GenerarDocumento(doc);             
                doc.Add(new Paragraph(cantidad));
                doc.Add(new Paragraph(acumulado));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("**FIN DEL REPORTE**"));
                Process.Start(filename);
                doc.Close();

                RegistarEnBitacora("REPORTE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GenerarDocumento(Document document)
        {
            PdfPTable datatable = new PdfPTable(dtgReportes.ColumnCount);
            datatable.DefaultCell.Padding = 5;      
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;

            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);

            DataGridViewCellStyle style = this.dtgReportes.ColumnHeadersDefaultCellStyle;

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (int i = 0; i < dtgReportes.ColumnCount; i++)
            {

                objP = new Phrase(dtgReportes.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);
            }
            datatable.HeaderRows = 1;

            datatable.DefaultCell.BorderColor = BaseColor.WHITE;
            datatable.DefaultCell.BorderWidth = 1;



            for (int i = 0; i < dtgReportes.RowCount; i++)
            {
                for (int j = 0; j < dtgReportes.ColumnCount; j++)
                {
                    objP = new Phrase(dtgReportes[j, i].Value.ToString(), fuente);

                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }

            document.Add(datatable);
        }
      
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
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
                bitacoras.Tabla = "REPORTES";
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
