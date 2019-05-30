using facturacion.Business;
using facturacion.Classes;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            if (emp.LoginCorrecto(tUsuario.Text, tPassword.Text))
            {
                VariablesGlobales.usuarioActivo = emp.GetEmpleado(tUsuario.Text);
                FormularioPrincipal form = new FormularioPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña que ha facilitado son incorrectos");
            }

        }
    }
}
