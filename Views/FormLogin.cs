using facturacion.Business;
using facturacion.Classes;
using Microsoft.Win32;
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
    /// <summary>
    /// Formulario de Login
    /// </summary>
    public partial class FormLogin : Form
    {
        NLog.Logger log;

        /// <summary>
        /// Constructor del formulario de login.
        /// </summary>
        public FormLogin()
        {            
            InitializeComponent();
        }


        /// <summary>
        /// Método que se ejecuta en la carga del formulario de login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            log = Log.NuevoLog();
            log.Debug("El formulario de login se ha cargado correctamente.");

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ProyectoFactuacion\Login");
            try
            {
                if (key.GetValue("User").ToString().Length > 1 && key.GetValue("Password").ToString().Length > 1)
                {
                    tUsuario.Text = Encrypt.DesencriptaBase64(key.GetValue("User").ToString());
                    tPassword.Text = Encrypt.DesencriptaBase64(key.GetValue("Password").ToString());
                    if (key.GetValue("SaveLogin").ToString().Equals("1"))
                        cbRecordar.Checked = true;
                }
            }
            catch(NullReferenceException ex)
            {
                log.Debug("No existen datos de login guardados.",ex);
            }

        }


        /// <summary>
        /// Acción que se ejecjutará al hacer presionar el botón Aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accionAceptar(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            if (cbRecordar.Checked)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ProyectoFactuacion\Login");
                key.SetValue("User", Encrypt.EncriptaBase64(tUsuario.Text));
                key.SetValue("Password", Encrypt.EncriptaBase64(tPassword.Text));
                key.SetValue("SaveLogin", 1);
                
                key.Close();

                log.Info("Se ha actualizado la información del usuario en el registro");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ProyectoFactuacion\Login");
                key.SetValue("User", "");
                key.SetValue("Password", "");
                key.SetValue("SaveLogin", 0);
                key.Close();

                log.Info("Se ha eliminado la información del usuario del registro.");
            }

            if(String.IsNullOrEmpty(tUsuario.Text)|| String.IsNullOrEmpty(tPassword.Text))
            {
                log.Info("El usuario ha intentado realizar login sin introducir los valores usuario o contraseña." +
                    " Usuario: {} Password: {}", tUsuario.Text, tPassword.Text);
                MessageBox.Show("El usuario o contraseña no pueden contener campos vacios",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (emp.LoginCorrecto(tUsuario.Text, tPassword.Text))
            {
                VariablesGlobales.usuarioActivo = emp.GetEmpleado(tUsuario.Text);
                FormularioPrincipal form = new FormularioPrincipal();
                form.Show();
                log.Debug("El login se ha realizado correctamente y procederá a ocultarse");
                this.Hide();                
            }
            else
            {
                MessageBox.Show("El usuario o contraseña que ha facilitado son incorrectos");
            }

        }


        /// <summary>
        /// Acción que se ejecutará al presionar el botón cancelar. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BCancelar_Click(object sender, EventArgs e)
        {
            log.Info("Se ha presionado el botón cancelar del formulario de login," +
                " la aplicación procederá a su cierre");
            MessageBox.Show("La entrada de usuario es obligatoria, el programa procederá a su cierre", 
                "Alerta de cierre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Application.Exit();
        }

    }
}
