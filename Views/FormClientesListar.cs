using facturacion.Business;
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
    public partial class FormClientesListar : Form
    {
        public FormClientesListar()
        {
            InitializeComponent();
            Clientes clientes = new Clientes();
            MessageBox.Show(clientes.ListarClientes().Count().ToString());
        }

        private void ClienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
