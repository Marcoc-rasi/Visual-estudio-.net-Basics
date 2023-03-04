namespace ListaUriel
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
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarInicioLista = new System.Windows.Forms.Button();
            this.btnEliminarFinalLista = new System.Windows.Forms.Button();
            this.btnInsertarFinalLista = new System.Windows.Forms.Button();
            this.btnInsertarInicioLista = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnInsertarCola = new System.Windows.Forms.Button();
            this.btnEliminarCola = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPila = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.txtEliminadoCola = new System.Windows.Forms.TextBox();
            this.txtEliminadoPila = new System.Windows.Forms.TextBox();
            this.txtEliminadoLista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(79, 47);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(100, 20);
            this.txtLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserte el dato del elemento a guardar";
            // 
            // btnEliminarInicioLista
            // 
            this.btnEliminarInicioLista.Location = new System.Drawing.Point(252, 3);
            this.btnEliminarInicioLista.Name = "btnEliminarInicioLista";
            this.btnEliminarInicioLista.Size = new System.Drawing.Size(75, 42);
            this.btnEliminarInicioLista.TabIndex = 2;
            this.btnEliminarInicioLista.Text = "Eliminar al inicio";
            this.btnEliminarInicioLista.UseVisualStyleBackColor = true;
            this.btnEliminarInicioLista.Click += new System.EventHandler(this.btnEliminarInicioLista_Click);
            // 
            // btnEliminarFinalLista
            // 
            this.btnEliminarFinalLista.Location = new System.Drawing.Point(252, 51);
            this.btnEliminarFinalLista.Name = "btnEliminarFinalLista";
            this.btnEliminarFinalLista.Size = new System.Drawing.Size(75, 41);
            this.btnEliminarFinalLista.TabIndex = 3;
            this.btnEliminarFinalLista.Text = "Eliminar al final";
            this.btnEliminarFinalLista.UseVisualStyleBackColor = true;
            this.btnEliminarFinalLista.Click += new System.EventHandler(this.btnEliminarFinalLista_Click);
            // 
            // btnInsertarFinalLista
            // 
            this.btnInsertarFinalLista.Location = new System.Drawing.Point(369, 46);
            this.btnInsertarFinalLista.Name = "btnInsertarFinalLista";
            this.btnInsertarFinalLista.Size = new System.Drawing.Size(75, 42);
            this.btnInsertarFinalLista.TabIndex = 4;
            this.btnInsertarFinalLista.Text = "Insertar Al final";
            this.btnInsertarFinalLista.UseVisualStyleBackColor = true;
            this.btnInsertarFinalLista.Click += new System.EventHandler(this.btnInsertarFinalLista_Click);
            // 
            // btnInsertarInicioLista
            // 
            this.btnInsertarInicioLista.Location = new System.Drawing.Point(369, 3);
            this.btnInsertarInicioLista.Name = "btnInsertarInicioLista";
            this.btnInsertarInicioLista.Size = new System.Drawing.Size(75, 38);
            this.btnInsertarInicioLista.TabIndex = 5;
            this.btnInsertarInicioLista.Text = "Insertar al inicio";
            this.btnInsertarInicioLista.UseVisualStyleBackColor = true;
            this.btnInsertarInicioLista.Click += new System.EventHandler(this.btnInsertarInicioLista_Click);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(252, 142);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 6;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(379, 142);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 7;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnInsertarCola
            // 
            this.btnInsertarCola.Location = new System.Drawing.Point(252, 262);
            this.btnInsertarCola.Name = "btnInsertarCola";
            this.btnInsertarCola.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarCola.TabIndex = 8;
            this.btnInsertarCola.Text = "Insertar";
            this.btnInsertarCola.UseVisualStyleBackColor = true;
            this.btnInsertarCola.Click += new System.EventHandler(this.btnInsertarCola_Click);
            // 
            // btnEliminarCola
            // 
            this.btnEliminarCola.Location = new System.Drawing.Point(379, 262);
            this.btnEliminarCola.Name = "btnEliminarCola";
            this.btnEliminarCola.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCola.TabIndex = 9;
            this.btnEliminarCola.Text = "Eliminar";
            this.btnEliminarCola.UseVisualStyleBackColor = true;
            this.btnEliminarCola.Click += new System.EventHandler(this.btnEliminarCola_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inserte el dato del elemento a guardar";
            // 
            // txtPila
            // 
            this.txtPila.Location = new System.Drawing.Point(79, 142);
            this.txtPila.Name = "txtPila";
            this.txtPila.Size = new System.Drawing.Size(100, 20);
            this.txtPila.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inserte el dato del elemento a guardar";
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(79, 262);
            this.txtCola.Name = "txtCola";
            this.txtCola.Size = new System.Drawing.Size(100, 20);
            this.txtCola.TabIndex = 12;
            // 
            // txtEliminadoCola
            // 
            this.txtEliminadoCola.Location = new System.Drawing.Point(545, 268);
            this.txtEliminadoCola.Name = "txtEliminadoCola";
            this.txtEliminadoCola.Size = new System.Drawing.Size(100, 20);
            this.txtEliminadoCola.TabIndex = 14;
            // 
            // txtEliminadoPila
            // 
            this.txtEliminadoPila.Location = new System.Drawing.Point(545, 144);
            this.txtEliminadoPila.Name = "txtEliminadoPila";
            this.txtEliminadoPila.Size = new System.Drawing.Size(100, 20);
            this.txtEliminadoPila.TabIndex = 15;
            // 
            // txtEliminadoLista
            // 
            this.txtEliminadoLista.Location = new System.Drawing.Point(545, 38);
            this.txtEliminadoLista.Name = "txtEliminadoLista";
            this.txtEliminadoLista.Size = new System.Drawing.Size(100, 20);
            this.txtEliminadoLista.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor del elemento eliminado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Valor del elemento eliminado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valor del elemento eliminado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Lista";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Pila";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEliminadoLista);
            this.Controls.Add(this.txtEliminadoPila);
            this.Controls.Add(this.txtEliminadoCola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPila);
            this.Controls.Add(this.btnEliminarCola);
            this.Controls.Add(this.btnInsertarCola);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.btnInsertarInicioLista);
            this.Controls.Add(this.btnInsertarFinalLista);
            this.Controls.Add(this.btnEliminarFinalLista);
            this.Controls.Add(this.btnEliminarInicioLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarInicioLista;
        private System.Windows.Forms.Button btnEliminarFinalLista;
        private System.Windows.Forms.Button btnInsertarFinalLista;
        private System.Windows.Forms.Button btnInsertarInicioLista;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnInsertarCola;
        private System.Windows.Forms.Button btnEliminarCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.TextBox txtEliminadoCola;
        private System.Windows.Forms.TextBox txtEliminadoPila;
        private System.Windows.Forms.TextBox txtEliminadoLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

