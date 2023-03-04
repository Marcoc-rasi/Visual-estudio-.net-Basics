namespace AgendaPorInterfacesUriel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContacto = new System.Windows.Forms.Button();
            this.txtListaContactos = new System.Windows.Forms.TextBox();
            this.btnDesplegarContactos = new System.Windows.Forms.Button();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(243, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el nombre del contacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el numero";
            // 
            // btnContacto
            // 
            this.btnContacto.Location = new System.Drawing.Point(400, 11);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(75, 44);
            this.btnContacto.TabIndex = 4;
            this.btnContacto.Text = "Agregar contacto";
            this.btnContacto.UseVisualStyleBackColor = true;
            this.btnContacto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtListaContactos
            // 
            this.txtListaContactos.Location = new System.Drawing.Point(70, 102);
            this.txtListaContactos.Multiline = true;
            this.txtListaContactos.Name = "txtListaContactos";
            this.txtListaContactos.Size = new System.Drawing.Size(273, 156);
            this.txtListaContactos.TabIndex = 5;
            // 
            // btnDesplegarContactos
            // 
            this.btnDesplegarContactos.AllowDrop = true;
            this.btnDesplegarContactos.Location = new System.Drawing.Point(414, 141);
            this.btnDesplegarContactos.Name = "btnDesplegarContactos";
            this.btnDesplegarContactos.Size = new System.Drawing.Size(75, 42);
            this.btnDesplegarContactos.TabIndex = 7;
            this.btnDesplegarContactos.Text = "Dezplegar contactos";
            this.btnDesplegarContactos.UseVisualStyleBackColor = true;
            this.btnDesplegarContactos.Click += new System.EventHandler(this.BtnDesplegarContactos_Click);
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.AllowDrop = true;
            this.btnBuscarContacto.Location = new System.Drawing.Point(414, 216);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(75, 42);
            this.btnBuscarContacto.TabIndex = 8;
            this.btnBuscarContacto.Text = "Buscar Contacto";
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.BtnBuscarContacto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnBuscarContacto);
            this.Controls.Add(this.btnDesplegarContactos);
            this.Controls.Add(this.txtListaContactos);
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContacto;
        private System.Windows.Forms.TextBox txtListaContactos;
        private System.Windows.Forms.Button btnDesplegarContactos;
        private System.Windows.Forms.Button btnBuscarContacto;
    }
}

