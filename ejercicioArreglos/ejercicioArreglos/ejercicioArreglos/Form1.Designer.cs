namespace ejercicioArreglos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtVector1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtVector2 = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMultiplicarE = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar2 = new System.Windows.Forms.Button();
            this.txtVectorU1 = new System.Windows.Forms.TextBox();
            this.txtVectorU2 = new System.Windows.Forms.TextBox();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVector1
            // 
            this.txtVector1.Location = new System.Drawing.Point(105, 51);
            this.txtVector1.Name = "txtVector1";
            this.txtVector1.Size = new System.Drawing.Size(100, 20);
            this.txtVector1.TabIndex = 0;
            this.txtVector1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VECTOR DE NUMEROS";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(115, 109);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "SUMAR";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVector2
            // 
            this.txtVector2.Location = new System.Drawing.Point(284, 51);
            this.txtVector2.Name = "txtVector2";
            this.txtVector2.Size = new System.Drawing.Size(100, 20);
            this.txtVector2.TabIndex = 3;
            this.txtVector2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(284, 112);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 4;
            this.txtSuma.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VECTOR INTRODUCIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RESULTADO SUMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(688, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // btnMultiplicarE
            // 
            this.btnMultiplicarE.Location = new System.Drawing.Point(41, 347);
            this.btnMultiplicarE.Name = "btnMultiplicarE";
            this.btnMultiplicarE.Size = new System.Drawing.Size(88, 41);
            this.btnMultiplicarE.TabIndex = 8;
            this.btnMultiplicarE.Text = "MULTIPLICAR ESCALARMENTE";
            this.btnMultiplicarE.UseVisualStyleBackColor = true;
            this.btnMultiplicarE.Click += new System.EventHandler(this.btnMultiplicarE_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(54, 318);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 23);
            this.btnRestar.TabIndex = 9;
            this.btnRestar.Text = "RESTAR";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSumar2
            // 
            this.btnSumar2.Location = new System.Drawing.Point(54, 275);
            this.btnSumar2.Name = "btnSumar2";
            this.btnSumar2.Size = new System.Drawing.Size(75, 23);
            this.btnSumar2.TabIndex = 10;
            this.btnSumar2.Text = "SUMAR";
            this.btnSumar2.UseVisualStyleBackColor = true;
            this.btnSumar2.Click += new System.EventHandler(this.btnSumar2_Click);
            // 
            // txtVectorU1
            // 
            this.txtVectorU1.Location = new System.Drawing.Point(54, 215);
            this.txtVectorU1.Name = "txtVectorU1";
            this.txtVectorU1.Size = new System.Drawing.Size(100, 20);
            this.txtVectorU1.TabIndex = 11;
            // 
            // txtVectorU2
            // 
            this.txtVectorU2.Location = new System.Drawing.Point(207, 215);
            this.txtVectorU2.Name = "txtVectorU2";
            this.txtVectorU2.Size = new System.Drawing.Size(100, 20);
            this.txtVectorU2.TabIndex = 12;
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(207, 318);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(100, 20);
            this.txtResultado2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "VECTOR DE NUMEROS 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "VECTOR DE NUMEROS 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "MULTIPLICAR VECTORIALMENTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.txtVectorU2);
            this.Controls.Add(this.txtVectorU1);
            this.Controls.Add(this.btnSumar2);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnMultiplicarE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtVector2);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVector1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVector1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtVector2;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMultiplicarE;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar2;
        private System.Windows.Forms.TextBox txtVectorU1;
        private System.Windows.Forms.TextBox txtVectorU2;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

