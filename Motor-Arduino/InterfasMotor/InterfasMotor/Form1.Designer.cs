namespace InterfasMotor
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
            this.components = new System.ComponentModel.Container();
            this.btnAumentarVel = new System.Windows.Forms.Button();
            this.btnGiroAntihorario = new System.Windows.Forms.Button();
            this.btnGiroHorario = new System.Windows.Forms.Button();
            this.btnDisminuirVel = new System.Windows.Forms.Button();
            this.txtValorPwm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.Puerto = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnActualizarPuertos = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAumentarVel
            // 
            this.btnAumentarVel.Location = new System.Drawing.Point(131, 48);
            this.btnAumentarVel.Name = "btnAumentarVel";
            this.btnAumentarVel.Size = new System.Drawing.Size(75, 47);
            this.btnAumentarVel.TabIndex = 0;
            this.btnAumentarVel.Text = "Aumentar Velocidad\r\n";
            this.btnAumentarVel.UseVisualStyleBackColor = true;
            this.btnAumentarVel.Click += new System.EventHandler(this.btnAumentarVel_Click);
            // 
            // btnGiroAntihorario
            // 
            this.btnGiroAntihorario.Location = new System.Drawing.Point(32, 98);
            this.btnGiroAntihorario.Name = "btnGiroAntihorario";
            this.btnGiroAntihorario.Size = new System.Drawing.Size(75, 40);
            this.btnGiroAntihorario.TabIndex = 1;
            this.btnGiroAntihorario.Text = "Giro Antihorario";
            this.btnGiroAntihorario.UseVisualStyleBackColor = true;
            this.btnGiroAntihorario.Click += new System.EventHandler(this.btnGiroAntihorario_Click);
            // 
            // btnGiroHorario
            // 
            this.btnGiroHorario.Location = new System.Drawing.Point(222, 98);
            this.btnGiroHorario.Name = "btnGiroHorario";
            this.btnGiroHorario.Size = new System.Drawing.Size(75, 40);
            this.btnGiroHorario.TabIndex = 2;
            this.btnGiroHorario.Text = "Giro horario";
            this.btnGiroHorario.UseVisualStyleBackColor = true;
            this.btnGiroHorario.Click += new System.EventHandler(this.btnGiroHorario_Click);
            // 
            // btnDisminuirVel
            // 
            this.btnDisminuirVel.Location = new System.Drawing.Point(131, 152);
            this.btnDisminuirVel.Name = "btnDisminuirVel";
            this.btnDisminuirVel.Size = new System.Drawing.Size(75, 44);
            this.btnDisminuirVel.TabIndex = 3;
            this.btnDisminuirVel.Text = "Disminuir Velocidad";
            this.btnDisminuirVel.UseVisualStyleBackColor = true;
            this.btnDisminuirVel.Click += new System.EventHandler(this.btnDisminuirVel_Click);
            // 
            // txtValorPwm
            // 
            this.txtValorPwm.Location = new System.Drawing.Point(106, 241);
            this.txtValorPwm.Name = "txtValorPwm";
            this.txtValorPwm.Size = new System.Drawing.Size(100, 20);
            this.txtValorPwm.TabIndex = 4;
            this.txtValorPwm.TextChanged += new System.EventHandler(this.txtValorPwm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor Voltaje";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Puertos disponibles";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(23, 39);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(23, 72);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(84, 23);
            this.btnDesconectar.TabIndex = 8;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // Puerto
            // 
            this.Puerto.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Puerto_DataReceived);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btnActualizarPuertos
            // 
            this.btnActualizarPuertos.Location = new System.Drawing.Point(139, 10);
            this.btnActualizarPuertos.Name = "btnActualizarPuertos";
            this.btnActualizarPuertos.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPuertos.TabIndex = 9;
            this.btnActualizarPuertos.Text = "Actualizar";
            this.btnActualizarPuertos.UseVisualStyleBackColor = true;
            this.btnActualizarPuertos.Click += new System.EventHandler(this.BtnActualizarPuertos_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(131, 115);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 10;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 324);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnActualizarPuertos);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorPwm);
            this.Controls.Add(this.btnDisminuirVel);
            this.Controls.Add(this.btnGiroHorario);
            this.Controls.Add(this.btnGiroAntihorario);
            this.Controls.Add(this.btnAumentarVel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAumentarVel;
        private System.Windows.Forms.Button btnGiroAntihorario;
        private System.Windows.Forms.Button btnGiroHorario;
        private System.Windows.Forms.Button btnDisminuirVel;
        private System.Windows.Forms.TextBox txtValorPwm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.IO.Ports.SerialPort Puerto;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnActualizarPuertos;
        private System.Windows.Forms.Button btnDetener;
    }
}

