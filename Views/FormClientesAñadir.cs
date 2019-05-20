using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using facturacion.Model;
using facturacion.Business;

namespace facturacion.Views
{
    public partial class FormClientesAñadir : Form
    {
        
        public FormClientesAñadir()
        {
            /*cTipoCliente.DataSource = Clientes.getTipos();
            cTipoCliente.ValueMember = "Tipo_Cliente_ID";
            cTipoCliente.DisplayMember = "Denominacion";*/
            InitializeComponent();
        }

        /*public void accionAñadirCliente(object sender)
        {
            Cliente c1 = new Cliente();
            c1.Nombre = tNombre.Text;
            c1.Apellidos = $"{tApellido1.Text} {tApellido2.Text}";
            c1.CIF = tCif.Text;
            c1.NombreFiscal = tNombreFiscal.Text;
            //c1.TipoCliente = Clientes.getTipoCliente(int.Parse(cTipoCliente.Text));

            accionAñadirCliente(c1);

        }*/

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtAñadirCliente_Click(object sender, EventArgs e)
        {
            Cliente c1 = new Cliente();
            c1.Nombre = tNombre.Text;
            c1.Apellidos = $"{tApellido1.Text} {tApellido2.Text}";
            c1.CIF = tCif.Text;
            c1.NombreFiscal = tNombreFiscal.Text;
            //c1.TipoCliente = Clientes.getTipoCliente(int.Parse(cTipoCliente.Text));


            Clientes.nuevoCliente(c1);
        }
    }
}
