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
            this.lNombre = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.lApellido1 = new System.Windows.Forms.Label();
            this.tApellido1 = new System.Windows.Forms.TextBox();
            this.tCif = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lApellido2 = new System.Windows.Forms.Label();
            this.tApellido2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 425);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(6, 16);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(9, 37);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(135, 20);
            this.tNombre.TabIndex = 1;
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
            // tApellido1
            // 
            this.tApellido1.Location = new System.Drawing.Point(150, 37);
            this.tApellido1.Name = "tApellido1";
            this.tApellido1.Size = new System.Drawing.Size(144, 20);
            this.tApellido1.TabIndex = 1;
            // 
            // tCif
            // 
            this.tCif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tCif.AutoSize = true;
            this.tCif.Location = new System.Drawing.Point(721, 16);
            this.tCif.Name = "tCif";
            this.tCif.Size = new System.Drawing.Size(45, 13);
            this.tCif.TabIndex = 0;
            this.tCif.Text = "CIF/NIF";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(622, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 1;
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
            this.tApellido2.Name = "tApellido2";
            this.tApellido2.Size = new System.Drawing.Size(144, 20);
            this.tApellido2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lNombre);
            this.groupBox1.Controls.Add(this.tCif);
            this.groupBox1.Controls.Add(this.lApellido2);
            this.groupBox1.Controls.Add(this.tApellido2);
            this.groupBox1.Controls.Add(this.tNombre);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.tApellido1);
            this.groupBox1.Controls.Add(this.lApellido1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre";
            // 
            // FormClientesAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormClientesAñadir";
            this.Text = "AñadirCliente";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label tCif;
        private System.Windows.Forms.TextBox tApellido1;
        private System.Windows.Forms.Label lApellido1;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellido2;
        private System.Windows.Forms.Label lApellido2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}