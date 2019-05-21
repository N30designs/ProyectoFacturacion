using System;
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
            //c1.TipoCliente <- Primero debemos rellenarlo, lo desactivo para probar
            c1.CIF = tCif.Text;
            c1.NombreFiscal = tNombreFiscal.Text;
            if (tDireccion.TextLength > 1)
                c1.Domicilio = tDireccion.Text;
            if (tNumero.TextLength > 1)
                c1.Numero = int.Parse(tNumero.Text);
            if (tBloque.TextLength > 1)
                c1.Bloque = int.Parse(tBloque.Text);
            if (tEscalera.TextLength > 1)
                c1.Escalera = int.Parse(tEscalera.Text);
            if (tPortal.TextLength > 1)
                c1.Portal = int.Parse(tPortal.Text);
            if (tPlanta.TextLength > 1)
                c1.Planta = int.Parse(tPlanta.Text);
            if (tPuerta.TextLength > 1)
                c1.Puerta = tPuerta.Text;
            //AQUIVAPBLOACION PEROLO DEJO PARA DESPUES
            if (tWeb.TextLength > 1)
                c1.Web = tWeb.Text;
            if (tTelefono1.TextLength > 1)
                c1.Telefono1 = tTelefono1.Text;
            if (tTelefono2.TextLength > 1)
                c1.Telefono2 = tTelefono2.Text;
            if (tFax.TextLength > 1)
                c1.Fax = tFax.Text;

            if (tDescuento.TextLength > 1)
                c1.Descuento = int.Parse(tDescuento.Text);
            if (tDiasPago.TextLength > 1)
                c1.DiasPago = int.Parse(tDiasPago.Text);
            if (tIban.TextLength > 1)
                c1.Iban = tIban.Text;
            if (tBic.TextLength > 1)
                c1.Bic = tBic.Text;
            if (tIrpf.TextLength > 1)
                c1.Irpf = int.Parse(tIrpf.Text);
               
            Clientes.NuevoCliente(c1);
        }
    }
}
