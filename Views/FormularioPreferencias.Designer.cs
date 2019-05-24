namespace facturacion.Views
{
    partial class FormularioPreferencias
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
            this.panelBase = new System.Windows.Forms.FlowLayoutPanel();
            this.gBaseDatos = new System.Windows.Forms.GroupBox();
            this.cBaseDatosLocal = new System.Windows.Forms.CheckBox();
            this.cSeguridadIntegrada = new System.Windows.Forms.CheckBox();
            this.lContraseña = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lBaseDatos = new System.Windows.Forms.Label();
            this.lServidor = new System.Windows.Forms.Label();
            this.tContraseña = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tBaseDatos = new System.Windows.Forms.TextBox();
            this.tServidor = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.panelBase.SuspendLayout();
            this.gBaseDatos.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.gBaseDatos);
            this.panelBase.Location = new System.Drawing.Point(12, 12);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1359, 121);
            this.panelBase.TabIndex = 0;
            // 
            // gBaseDatos
            // 
            this.gBaseDatos.Controls.Add(this.cBaseDatosLocal);
            this.gBaseDatos.Controls.Add(this.cSeguridadIntegrada);
            this.gBaseDatos.Controls.Add(this.lContraseña);
            this.gBaseDatos.Controls.Add(this.lUsuario);
            this.gBaseDatos.Controls.Add(this.lBaseDatos);
            this.gBaseDatos.Controls.Add(this.lServidor);
            this.gBaseDatos.Controls.Add(this.tContraseña);
            this.gBaseDatos.Controls.Add(this.tUsuario);
            this.gBaseDatos.Controls.Add(this.tBaseDatos);
            this.gBaseDatos.Controls.Add(this.tServidor);
            this.gBaseDatos.Location = new System.Drawing.Point(3, 3);
            this.gBaseDatos.Name = "gBaseDatos";
            this.gBaseDatos.Size = new System.Drawing.Size(1356, 107);
            this.gBaseDatos.TabIndex = 0;
            this.gBaseDatos.TabStop = false;
            this.gBaseDatos.Text = "Base de datos";
            // 
            // cBaseDatosLocal
            // 
            this.cBaseDatosLocal.AutoSize = true;
            this.cBaseDatosLocal.Location = new System.Drawing.Point(1191, 48);
            this.cBaseDatosLocal.Name = "cBaseDatosLocal";
            this.cBaseDatosLocal.Size = new System.Drawing.Size(154, 21);
            this.cBaseDatosLocal.TabIndex = 2;
            this.cBaseDatosLocal.Text = "Base de datos local";
            this.cBaseDatosLocal.UseVisualStyleBackColor = true;
            // 
            // cSeguridadIntegrada
            // 
            this.cSeguridadIntegrada.AutoSize = true;
            this.cSeguridadIntegrada.Location = new System.Drawing.Point(1191, 21);
            this.cSeguridadIntegrada.Name = "cSeguridadIntegrada";
            this.cSeguridadIntegrada.Size = new System.Drawing.Size(159, 21);
            this.cSeguridadIntegrada.TabIndex = 2;
            this.cSeguridadIntegrada.Text = "Seguridad Integrada";
            this.cSeguridadIntegrada.UseVisualStyleBackColor = true;
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Location = new System.Drawing.Point(894, 44);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(81, 17);
            this.lContraseña.TabIndex = 1;
            this.lContraseña.Text = "Contraseña";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(614, 44);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(57, 17);
            this.lUsuario.TabIndex = 1;
            this.lUsuario.Text = "Usuario";
            // 
            // lBaseDatos
            // 
            this.lBaseDatos.AutoSize = true;
            this.lBaseDatos.Location = new System.Drawing.Point(290, 44);
            this.lBaseDatos.Name = "lBaseDatos";
            this.lBaseDatos.Size = new System.Drawing.Size(101, 17);
            this.lBaseDatos.TabIndex = 1;
            this.lBaseDatos.Text = "Base de Datos";
            // 
            // lServidor
            // 
            this.lServidor.AutoSize = true;
            this.lServidor.Location = new System.Drawing.Point(6, 44);
            this.lServidor.Name = "lServidor";
            this.lServidor.Size = new System.Drawing.Size(61, 17);
            this.lServidor.TabIndex = 1;
            this.lServidor.Text = "Servidor";
            // 
            // tContraseña
            // 
            this.tContraseña.Location = new System.Drawing.Point(1003, 41);
            this.tContraseña.Name = "tContraseña";
            this.tContraseña.PasswordChar = '*';
            this.tContraseña.Size = new System.Drawing.Size(167, 22);
            this.tContraseña.TabIndex = 0;
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(699, 41);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(167, 22);
            this.tUsuario.TabIndex = 0;
            // 
            // tBaseDatos
            // 
            this.tBaseDatos.Location = new System.Drawing.Point(419, 41);
            this.tBaseDatos.Name = "tBaseDatos";
            this.tBaseDatos.Size = new System.Drawing.Size(167, 22);
            this.tBaseDatos.TabIndex = 0;
            // 
            // tServidor
            // 
            this.tServidor.Location = new System.Drawing.Point(95, 41);
            this.tServidor.Name = "tServidor";
            this.tServidor.Size = new System.Drawing.Size(167, 22);
            this.tServidor.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 201);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1383, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancelar);
            this.flowLayoutPanel1.Controls.Add(this.bAceptar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 139);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1358, 44);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(1280, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 0;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(1199, 3);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.accionGuardar);
            // 
            // FormularioPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 223);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelBase);
            this.Name = "FormularioPreferencias";
            this.Text = "Preferencias";
            this.Load += new System.EventHandler(this.accionLoad);
            this.panelBase.ResumeLayout(false);
            this.gBaseDatos.ResumeLayout(false);
            this.gBaseDatos.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelBase;
        private System.Windows.Forms.GroupBox gBaseDatos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tServidor;
        private System.Windows.Forms.CheckBox cSeguridadIntegrada;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lServidor;
        private System.Windows.Forms.TextBox tContraseña;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.CheckBox cBaseDatosLocal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label lBaseDatos;
        private System.Windows.Forms.TextBox tBaseDatos;
    }
}