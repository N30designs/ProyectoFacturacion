using facturacion.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacion.Views
{
    /// <summary>
    /// Código del formulario principal que será el contenedor del resto. 
    /// </summary>
    public partial class FormularioPrincipal : Form
    {
        int resX = 1024;
        int resY = 768;

        public int ResX { get => resX; set => resX = value; }
        public int ResY { get => resY; set => resY = value; }

        /// <summary>
        /// Constructor del formulario, obtiene los valores iniciales y escribie la entrada en el registro.
        /// </summary>
        public FormularioPrincipal()
        {
            resX = Screen.PrimaryScreen.WorkingArea.Width;
            resY = Screen.PrimaryScreen.WorkingArea.Height;
            Logger logger = new Logger();
            logger.Log("Inicio Aplicación", 0, $"El equipo {Environment.MachineName}" +
                $" ({Environment.UserName}) con dirección ip: " +
                $"{Dns.GetHostAddresses(Environment.MachineName).Where(i=> i.IsIPv6LinkLocal == false && i.IsIPv6Multicast == false && i.IsIPv6SiteLocal == false).FirstOrDefault().ToString()}" +
                $" y MAC: {NetworkInterface.GetAllNetworkInterfaces().Where(n=> n.OperationalStatus == OperationalStatus.Up && n.NetworkInterfaceType != NetworkInterfaceType.Loopback).FirstOrDefault().GetPhysicalAddress()} ");
            IsMdiContainer = true;
            

            InitializeComponent();
        }
       
        /// <summary>
        /// Ejecuta la salida normal del programa. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccionSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Abre el formulario "FormClientesAñadir"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccionAñadirClientes(object sender, EventArgs e)
        {
            FormClientesAñadir form = new FormClientesAñadir()
            {
                MdiParent = this
            };

            form.Show();
        }


        /// <summary>
        /// Abre el formulario "FormClientesListar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccionListarClientes(object sender, EventArgs e)
        {
            FormClientesListar form = new FormClientesListar()
            {
                MdiParent = this
            };

            form.Show();
        }


        /// <summary>
        /// Ejecuta el formulario "FormPreferencias"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccionPreferencias(object sender, EventArgs e)
        {
            FormPreferencias form = new FormPreferencias()
            {
                MdiParent = this
            };

            form.Show();
        }
    }
}
