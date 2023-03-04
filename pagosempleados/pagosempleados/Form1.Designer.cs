namespace pagosempleados
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
            this.checkGerente = new System.Windows.Forms.CheckBox();
            this.checkBecario = new System.Windows.Forms.CheckBox();
            this.checkExtras = new System.Windows.Forms.CheckBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.checkEmpleado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkGerente
            // 
            this.checkGerente.AutoSize = true;
            this.checkGerente.Location = new System.Drawing.Point(127, 104);
            this.checkGerente.Name = "checkGerente";
            this.checkGerente.Size = new System.Drawing.Size(64, 17);
            this.checkGerente.TabIndex = 1;
            this.checkGerente.Text = "Gerente";
            this.checkGerente.UseVisualStyleBackColor = true;
            this.checkGerente.CheckedChanged += new System.EventHandler(this.checkGerente_CheckedChanged);
            // 
            // checkBecario
            // 
            this.checkBecario.AutoSize = true;
            this.checkBecario.Location = new System.Drawing.Point(127, 183);
            this.checkBecario.Name = "checkBecario";
            this.checkBecario.Size = new System.Drawing.Size(62, 17);
            this.checkBecario.TabIndex = 3;
            this.checkBecario.Text = "Becario";
            this.checkBecario.UseVisualStyleBackColor = true;
            this.checkBecario.CheckedChanged += new System.EventHandler(this.checkBecario_CheckedChanged);
            // 
            // checkExtras
            // 
            this.checkExtras.AutoSize = true;
            this.checkExtras.Location = new System.Drawing.Point(127, 145);
            this.checkExtras.Name = "checkExtras";
            this.checkExtras.Size = new System.Drawing.Size(102, 17);
            this.checkExtras.TabIndex = 4;
            this.checkExtras.Text = "EmpleadoExtras";
            this.checkExtras.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(364, 104);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // checkEmpleado
            // 
            this.checkEmpleado.AutoSize = true;
            this.checkEmpleado.Location = new System.Drawing.Point(127, 72);
            this.checkEmpleado.Name = "checkEmpleado";
            this.checkEmpleado.Size = new System.Drawing.Size(73, 17);
            this.checkEmpleado.TabIndex = 0;
            this.checkEmpleado.Text = "Empleado";
            this.checkEmpleado.UseVisualStyleBackColor = true;
            this.checkEmpleado.CheckedChanged += new System.EventHandler(this.checkEmpleado_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.checkExtras);
            this.Controls.Add(this.checkBecario);
            this.Controls.Add(this.checkGerente);
            this.Controls.Add(this.checkEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkGerente;
        private System.Windows.Forms.CheckBox checkBecario;
        private System.Windows.Forms.CheckBox checkExtras;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.CheckBox checkEmpleado;
    }
}

