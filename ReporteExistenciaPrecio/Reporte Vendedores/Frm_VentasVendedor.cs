using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReporteExistenciaPrecio.Modelos.Reporte_Vendedores;
using ReporteExistenciaPrecio.Controladores;
using DevExpress.XtraPrinting;

namespace ReporteExistenciaPrecio.Reporte_Vendedores
{
    public partial class Frm_VentasVendedor : Form
    {
        public List<VendedoresGrid> lstVendedores;
        private List<ReporteVendedores> dsReporte;

        public Frm_VentasVendedor()
        {
            InitializeComponent();
        }

        private void Frm_VentasVendedor_Shown(object sender, EventArgs e)
        {
            gridVendedores.DataSource = lstVendedores;
            gvVendedores.BestFitColumns();
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

        private void Consultar()
        {
            panelLoading.Visible= true;
            btnConsultar.Enabled = false;
            hiloConsulta.RunWorkerAsync();
        }

        private void hiloConsulta_DoWork(object sender, DoWorkEventArgs e)
        {
            Firebird_Controller fbController = new Firebird_Controller();
            string VendedoresIDs = getVendedoresSeleccionados();
            dsReporte = fbController.getReporteVendedores(dtpInicial.Value, dtpFinal.Value, VendedoresIDs);            
        }

        private void hiloConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridReporteVendedores.DataSource = dsReporte;
            gvReporteVendedores.BestFitColumns();
            tabControlVendores.SelectedIndex = 1;

            panelLoading.Visible = false;
            btnConsultar.Enabled = true;
        }

        private string getVendedoresSeleccionados()
        {
            List<VendedoresGrid> lstVendedoresSeleccionados =
                ((List<VendedoresGrid>)gridVendedores.DataSource)
                .FindAll(o => o.Seleccionado == true)
                .ToList();

            StringBuilder sVendedores = new StringBuilder();
            foreach (VendedoresGrid Vendedor in lstVendedoresSeleccionados)
            {
                sVendedores.Append(string.Format("{0}, ", Vendedor.ID_Vendedor));
            }
            sVendedores.Append("0");

            return sVendedores.ToString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void Imprimir()
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            PageHeaderArea headerArea;

            headerArea = new PageHeaderArea();
            headerArea.Content.Add("REPORTE DE VENTAS POR VENDEDOR");
            headerArea.Content.Add(string.Empty);
            headerArea.Content.Add("DE " + dtpInicial.Value.ToString("dd-MMMM-yyyy").ToUpper() + 
                                   " A " +   dtpFinal.Value.ToString("dd-MMMM-yyyy").ToUpper());
            headerArea.LineAlignment = BrickAlignment.Center;

            PageFooterArea footerArea;
            PageHeaderFooter headerfooter;

            footerArea = new PageFooterArea();
            footerArea.Content.Add("[Page #]");
            footerArea.LineAlignment = BrickAlignment.Far;

            headerfooter = new PageHeaderFooter(headerArea, footerArea);
            link.PageHeaderFooter = headerfooter;

            link.Component = gridReporteVendedores;
            link.Landscape = true;
            link.Margins = new System.Drawing.Printing.Margins(58, 58, 58, 58);
            link.CreateDocument();
            link.ShowPreviewDialog();
        }

        private void gvReporteVendedores_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }
    }
}
