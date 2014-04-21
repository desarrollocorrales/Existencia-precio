using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReporteExistenciaPrecio.Controladores;
using ReporteExistenciaPrecio.Modelos;
using DevExpress.XtraPrinting;

namespace ReporteExistenciaPrecio
{
    public partial class Frm_Principal : Form
    {
        public List<Almacen> lstAlmacenes;
        public List<FiltroGrupos> lstGrupos;
        private List<Reporte> dsReporte;
        private string AlmacenID;
        private string GruposIDs;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Imprimir");
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            PageHeaderArea headerArea;

            headerArea = new PageHeaderArea();
            headerArea.Content.Add("Reporte de precios y existencias al dia " + DateTime.Today.ToShortDateString());
            headerArea.LineAlignment = BrickAlignment.Center;

            PageFooterArea footerArea;
            PageHeaderFooter headerfooter;

            footerArea = new PageFooterArea();
            footerArea.Content.Add("[Page #]");
            footerArea.LineAlignment = BrickAlignment.Far;

            headerfooter = new PageHeaderFooter(headerArea, footerArea);
            link.PageHeaderFooter = headerfooter;

            link.Component = gridResultados;
            link.CreateDocument();
            link.ShowPreviewDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {                
                Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Application.DoEvents();

            cbAlmacenes.DataSource = lstAlmacenes;
            cbAlmacenes.DisplayMember = "NombreAlmacen";
            cbAlmacenes.ValueMember = "IdAlmacen";

            gridGrupos.DataSource = lstGrupos;
            gvGrupos.BestFitColumns();
        }

        private void Consultar()
        {            
            AlmacenID = Convert.ToString(cbAlmacenes.SelectedValue);
            GruposIDs = getGruposSeleccionados();

            pbLoading.Visible = true;
            lblLoading.Visible = true;
            btnConsultar.Enabled = false;
            hiloConsulta.RunWorkerAsync();
        }

        private string getGruposSeleccionados()
        {
            List<FiltroGrupos> lstGruposSeleccionados =
                ((List<FiltroGrupos>)gridGrupos.DataSource)
                .FindAll(o=>o.Seleccion==true)
                .ToList();

            StringBuilder sGrupos = new StringBuilder();            
            foreach (FiltroGrupos grupo in lstGruposSeleccionados)
            {
                sGrupos.Append(string.Format("{0}, ", grupo.IdGrupo));
            }
            sGrupos.Append("0");

            return sGrupos.ToString();
        }

        private void hiloConsulta_DoWork(object sender, DoWorkEventArgs e)
        {
            Firebird_Controller fbController = new Firebird_Controller();
            dsReporte = fbController.getPreciosExistencias(AlmacenID, GruposIDs);
        }

        private void hiloConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridResultados.DataSource = dsReporte;
            gvResultados.BestFitColumns();
            tbcReporte.SelectedIndex = 1;

            pbLoading.Visible = false;
            lblLoading.Visible = false;
            btnConsultar.Enabled = true;
        }
    }
}
