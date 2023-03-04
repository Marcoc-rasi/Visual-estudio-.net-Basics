namespace ManejadorArchivos
{
    partial class frmPrincipal
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.lblLeído = new System.Windows.Forms.Label();
            this.btnGuardar2 = new System.Windows.Forms.Button();
            this.btnLeer2 = new System.Windows.Forms.Button();
            this.lblLeído2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLeído3 = new System.Windows.Forms.Label();
            this.btnLeer3 = new System.Windows.Forms.Button();
            this.btnGuardar3 = new System.Windows.Forms.Button();
            this.btnGuardar4 = new System.Windows.Forms.Button();
            this.btnLeer4 = new System.Windows.Forms.Button();
            this.lblLeído4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(40, 49);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(179, 49);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // lblLeído
            // 
            this.lblLeído.AutoSize = true;
            this.lblLeído.Location = new System.Drawing.Point(57, 100);
            this.lblLeído.Name = "lblLeído";
            this.lblLeído.Size = new System.Drawing.Size(167, 13);
            this.lblLeído.TabIndex = 2;
            this.lblLeído.Text = "Aqui se colocaran los datos leidos";
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Location = new System.Drawing.Point(353, 49);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar2.TabIndex = 4;
            this.btnGuardar2.Text = "Guardar";
            this.btnGuardar2.UseVisualStyleBackColor = true;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // btnLeer2
            // 
            this.btnLeer2.Location = new System.Drawing.Point(495, 49);
            this.btnLeer2.Name = "btnLeer2";
            this.btnLeer2.Size = new System.Drawing.Size(75, 23);
            this.btnLeer2.TabIndex = 5;
            this.btnLeer2.Text = "Leer";
            this.btnLeer2.UseVisualStyleBackColor = true;
            this.btnLeer2.Click += new System.EventHandler(this.btnLeer2_Click);
            // 
            // lblLeído2
            // 
            this.lblLeído2.AutoSize = true;
            this.lblLeído2.Location = new System.Drawing.Point(380, 100);
            this.lblLeído2.Name = "lblLeído2";
            this.lblLeído2.Size = new System.Drawing.Size(167, 13);
            this.lblLeído2.TabIndex = 6;
            this.lblLeído2.Text = "Aqui se colocaran los datos leidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Un solo byte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Varios bytes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Objetos StreamWriter y StreamReader";
            // 
            // lblLeído3
            // 
            this.lblLeído3.AutoSize = true;
            this.lblLeído3.Location = new System.Drawing.Point(78, 258);
            this.lblLeído3.Name = "lblLeído3";
            this.lblLeído3.Size = new System.Drawing.Size(167, 13);
            this.lblLeído3.TabIndex = 11;
            this.lblLeído3.Text = "Aqui se colocaran los datos leidos";
            // 
            // btnLeer3
            // 
            this.btnLeer3.Location = new System.Drawing.Point(193, 207);
            this.btnLeer3.Name = "btnLeer3";
            this.btnLeer3.Size = new System.Drawing.Size(75, 23);
            this.btnLeer3.TabIndex = 10;
            this.btnLeer3.Text = "Leer";
            this.btnLeer3.UseVisualStyleBackColor = true;
            this.btnLeer3.Click += new System.EventHandler(this.btnLeer3_Click);
            // 
            // btnGuardar3
            // 
            this.btnGuardar3.Location = new System.Drawing.Point(51, 207);
            this.btnGuardar3.Name = "btnGuardar3";
            this.btnGuardar3.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar3.TabIndex = 9;
            this.btnGuardar3.Text = "Guardar";
            this.btnGuardar3.UseVisualStyleBackColor = true;
            this.btnGuardar3.Click += new System.EventHandler(this.btnGuardar3_Click);
            // 
            // btnGuardar4
            // 
            this.btnGuardar4.Location = new System.Drawing.Point(362, 283);
            this.btnGuardar4.Name = "btnGuardar4";
            this.btnGuardar4.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar4.TabIndex = 13;
            this.btnGuardar4.Text = "Guardar";
            this.btnGuardar4.UseVisualStyleBackColor = true;
            this.btnGuardar4.Click += new System.EventHandler(this.btnGuardar4_Click);
            // 
            // btnLeer4
            // 
            this.btnLeer4.Location = new System.Drawing.Point(495, 283);
            this.btnLeer4.Name = "btnLeer4";
            this.btnLeer4.Size = new System.Drawing.Size(75, 23);
            this.btnLeer4.TabIndex = 14;
            this.btnLeer4.Text = "Leer";
            this.btnLeer4.UseVisualStyleBackColor = true;
            this.btnLeer4.Click += new System.EventHandler(this.btnLeer4_Click);
            // 
            // lblLeído4
            // 
            this.lblLeído4.AutoSize = true;
            this.lblLeído4.Location = new System.Drawing.Point(380, 326);
            this.lblLeído4.Name = "lblLeído4";
            this.lblLeído4.Size = new System.Drawing.Size(167, 13);
            this.lblLeído4.TabIndex = 15;
            this.lblLeído4.Text = "Aqui se colocaran los datos leidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Leida le texto completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre del archivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Datos";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(470, 195);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreArchivo.TabIndex = 19;
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(380, 221);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(190, 50);
            this.txtDatos.TabIndex = 20;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLeído4);
            this.Controls.Add(this.btnLeer4);
            this.Controls.Add(this.btnGuardar4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLeído3);
            this.Controls.Add(this.btnLeer3);
            this.Controls.Add(this.btnGuardar3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLeído2);
            this.Controls.Add(this.btnLeer2);
            this.Controls.Add(this.btnGuardar2);
            this.Controls.Add(this.lblLeído);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        public System.Windows.Forms.Label lblLeído;
        private System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.Button btnLeer2;
        public System.Windows.Forms.Label lblLeído2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblLeído3;
        private System.Windows.Forms.Button btnLeer3;
        private System.Windows.Forms.Button btnGuardar3;
        private System.Windows.Forms.Button btnGuardar4;
        private System.Windows.Forms.Button btnLeer4;
        public System.Windows.Forms.Label lblLeído4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.TextBox txtDatos;
    }
}

