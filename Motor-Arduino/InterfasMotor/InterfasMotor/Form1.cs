using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InterfasMotor
{
    public partial class Form1 : Form
    {
        public string DatosRecibidos = "0";
        //private string CadenaRecibida;
        public Form1()
        {
            InitializeComponent();
            BuscarPuertos();
        }
        private void BuscarPuertos()
        {
            //Obtener el nombre de puertos existentes en el equipo
            string[] NombresPuertos = SerialPort.GetPortNames();
            //Eliminar los elementos del control ComboBox
            comboBox1.Items.Clear();
            //Ciclo para agregar los nombres de los puertos de los puertos al control ComboBox
            foreach (string Nombre in NombresPuertos)
            {
                comboBox1.Items.Add(Nombre);
            }
            //Agregar el mensaje en la propiedad del control
            comboBox1.Text = "Seleccione puerto";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asignar el nombre actual del ComboBox a la propiedad PortName del puerto
            Puerto.PortName =comboBox1.SelectedItem.ToString();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                Puerto.Open();
                MessageBox.Show("Puerto Abierto");
                timer.Start();
            }
            catch(Exception error)
            {
                
                MessageBox.Show(error.Message,"valio madree",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //Si el puerto está abierto
            if (Puerto.IsOpen)
            {
                //Cierra el puerto
                Puerto.Close();
                //Envía un mensaje de que se ha cerrado el puerto
                MessageBox.Show("Puerto cerrado");
                //Detener timer
                timer.Stop();
            }
            else
            {
                //Enviar mensaje de que el puerto no está abierto
                MessageBox.Show("El puerto está cerrado.");
            }
        }
        public void Enviar(string s)
        {
            //Si el puerto está abierto
            if (Puerto.IsOpen)
                //Escribe en el puerto la cadena a enviar
                Puerto.WriteLine(s);
            else
                //Enviar mensaje de error si no está abierto el puerto
                MessageBox.Show("Necesita conectarse al puerto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnAumentarVel_Click(object sender, EventArgs e)
        {
            Enviar("a");
        }

        private void btnGiroAntihorario_Click(object sender, EventArgs e)
        {
            Enviar("n");
        }

        private void btnGiroHorario_Click(object sender, EventArgs e)
        {
            Enviar("h");
        }

        private void btnDisminuirVel_Click(object sender, EventArgs e)
        {
            Enviar("d");
        }

        private void txtValorPwm_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnActualizarPuertos_Click(object sender, EventArgs e)
        {
            BuscarPuertos();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            txtValorPwm.Text = DatosRecibidos;
        }
        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (Puerto.IsOpen)
            {
                //Espera 25 ms
                Thread.Sleep(25);
                //Asigna los datos existentes en el búfer al atributo CadenaRecibida
                DatosRecibidos = Puerto.ReadExisting();
            }
            else
            {
                //Enviar mensaje de que el puerto no está abierto
                MessageBox.Show("El puerto está cerrado.");
            }
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            Enviar("c");
        }
    }

}
