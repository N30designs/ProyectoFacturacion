using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacion.Views
{
    public partial class FormularioPrincipal : Form
    {
        int resX = 1024;
        int resY = 768;

        public int ResX { get => resX; set => resX = value; }
        public int ResY { get => resY; set => resY = value; }

        public FormularioPrincipal()
        {
            resX = Screen.PrimaryScreen.WorkingArea.Width;
            resY = Screen.PrimaryScreen.WorkingArea.Height;
            IsMdiContainer = true;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void AccionSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccionAñadirClientes(object sender, EventArgs e)
        {
            FormClientesAñadir form = new FormClientesAñadir()
            {
                MdiParent = this
            };

            form.Show();
        }
    }
}
