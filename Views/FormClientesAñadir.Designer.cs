namespace facturacion.Views
{
    partial class FormClientesAñadir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gNombre = new System.Windows.Forms.GroupBox();
            this.cTipoCliente = new System.Windows.Forms.ComboBox();
            this.lNombreFiscal = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lCif = new System.Windows.Forms.Label();
            this.lTipoCliente = new System.Windows.Forms.Label();
            this.lApellido2 = new System.Windows.Forms.Label();
            this.tApellido2 = new System.Windows.Forms.TextBox();
            this.tNombreFiscal = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tCif = new System.Windows.Forms.TextBox();
            this.tApellido1 = new System.Windows.Forms.TextBox();
            this.lApellido1 = new System.Windows.Forms.Label();
            this.gDireccion = new System.Windows.Forms.GroupBox();
            this.cProvincia = new System.Windows.Forms.ComboBox();
            this.cTipoPoblacion = new System.Windows.Forms.ComboBox();
            this.cPoblacion = new System.Windows.Forms.ComboBox();
            this.lFax = new System.Windows.Forms.Label();
            this.lTelefono2 = new System.Windows.Forms.Label();
            this.lTelefono1 = new System.Windows.Forms.Label();
            this.lWeb = new System.Windows.Forms.Label();
            this.lContacto = new System.Windows.Forms.Label();
            this.lProvincia = new System.Windows.Forms.Label();
            this.lTipoPoblacion = new System.Windows.Forms.Label();
            this.lPostal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.tPuerta = new System.Windows.Forms.TextBox();
            this.lPuerta = new System.Windows.Forms.Label();
            this.tFax = new System.Windows.Forms.TextBox();
            this.tTelefono2 = new System.Windows.Forms.TextBox();
            this.tTelefono1 = new System.Windows.Forms.TextBox();
            this.tWeb = new System.Windows.Forms.TextBox();
            this.tContacto = new System.Windows.Forms.TextBox();
            this.TPostal = new System.Windows.Forms.TextBox();
            this.tPlanta = new System.Windows.Forms.TextBox();
            this.lPlanta = new System.Windows.Forms.Label();
            this.tPortal = new System.Windows.Forms.TextBox();
            this.lPortal = new System.Windows.Forms.Label();
            this.tEscalera = new System.Windows.Forms.TextBox();
            this.lEscalera = new System.Windows.Forms.Label();
            this.tBloque = new System.Windows.Forms.TextBox();
            this.lBloque = new System.Windows.Forms.Label();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.gOtros = new System.Windows.Forms.GroupBox();
            this.lIrpf = new System.Windows.Forms.Label();
            this.lBic = new System.Windows.Forms.Label();
            this.lObservaciones = new System.Windows.Forms.Label();
            this.lIban = new System.Windows.Forms.Label();
            this.lDiasPago = new System.Windows.Forms.Label();
            this.lDescuento = new System.Windows.Forms.Label();
            this.tIrpf = new System.Windows.Forms.TextBox();
            this.tBic = new System.Windows.Forms.TextBox();
            this.tObservaciones = new System.Windows.Forms.TextBox();
            this.tIban = new System.Windows.Forms.TextBox();
            this.tDiasPago = new System.Windows.Forms.TextBox();
            this.tDescuento = new System.Windows.Forms.TextBox();
            this.btAñadirCliente = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.flowLayoutPanel1.SuspendLayout();
            this.gNombre.SuspendLayout();
            this.gDireccion.SuspendLayout();
            this.gOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gNombre);
            this.flowLayoutPanel1.Controls.Add(this.gDireccion);
            this.flowLayoutPanel1.Controls.Add(this.gOtros);
            this.flowLayoutPanel1.Controls.Add(this.btAñadirCliente);
            this.flowLayoutPanel1.Controls.Add(this.btCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(983, 536);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gNombre
            // 
            this.gNombre.Controls.Add(this.cTipoCliente);
            this.gNombre.Controls.Add(this.lNombreFiscal);
            this.gNombre.Controls.Add(this.lNombre);
            this.gNombre.Controls.Add(this.lCif);
            this.gNombre.Controls.Add(this.lTipoCliente);
            this.gNombre.Controls.Add(this.lApellido2);
            this.gNombre.Controls.Add(this.tApellido2);
            this.gNombre.Controls.Add(this.tNombreFiscal);
            this.gNombre.Controls.Add(this.tNombre);
            this.gNombre.Controls.Add(this.tCif);
            this.gNombre.Controls.Add(this.tApellido1);
            this.gNombre.Controls.Add(this.lApellido1);
            this.gNombre.Location = new System.Drawing.Point(3, 3);
            this.gNombre.Name = "gNombre";
            this.gNombre.Size = new System.Drawing.Size(980, 104);
            this.gNombre.TabIndex = 1;
            this.gNombre.TabStop = false;
            this.gNombre.Text = "Nombre";
            // 
            // cTipoCliente
            // 
            this.cTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTipoCliente.FormattingEnabled = true;
            this.cTipoCliente.Location = new System.Drawing.Point(454, 36);
            this.cTipoCliente.Name = "cTipoCliente";
            this.cTipoCliente.Size = new System.Drawing.Size(206, 21);
            this.cTipoCliente.TabIndex = 4;
            // 
            // lNombreFiscal
            // 
            this.lNombreFiscal.AutoSize = true;
            this.lNombreFiscal.Location = new System.Drawing.Point(6, 63);
            this.lNombreFiscal.Name = "lNombreFiscal";
            this.lNombreFiscal.Size = new System.Drawing.Size(74, 13);
            this.lNombreFiscal.TabIndex = 0;
            this.lNombreFiscal.Text = "Nombre Fiscal";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(6, 16);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre";
            // 
            // lCif
            // 
            this.lCif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCif.AutoSize = true;
            this.lCif.Location = new System.Drawing.Point(827, 21);
            this.lCif.Name = "lCif";
            this.lCif.Size = new System.Drawing.Size(45, 13);
            this.lCif.TabIndex = 0;
            this.lCif.Text = "CIF/NIF";
            // 
            // lTipoCliente
            // 
            this.lTipoCliente.AutoSize = true;
            this.lTipoCliente.Location = new System.Drawing.Point(451, 16);
            this.lTipoCliente.Name = "lTipoCliente";
            this.lTipoCliente.Size = new System.Drawing.Size(78, 13);
            this.lTipoCliente.TabIndex = 0;
            this.lTipoCliente.Text = "Tipo de Cliente";
            // 
            // lApellido2
            // 
            this.lApellido2.AutoSize = true;
            this.lApellido2.Location = new System.Drawing.Point(297, 16);
            this.lApellido2.Name = "lApellido2";
            this.lApellido2.Size = new System.Drawing.Size(50, 13);
            this.lApellido2.TabIndex = 0;
            this.lApellido2.Text = "Apellido2";
            // 
            // tApellido2
            // 
            this.tApellido2.Location = new System.Drawing.Point(300, 37);
            this.tApellido2.MaxLength = 50;
            this.tApellido2.Name = "tApellido2";
            this.tApellido2.Size = new System.Drawing.Size(144, 20);
            this.tApellido2.TabIndex = 3;
            // 
            // tNombreFiscal
            // 
            this.tNombreFiscal.Location = new System.Drawing.Point(9, 84);
            this.tNombreFiscal.MaxLength = 100;
            this.tNombreFiscal.Name = "tNombreFiscal";
            this.tNombreFiscal.Size = new System.Drawing.Size(651, 20);
            this.tNombreFiscal.TabIndex = 6;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(9, 37);
            this.tNombre.MaxLength = 50;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(135, 20);
            this.tNombre.TabIndex = 1;
            // 
            // tCif
            // 
            this.tCif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tCif.Location = new System.Drawing.Point(830, 37);
            this.tCif.MaxLength = 10;
            this.tCif.Name = "tCif";
            this.tCif.Size = new System.Drawing.Size(138, 20);
            this.tCif.TabIndex = 5;
            // 
            // tApellido1
            // 
            this.tApellido1.Location = new System.Drawing.Point(150, 37);
            this.tApellido1.MaxLength = 50;
            this.tApellido1.Name = "tApellido1";
            this.tApellido1.Size = new System.Drawing.Size(144, 20);
            this.tApellido1.TabIndex = 2;
            // 
            // lApellido1
            // 
            this.lApellido1.AutoSize = true;
            this.lApellido1.Location = new System.Drawing.Point(147, 16);
            this.lApellido1.Name = "lApellido1";
            this.lApellido1.Size = new System.Drawing.Size(50, 13);
            this.lApellido1.TabIndex = 0;
            this.lApellido1.Text = "Apellido1";
            // 
            // gDireccion
            // 
            this.gDireccion.Controls.Add(this.cProvincia);
            this.gDireccion.Controls.Add(this.cTipoPoblacion);
            this.gDireccion.Controls.Add(this.cPoblacion);
            this.gDireccion.Controls.Add(this.lFax);
            this.gDireccion.Controls.Add(this.lTelefono2);
            this.gDireccion.Controls.Add(this.lTelefono1);
            this.gDireccion.Controls.Add(this.lWeb);
            this.gDireccion.Controls.Add(this.lContacto);
            this.gDireccion.Controls.Add(this.lProvincia);
            this.gDireccion.Controls.Add(this.lTipoPoblacion);
            this.gDireccion.Controls.Add(this.lPostal);
            this.gDireccion.Controls.Add(this.label2);
            this.gDireccion.Controls.Add(this.lDireccion);
            this.gDireccion.Controls.Add(this.tDireccion);
            this.gDireccion.Controls.Add(this.tPuerta);
            this.gDireccion.Controls.Add(this.lPuerta);
            this.gDireccion.Controls.Add(this.tFax);
            this.gDireccion.Controls.Add(this.tTelefono2);
            this.gDireccion.Controls.Add(this.tTelefono1);
            this.gDireccion.Controls.Add(this.tWeb);
            this.gDireccion.Controls.Add(this.tContacto);
            this.gDireccion.Controls.Add(this.TPostal);
            this.gDireccion.Controls.Add(this.tPlanta);
            this.gDireccion.Controls.Add(this.lPlanta);
            this.gDireccion.Controls.Add(this.tPortal);
            this.gDireccion.Controls.Add(this.lPortal);
            this.gDireccion.Controls.Add(this.tEscalera);
            this.gDireccion.Controls.Add(this.lEscalera);
            this.gDireccion.Controls.Add(this.tBloque);
            this.gDireccion.Controls.Add(this.lBloque);
            this.gDireccion.Controls.Add(this.tNumero);
            this.gDireccion.Controls.Add(this.lNumero);
            this.gDireccion.Location = new System.Drawing.Point(3, 113);
            this.gDireccion.Name = "gDireccion";
            this.gDireccion.Size = new System.Drawing.Size(974, 170);
            this.gDireccion.TabIndex = 1;
            this.gDireccion.TabStop = false;
            this.gDireccion.Text = "Domicilio";
            // 
            // cProvincia
            // 
            this.cProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cProvincia.Enabled = false;
            this.cProvincia.FormattingEnabled = true;
            this.cProvincia.Location = new System.Drawing.Point(539, 88);
            this.cProvincia.Name = "cProvincia";
            this.cProvincia.Size = new System.Drawing.Size(227, 21);
            this.cProvincia.TabIndex = 17;
            // 
            // cTipoPoblacion
            // 
            this.cTipoPoblacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTipoPoblacion.Enabled = false;
            this.cTipoPoblacion.FormattingEnabled = true;
            this.cTipoPoblacion.Location = new System.Drawing.Point(268, 88);
            this.cTipoPoblacion.Name = "cTipoPoblacion";
            this.cTipoPoblacion.Size = new System.Drawing.Size(121, 21);
            this.cTipoPoblacion.TabIndex = 16;
            // 
            // cPoblacion
            // 
            this.cPoblacion.Enabled = false;
            this.cPoblacion.FormattingEnabled = true;
            this.cPoblacion.Location = new System.Drawing.Point(9, 88);
            this.cPoblacion.Name = "cPoblacion";
            this.cPoblacion.Size = new System.Drawing.Size(253, 21);
            this.cPoblacion.TabIndex = 15;
            this.cPoblacion.SelectionChangeCommitted += new System.EventHandler(this.seleccionaTipoyProvincia);
            this.cPoblacion.TabIndexChanged += new System.EventHandler(this.seleccionaTipoyProvincia);
            // 
            // lFax
            // 
            this.lFax.AutoSize = true;
            this.lFax.Location = new System.Drawing.Point(827, 120);
            this.lFax.Name = "lFax";
            this.lFax.Size = new System.Drawing.Size(24, 13);
            this.lFax.TabIndex = 0;
            this.lFax.Text = "Fax";
            // 
            // lTelefono2
            // 
            this.lTelefono2.AutoSize = true;
            this.lTelefono2.Location = new System.Drawing.Point(827, 68);
            this.lTelefono2.Name = "lTelefono2";
            this.lTelefono2.Size = new System.Drawing.Size(55, 13);
            this.lTelefono2.TabIndex = 0;
            this.lTelefono2.Text = "Telefono2";
            // 
            // lTelefono1
            // 
            this.lTelefono1.AutoSize = true;
            this.lTelefono1.Location = new System.Drawing.Point(827, 16);
            this.lTelefono1.Name = "lTelefono1";
            this.lTelefono1.Size = new System.Drawing.Size(55, 13);
            this.lTelefono1.TabIndex = 0;
            this.lTelefono1.Text = "Telefono1";
            // 
            // lWeb
            // 
            this.lWeb.AutoSize = true;
            this.lWeb.Location = new System.Drawing.Point(6, 115);
            this.lWeb.Name = "lWeb";
            this.lWeb.Size = new System.Drawing.Size(56, 13);
            this.lWeb.TabIndex = 0;
            this.lWeb.Text = "Sitio Web:";
            // 
            // lContacto
            // 
            this.lContacto.AutoSize = true;
            this.lContacto.Location = new System.Drawing.Point(451, 115);
            this.lContacto.Name = "lContacto";
            this.lContacto.Size = new System.Drawing.Size(50, 13);
            this.lContacto.TabIndex = 0;
            this.lContacto.Text = "Contacto";
            // 
            // lProvincia
            // 
            this.lProvincia.AutoSize = true;
            this.lProvincia.Location = new System.Drawing.Point(536, 67);
            this.lProvincia.Name = "lProvincia";
            this.lProvincia.Size = new System.Drawing.Size(51, 13);
            this.lProvincia.TabIndex = 0;
            this.lProvincia.Text = "Provincia";
            // 
            // lTipoPoblacion
            // 
            this.lTipoPoblacion.AutoSize = true;
            this.lTipoPoblacion.Location = new System.Drawing.Point(265, 68);
            this.lTipoPoblacion.Name = "lTipoPoblacion";
            this.lTipoPoblacion.Size = new System.Drawing.Size(31, 13);
            this.lTipoPoblacion.TabIndex = 0;
            this.lTipoPoblacion.Text = "Tipo:";
            // 
            // lPostal
            // 
            this.lPostal.AutoSize = true;
            this.lPostal.Location = new System.Drawing.Point(392, 67);
            this.lPostal.Name = "lPostal";
            this.lPostal.Size = new System.Drawing.Size(72, 13);
            this.lPostal.TabIndex = 0;
            this.lPostal.Text = "Código Postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Población";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(6, 16);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(52, 13);
            this.lDireccion.TabIndex = 0;
            this.lDireccion.Text = "Dirección";
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(9, 37);
            this.tDireccion.MaxLength = 100;
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(435, 20);
            this.tDireccion.TabIndex = 0;
            // 
            // tPuerta
            // 
            this.tPuerta.Location = new System.Drawing.Point(719, 37);
            this.tPuerta.MaxLength = 10;
            this.tPuerta.Name = "tPuerta";
            this.tPuerta.Size = new System.Drawing.Size(47, 20);
            this.tPuerta.TabIndex = 6;
            // 
            // lPuerta
            // 
            this.lPuerta.AutoSize = true;
            this.lPuerta.Location = new System.Drawing.Point(716, 16);
            this.lPuerta.Name = "lPuerta";
            this.lPuerta.Size = new System.Drawing.Size(26, 13);
            this.lPuerta.TabIndex = 0;
            this.lPuerta.Text = "Pta.";
            // 
            // tFax
            // 
            this.tFax.Location = new System.Drawing.Point(830, 136);
            this.tFax.MaxLength = 20;
            this.tFax.Name = "tFax";
            this.tFax.Size = new System.Drawing.Size(138, 20);
            this.tFax.TabIndex = 14;
            // 
            // tTelefono2
            // 
            this.tTelefono2.Location = new System.Drawing.Point(830, 88);
            this.tTelefono2.MaxLength = 20;
            this.tTelefono2.Name = "tTelefono2";
            this.tTelefono2.Size = new System.Drawing.Size(138, 20);
            this.tTelefono2.TabIndex = 11;
            // 
            // tTelefono1
            // 
            this.tTelefono1.Location = new System.Drawing.Point(830, 37);
            this.tTelefono1.MaxLength = 20;
            this.tTelefono1.Name = "tTelefono1";
            this.tTelefono1.Size = new System.Drawing.Size(138, 20);
            this.tTelefono1.TabIndex = 7;
            // 
            // tWeb
            // 
            this.tWeb.Location = new System.Drawing.Point(9, 136);
            this.tWeb.Name = "tWeb";
            this.tWeb.Size = new System.Drawing.Size(435, 20);
            this.tWeb.TabIndex = 12;
            // 
            // tContacto
            // 
            this.tContacto.Location = new System.Drawing.Point(454, 136);
            this.tContacto.Name = "tContacto";
            this.tContacto.Size = new System.Drawing.Size(312, 20);
            this.tContacto.TabIndex = 13;
            // 
            // TPostal
            // 
            this.TPostal.Location = new System.Drawing.Point(395, 88);
            this.TPostal.Name = "TPostal";
            this.TPostal.Size = new System.Drawing.Size(135, 20);
            this.TPostal.TabIndex = 9;
            this.TPostal.Leave += new System.EventHandler(this.editarCPostal);
            // 
            // tPlanta
            // 
            this.tPlanta.Location = new System.Drawing.Point(666, 37);
            this.tPlanta.MaxLength = 2;
            this.tPlanta.Name = "tPlanta";
            this.tPlanta.Size = new System.Drawing.Size(47, 20);
            this.tPlanta.TabIndex = 5;
            // 
            // lPlanta
            // 
            this.lPlanta.AutoSize = true;
            this.lPlanta.Location = new System.Drawing.Point(663, 16);
            this.lPlanta.Name = "lPlanta";
            this.lPlanta.Size = new System.Drawing.Size(19, 13);
            this.lPlanta.TabIndex = 0;
            this.lPlanta.Text = "Pl.";
            // 
            // tPortal
            // 
            this.tPortal.Location = new System.Drawing.Point(613, 37);
            this.tPortal.MaxLength = 2;
            this.tPortal.Name = "tPortal";
            this.tPortal.Size = new System.Drawing.Size(47, 20);
            this.tPortal.TabIndex = 4;
            // 
            // lPortal
            // 
            this.lPortal.AutoSize = true;
            this.lPortal.Location = new System.Drawing.Point(610, 16);
            this.lPortal.Name = "lPortal";
            this.lPortal.Size = new System.Drawing.Size(22, 13);
            this.lPortal.TabIndex = 0;
            this.lPortal.Text = "Ptl.";
            // 
            // tEscalera
            // 
            this.tEscalera.Location = new System.Drawing.Point(560, 37);
            this.tEscalera.MaxLength = 2;
            this.tEscalera.Name = "tEscalera";
            this.tEscalera.Size = new System.Drawing.Size(47, 20);
            this.tEscalera.TabIndex = 3;
            // 
            // lEscalera
            // 
            this.lEscalera.AutoSize = true;
            this.lEscalera.Location = new System.Drawing.Point(557, 16);
            this.lEscalera.Name = "lEscalera";
            this.lEscalera.Size = new System.Drawing.Size(28, 13);
            this.lEscalera.TabIndex = 0;
            this.lEscalera.Text = "Esc.";
            // 
            // tBloque
            // 
            this.tBloque.Location = new System.Drawing.Point(507, 37);
            this.tBloque.MaxLength = 2;
            this.tBloque.Name = "tBloque";
            this.tBloque.Size = new System.Drawing.Size(47, 20);
            this.tBloque.TabIndex = 2;
            // 
            // lBloque
            // 
            this.lBloque.AutoSize = true;
            this.lBloque.Location = new System.Drawing.Point(504, 16);
            this.lBloque.Name = "lBloque";
            this.lBloque.Size = new System.Drawing.Size(25, 13);
            this.lBloque.TabIndex = 0;
            this.lBloque.Text = "Blq.";
            // 
            // tNumero
            // 
            this.tNumero.Location = new System.Drawing.Point(454, 37);
            this.tNumero.MaxLength = 4;
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(47, 20);
            this.tNumero.TabIndex = 1;
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Location = new System.Drawing.Point(451, 16);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(19, 13);
            this.lNumero.TabIndex = 0;
            this.lNumero.Text = "Nº";
            // 
            // gOtros
            // 
            this.gOtros.Controls.Add(this.lIrpf);
            this.gOtros.Controls.Add(this.lBic);
            this.gOtros.Controls.Add(this.lObservaciones);
            this.gOtros.Controls.Add(this.lIban);
            this.gOtros.Controls.Add(this.lDiasPago);
            this.gOtros.Controls.Add(this.lDescuento);
            this.gOtros.Controls.Add(this.tIrpf);
            this.gOtros.Controls.Add(this.tBic);
            this.gOtros.Controls.Add(this.tObservaciones);
            this.gOtros.Controls.Add(this.tIban);
            this.gOtros.Controls.Add(this.tDiasPago);
            this.gOtros.Controls.Add(this.tDescuento);
            this.gOtros.Location = new System.Drawing.Point(3, 289);
            this.gOtros.Name = "gOtros";
            this.gOtros.Size = new System.Drawing.Size(974, 196);
            this.gOtros.TabIndex = 2;
            this.gOtros.TabStop = false;
            this.gOtros.Text = "Otros";
            // 
            // lIrpf
            // 
            this.lIrpf.AutoSize = true;
            this.lIrpf.Location = new System.Drawing.Point(604, 13);
            this.lIrpf.Name = "lIrpf";
            this.lIrpf.Size = new System.Drawing.Size(31, 13);
            this.lIrpf.TabIndex = 0;
            this.lIrpf.Text = "IRPF";
            // 
            // lBic
            // 
            this.lBic.AutoSize = true;
            this.lBic.Location = new System.Drawing.Point(451, 13);
            this.lBic.Name = "lBic";
            this.lBic.Size = new System.Drawing.Size(24, 13);
            this.lBic.TabIndex = 0;
            this.lBic.Text = "BIC";
            // 
            // lObservaciones
            // 
            this.lObservaciones.AutoSize = true;
            this.lObservaciones.Location = new System.Drawing.Point(6, 62);
            this.lObservaciones.Name = "lObservaciones";
            this.lObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lObservaciones.TabIndex = 0;
            this.lObservaciones.Text = "Observaciones";
            // 
            // lIban
            // 
            this.lIban.AutoSize = true;
            this.lIban.Location = new System.Drawing.Point(156, 13);
            this.lIban.Name = "lIban";
            this.lIban.Size = new System.Drawing.Size(32, 13);
            this.lIban.TabIndex = 0;
            this.lIban.Text = "IBAN";
            // 
            // lDiasPago
            // 
            this.lDiasPago.AutoSize = true;
            this.lDiasPago.Location = new System.Drawing.Point(86, 13);
            this.lDiasPago.Name = "lDiasPago";
            this.lDiasPago.Size = new System.Drawing.Size(58, 13);
            this.lDiasPago.TabIndex = 0;
            this.lDiasPago.Text = "Días Pago";
            // 
            // lDescuento
            // 
            this.lDescuento.AutoSize = true;
            this.lDescuento.Location = new System.Drawing.Point(6, 13);
            this.lDescuento.Name = "lDescuento";
            this.lDescuento.Size = new System.Drawing.Size(70, 13);
            this.lDescuento.TabIndex = 0;
            this.lDescuento.Text = "% Descuento";
            // 
            // tIrpf
            // 
            this.tIrpf.Location = new System.Drawing.Point(607, 34);
            this.tIrpf.MaxLength = 2;
            this.tIrpf.Name = "tIrpf";
            this.tIrpf.Size = new System.Drawing.Size(135, 20);
            this.tIrpf.TabIndex = 4;
            // 
            // tBic
            // 
            this.tBic.Location = new System.Drawing.Point(454, 34);
            this.tBic.MaxLength = 11;
            this.tBic.Name = "tBic";
            this.tBic.Size = new System.Drawing.Size(135, 20);
            this.tBic.TabIndex = 3;
            // 
            // tObservaciones
            // 
            this.tObservaciones.Location = new System.Drawing.Point(9, 83);
            this.tObservaciones.MaxLength = 1000;
            this.tObservaciones.Multiline = true;
            this.tObservaciones.Name = "tObservaciones";
            this.tObservaciones.Size = new System.Drawing.Size(959, 103);
            this.tObservaciones.TabIndex = 5;
            // 
            // tIban
            // 
            this.tIban.Location = new System.Drawing.Point(159, 34);
            this.tIban.MaxLength = 24;
            this.tIban.Name = "tIban";
            this.tIban.Size = new System.Drawing.Size(276, 20);
            this.tIban.TabIndex = 2;
            // 
            // tDiasPago
            // 
            this.tDiasPago.Location = new System.Drawing.Point(89, 34);
            this.tDiasPago.MaxLength = 3;
            this.tDiasPago.Name = "tDiasPago";
            this.tDiasPago.Size = new System.Drawing.Size(55, 20);
            this.tDiasPago.TabIndex = 1;
            // 
            // tDescuento
            // 
            this.tDescuento.Location = new System.Drawing.Point(9, 34);
            this.tDescuento.MaxLength = 2;
            this.tDescuento.Name = "tDescuento";
            this.tDescuento.Size = new System.Drawing.Size(67, 20);
            this.tDescuento.TabIndex = 0;
            this.tDescuento.Text = "0";
            // 
            // btAñadirCliente
            // 
            this.btAñadirCliente.Location = new System.Drawing.Point(3, 491);
            this.btAñadirCliente.Name = "btAñadirCliente";
            this.btAñadirCliente.Size = new System.Drawing.Size(84, 23);
            this.btAñadirCliente.TabIndex = 2;
            this.btAñadirCliente.Text = "Añadir Cliente";
            this.btAñadirCliente.UseVisualStyleBackColor = true;
            this.btAñadirCliente.Click += new System.EventHandler(this.accionAñadirCliente);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(93, 491);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // FormClientesAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormClientesAñadir";
            this.Text = "AñadirCliente";
            this.Load += new System.EventHandler(this.inicializar);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gNombre.ResumeLayout(false);
            this.gNombre.PerformLayout();
            this.gDireccion.ResumeLayout(false);
            this.gDireccion.PerformLayout();
            this.gOtros.ResumeLayout(false);
            this.gOtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tCif;
        private System.Windows.Forms.Label lCif;
        private System.Windows.Forms.TextBox tApellido1;
        private System.Windows.Forms.Label lApellido1;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellido2;
        private System.Windows.Forms.Label lApellido2;
        private System.Windows.Forms.GroupBox gNombre;
        private System.Windows.Forms.GroupBox gDireccion;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.TextBox tPuerta;
        private System.Windows.Forms.Label lPuerta;
        private System.Windows.Forms.TextBox tPlanta;
        private System.Windows.Forms.Label lPlanta;
        private System.Windows.Forms.TextBox tPortal;
        private System.Windows.Forms.Label lPortal;
        private System.Windows.Forms.TextBox tEscalera;
        private System.Windows.Forms.Label lEscalera;
        private System.Windows.Forms.TextBox tBloque;
        private System.Windows.Forms.Label lBloque;
        private System.Windows.Forms.Label lTelefono1;
        private System.Windows.Forms.Label lProvincia;
        private System.Windows.Forms.Label lPostal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tTelefono1;
        private System.Windows.Forms.TextBox TPostal;
        private System.Windows.Forms.Label lFax;
        private System.Windows.Forms.Label lTelefono2;
        private System.Windows.Forms.TextBox tFax;
        private System.Windows.Forms.TextBox tTelefono2;
        private System.Windows.Forms.Label lWeb;
        private System.Windows.Forms.TextBox tWeb;
        private System.Windows.Forms.GroupBox gOtros;
        private System.Windows.Forms.Label lBic;
        private System.Windows.Forms.Label lIban;
        private System.Windows.Forms.Label lDiasPago;
        private System.Windows.Forms.Label lDescuento;
        private System.Windows.Forms.TextBox tBic;
        private System.Windows.Forms.TextBox tIban;
        private System.Windows.Forms.TextBox tDiasPago;
        private System.Windows.Forms.TextBox tDescuento;
        private System.Windows.Forms.Label lIrpf;
        private System.Windows.Forms.TextBox tIrpf;
        private System.Windows.Forms.Label lObservaciones;
        private System.Windows.Forms.TextBox tObservaciones;
        private System.Windows.Forms.ComboBox cTipoCliente;
        private System.Windows.Forms.Label lTipoCliente;
        private System.Windows.Forms.Label lNombreFiscal;
        private System.Windows.Forms.TextBox tNombreFiscal;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.Button btAñadirCliente;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lContacto;
        private System.Windows.Forms.TextBox tContacto;
        private System.Windows.Forms.ComboBox cPoblacion;
        private System.Windows.Forms.ComboBox cProvincia;
        private System.Windows.Forms.ComboBox cTipoPoblacion;
        private System.Windows.Forms.Label lTipoPoblacion;
    }
}