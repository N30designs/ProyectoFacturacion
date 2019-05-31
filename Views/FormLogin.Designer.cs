namespace facturacion.Views
{
    partial class FormLogin
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
            this.lUsuario = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.cbRecordar = new System.Windows.Forms.CheckBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(12, 24);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(56, 13);
            this.lUsuario.TabIndex = 0;
            this.lUsuario.Text = "USUARIO";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(15, 40);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(192, 20);
            this.tUsuario.TabIndex = 0;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 69);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(81, 13);
            this.lPassword.TabIndex = 0;
            this.lPassword.Text = "CONTRASEÑA";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(15, 85);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(192, 20);
            this.tPassword.TabIndex = 1;
            // 
            // cbRecordar
            // 
            this.cbRecordar.AutoSize = true;
            this.cbRecordar.Location = new System.Drawing.Point(15, 122);
            this.cbRecordar.Name = "cbRecordar";
            this.cbRecordar.Size = new System.Drawing.Size(127, 17);
            this.cbRecordar.TabIndex = 2;
            this.cbRecordar.Text = "Recordar Contraseña";
            this.cbRecordar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(12, 176);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 4;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(132, 176);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.accionAceptar);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 211);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.cbRecordar);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.lUsuario);
            this.Name = "FormLogin";
            this.Text = "INICIAR SESIÓN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.CheckBox cbRecordar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
    }
}