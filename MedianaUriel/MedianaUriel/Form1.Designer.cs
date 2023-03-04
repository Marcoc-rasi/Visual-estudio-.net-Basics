namespace MedianaUriel
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtVector = new System.Windows.Forms.TextBox();
            this.btnMediana = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVector
            // 
            this.txtVector.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtVector.Location = new System.Drawing.Point(99, 67);
            this.txtVector.Name = "txtVector";
            this.txtVector.Size = new System.Drawing.Size(100, 20);
            this.txtVector.TabIndex = 0;
            // 
            // btnMediana
            // 
            this.btnMediana.Location = new System.Drawing.Point(65, 120);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(75, 41);
            this.btnMediana.TabIndex = 1;
            this.btnMediana.Text = "Calcular Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(99, 220);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mediana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introdusca los valores del vector separados por una coma";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(182, 120);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(80, 41);
            this.btnComprobar.TabIndex = 5;
            this.btnComprobar.Text = "Comprobar Mediana";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 344);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnMediana);
            this.Controls.Add(this.txtVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox txtVector;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprobar;
    }
}

