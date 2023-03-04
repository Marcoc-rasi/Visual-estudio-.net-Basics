namespace ejemplopolimorfismo
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
            this.btnVaca = new System.Windows.Forms.Button();
            this.btnPerro = new System.Windows.Forms.Button();
            this.btnGato = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVaca
            // 
            this.btnVaca.Location = new System.Drawing.Point(140, 42);
            this.btnVaca.Name = "btnVaca";
            this.btnVaca.Size = new System.Drawing.Size(75, 23);
            this.btnVaca.TabIndex = 0;
            this.btnVaca.Text = "Vaca";
            this.btnVaca.UseVisualStyleBackColor = true;
            this.btnVaca.Click += new System.EventHandler(this.btnVaca_Click);
            // 
            // btnPerro
            // 
            this.btnPerro.Location = new System.Drawing.Point(140, 102);
            this.btnPerro.Name = "btnPerro";
            this.btnPerro.Size = new System.Drawing.Size(75, 23);
            this.btnPerro.TabIndex = 1;
            this.btnPerro.Text = "Perro";
            this.btnPerro.UseVisualStyleBackColor = true;
            this.btnPerro.Click += new System.EventHandler(this.btnPerro_Click);
            // 
            // btnGato
            // 
            this.btnGato.Location = new System.Drawing.Point(140, 181);
            this.btnGato.Name = "btnGato";
            this.btnGato.Size = new System.Drawing.Size(75, 23);
            this.btnGato.TabIndex = 2;
            this.btnGato.Text = "Gato";
            this.btnGato.UseVisualStyleBackColor = true;
            this.btnGato.Click += new System.EventHandler(this.btnGato_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGato);
            this.Controls.Add(this.btnPerro);
            this.Controls.Add(this.btnVaca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVaca;
        private System.Windows.Forms.Button btnPerro;
        private System.Windows.Forms.Button btnGato;
        private System.Windows.Forms.TextBox textBox1;
    }
}

