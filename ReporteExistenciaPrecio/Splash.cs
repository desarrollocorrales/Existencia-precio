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

namespace ReporteExistenciaPrecio
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            
            CargarConfiguraciones();


            this.Hide();
            Frm_Principal frmPrincipal = new Frm_Principal();
            frmPrincipal.lstAlmacenes = getAlmacenes();
            frmPrincipal.lstGrupos = getGrupos();

            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void CargarConfiguraciones()
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
                    Mensaje.AppendLine(Environment.CurrentDirectory);
                    MessageBox.Show(Mensaje.ToString());
                    Application.Exit();
                    return;
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
            }
            catch (Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine("Ocurrio un error al cargar los archivos de configuración.");
                sbMensaje.Append(string.Format("Exception: {0}", ex.Message));

                MessageBox.Show(sbMensaje.ToString());

                Application.Exit();
            }
        }

        private List<Almacen> getAlmacenes()
        {
            lblAccion.Text = "Obteniendo almacenes...";
            Application.DoEvents();

            List<Almacen> lstAlmacenes = new List<Almacen>();
            Firebird_Controller fbController = new Firebird_Controller();

            lstAlmacenes = fbController.getAlmacenes();
            return lstAlmacenes;
        }

        private List<FiltroGrupos> getGrupos()
        {
            lblAccion.Text = "Obteniendo grupos de lineas...";
            Application.DoEvents();

            List<FiltroGrupos> lstGrupos= new List<FiltroGrupos>();
            Firebird_Controller fbController = new Firebird_Controller();

            lstGrupos = fbController.getGrupos();
            return lstGrupos;
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
