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
using facturacion.Classes;

namespace facturacion.Views
{
    public partial class FormularioPreferencias : Form
    {
        public FormularioPreferencias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Guardará los cambios realizados en las preferencias en el registro de windows. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accionGuardar(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ProyectoFactuacion\Preferencias");
                key.SetValue("DBServer", tServidor.Text);
                key.SetValue("DBDatabase", tBaseDatos.Text);
                key.SetValue("DBUser", tUsuario.Text);
                key.SetValue("DBPassword", Encrypt.EncriptaBase64(tContraseña.Text));
                if(cBaseDatosLocal.Checked)
                    key.SetValue("DBLocal", 1);
                else
                    key.SetValue("DBLocal", 0);


                if (cSeguridadIntegrada.Checked)
                    key.SetValue("DBSeguridadIntegrada", 1);
                else
                    key.SetValue("DBSeguridadIntegrada", 0);
                key.Close();

                MessageBox.Show("La información ha sido guardada correctamente");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void accionLoad(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ProyectoFactuacion\Preferencias");

            if (key != null)
            {
                tServidor.Text = key.GetValue("DBServer").ToString();
                tBaseDatos.Text = key.GetValue("DBDatabase").ToString();
                tUsuario.Text = key.GetValue("DBUser").ToString();
                tContraseña.Text = Encrypt.DesencriptaBase64(key.GetValue("DBPassword").ToString());
            }

        }
    }
}
