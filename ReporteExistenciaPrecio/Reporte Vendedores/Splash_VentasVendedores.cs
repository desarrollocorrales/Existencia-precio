using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccSettings;
using Sofbr;
using ReporteExistenciaPrecio.Controladores;
using ReporteExistenciaPrecio.Modelos;
using ReporteExistenciaPrecio.Modelos.Reporte_Vendedores;

namespace ReporteExistenciaPrecio.Reporte_Vendedores
{
    public partial class Splash_VentasVendedores : Form
    {
        public Splash_VentasVendedores()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            if (CargarConfiguraciones() == true)
            {
                this.Hide();
                Frm_VentasVendedor frmVentasVendedores = new Frm_VentasVendedor();
                frmVentasVendedores.WindowState = FormWindowState.Maximized;
                frmVentasVendedores.lstVendedores = getVendedores();
                frmVentasVendedores.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private bool CargarConfiguraciones()
        {
            //Obtener la ruta del archivo de configuraciones de Microsip y la SettingsKey*
            lblAccion.Text = "Buscando el archivo Microsip.set...";
            Application.DoEvents();

            MicroSipSettings MicrosipSettings = new MicroSipSettings();
            MicrosipSettings.FileName = Environment.CurrentDirectory + "\\conf\\microsip.set";
            MicrosipSettings.Key = "C0RR4L35";

            try
            {
                bool ExisteMicrosipSettings = System.IO.File.Exists(MicrosipSettings.FileName);

                if (ExisteMicrosipSettings == false)
                {
                    StringBuilder Mensaje = new StringBuilder();
                    Mensaje.AppendLine("No se encontró el archivo de configuración.");
                    Mensaje.AppendLine("Por favor, ejecute el modulo AdminACC, genere el archivo \"microsip.set\" y peguelo en la ruta:");
                    Mensaje.AppendLine(Environment.CurrentDirectory+"\\conf\\");
                    MessageBox.Show(Mensaje.ToString());
                    return false;
                }

                lblAccion.Text = "Descifrando el archivo Microsip.set...";
                Application.DoEvents();

                MicrosipSettings = MicrosipSettings.Deserialize<MicroSipSettings>(true);

                lblAccion.Text = "Cargando Configuraciones...";
                Application.DoEvents();
                Microsip.Servidor = MicrosipSettings.Conexiones[0].Host;
                Microsip.Usuario = MicrosipSettings.Conexiones[0].Usuario;
                Microsip.Contraseña = MicrosipSettings.Conexiones[0].PassWord;
                Microsip.Puerto = MicrosipSettings.Conexiones[0].Puerto;
                return true;
            }
            catch (Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine("Ocurrio un error al cargar los archivos de configuración.");
                sbMensaje.Append(string.Format("Exception: {0}", ex.Message));

                MessageBox.Show(sbMensaje.ToString());
                return false;
            }
        }

        public List<VendedoresGrid> getVendedores()
        {
            List<VendedoresGrid> lstVendedores = new List<VendedoresGrid>();
            Firebird_Controller fbController = new Firebird_Controller();
            lstVendedores = fbController.getVendedores();
            return lstVendedores;
        }
    }
}
