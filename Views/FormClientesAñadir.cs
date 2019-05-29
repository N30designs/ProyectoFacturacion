using System;
using System.Windows.Forms;
using facturacion.Model;
using facturacion.Business;
using facturacion.Data;


namespace facturacion.Views
{
    /// <summary>
    /// Formulario de creación de clientes
    /// </summary>
    public partial class FormClientesAñadir : Form
    {
        bool poblacionNueva = false;
        Clientes clientes = new Clientes();
        Poblaciones poblaciones = new Poblaciones();
        NLog.Logger log;
        FacturacionContext context = new FacturacionContext();

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public FormClientesAñadir()
        {
            InitializeComponent();
            log = NLog.LogManager.GetCurrentClassLogger();
            log.Debug("Iniciado nuevo formulario FormClientesAñadir");
        }

        /// <summary>
        /// Añade un cliente a la base de datos, en caso de que se haya introducido un
        /// valor nuevo en Población, en lugar de añadir, se pedirá que vuelva a seleccionar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accionAñadirCliente(object sender, EventArgs e)
        {
            Poblaciones poblaciones = new Poblaciones();
            Cliente c1 = new Cliente();

            //Evaluaremos que la población no sea nueva y que los campos no esten vacios. 
            if(!poblacionNueva)
            {
                if((String.IsNullOrEmpty(TPostal.Text)) || cPoblacion.SelectedIndex == -1 || cTipoPoblacion.SelectedIndex == -1 || cProvincia.SelectedIndex == -1)
                {
                    MessageBox.Show("Todos los datos de la población deben ser completados.");
                }
                else
                {
                    try
                    {
                        c1.Nombre = tNombre.Text;
                        c1.Apellidos = $"{tApellido1.Text} {tApellido2.Text}";
                        c1.TipoCliente = clientes.TipoClienteID(int.Parse(cTipoCliente.SelectedValue.ToString()));
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

                        c1.Poblacion = poblaciones.BuscarID(int.Parse(cPoblacion.SelectedValue.ToString()));

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

                        clientes.NuevoCliente(c1);

                        MessageBox.Show("El cliente se ha guardado correctamente.");

                        resetCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
                
            }
            else
            {
                poblaciones.AddPoblacion(cPoblacion.Text, tipoPoblacion.Ciudad, TPostal.Text, int.Parse(cProvincia.SelectedValue.ToString()));
                TPostal.Clear();
                cTipoPoblacion.SelectedIndex = -1;
                cTipoPoblacion.Enabled = false;
                cPoblacion.DataSource = null;
                cPoblacion.Items.Clear();
                cPoblacion.Enabled = false;
                cProvincia.SelectedIndex = -1;
                cProvincia.Enabled = false;
                MessageBox.Show("Se ha creado la nueva población, por favor antes de guardar seleccione la nueva población.");
                poblacionNueva = false;

            }
        }


        /// <summary>
        /// Rellena el campo cPoblación y cProvincia al introducir un código postal.
        /// En caso de que el campo no exista abrirá los campos para permitir introducir
        /// un nueva población.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void editarCPostal(object sender, EventArgs e)
        {
            if(TPostal.TextLength != 0)
            {
                var p = new Poblaciones();
                var poblacion = p.Buscar(TPostal.Text);
                cPoblacion.DataSource = poblacion;
                cPoblacion.ValueMember = "Poblacion_ID";
                cPoblacion.DisplayMember = "Nombre";
                cPoblacion.Enabled = true;

                if (poblacion.Count > 1)
                {
                    cPoblacion.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else if (poblacion.Count == 1)
                {
                    cTipoPoblacion.Enabled = true;
                    cTipoPoblacion.SelectedItem = poblaciones.TipoPoblacion(int.Parse(cPoblacion.SelectedValue.ToString()));
                    cProvincia.SelectedValue = poblaciones.ProvinciaOfPoblacion(int.Parse(cPoblacion.SelectedValue.ToString()));
                }
                else
                {

                    DialogResult dr = MessageBox.Show("No se ha encontrado ninguna población con ese código postal" +
                                    " ¿Desea crear una nueva", "¡Atención!", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        cPoblacion.Enabled = true;
                        cProvincia.Enabled = true;
                        cTipoPoblacion.Enabled = true;
                        poblacionNueva = true;
                    }
                    else
                    {
                        TPostal.Clear();
                        MessageBox.Show("Por favor vuelva a introducir el código postal correcto");
                    }
                }
            }
            
        }

        /// <summary>
        /// Selecciona la provincia corrspondiente en base al valor del campo población.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void seleccionaTipoyProvincia(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cPoblacion.SelectedValue.ToString()))
            {
                cTipoPoblacion.Enabled = true;
                cTipoPoblacion.SelectedItem = poblaciones.TipoPoblacion(int.Parse(cPoblacion.SelectedValue.ToString()));
                cProvincia.SelectedValue = poblaciones.ProvinciaOfPoblacion(int.Parse(cPoblacion.SelectedValue.ToString()));
            }
        }

        /// <summary>
        /// Método que se ejecutará en la carga del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void inicializar(object sender, EventArgs e)
        {
            //Obtenemos valores de tipo de clientes
            var tClientes = clientes.Tipos();
            cTipoCliente.DataSource = tClientes;
            cTipoCliente.ValueMember = "Tipo_Cliente_ID";
            cTipoCliente.DisplayMember = "Denominacion";

            //Enlazo enum a combobox
            cTipoPoblacion.DataSource = Enum.GetValues(typeof(tipoPoblacion));
            cTipoPoblacion.SelectedIndex = -1;

            //Obtenemos provincias y las asignamos al combobox cProvincia
            var provincias = poblaciones.Provincias();
            cProvincia.DataSource = provincias;
            cProvincia.ValueMember = "Poblacion_ID";
            cProvincia.DisplayMember = "Nombre";
            cProvincia.SelectedIndex = -1;
            
        }


        /// <summary>
        /// Método para resetear el valor del formulario
        /// </summary>
        public void resetCampos()
        {
            tNombre.Clear();
            tApellido1.Clear();
            tApellido2.Clear();
            cTipoCliente.SelectedIndex = -1;
            tCif.Clear();
            tNombreFiscal.Clear();
            tDireccion.Clear();
            tNumero.Clear();
            tBloque.Clear();
            tEscalera.Clear();
            tPortal.Clear();
            tPlanta.Clear();
            tPuerta.Clear();
            if (cPoblacion.DropDownStyle == ComboBoxStyle.DropDownList)
                cPoblacion.DropDownStyle = ComboBoxStyle.DropDown;
            cPoblacion.DataSource = null;
            cPoblacion.Items.Clear();
            cTipoPoblacion.SelectedIndex = -1;
            TPostal.Clear();
            cProvincia.SelectedIndex = -1;
            tWeb.Clear();
            tContacto.Clear();
            tTelefono1.Clear();
            tTelefono2.Clear();
            tFax.Clear();
            tDescuento.Clear();
            tDiasPago.Clear();
            tIban.Clear();
            tBic.Clear();
            tIrpf.Clear();
            tObservaciones.Clear();
        }

        /// <summary>
        /// Ejecuta la acción resetCampos (borra el valor de todo el formulario)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCancelar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }
    }
}
