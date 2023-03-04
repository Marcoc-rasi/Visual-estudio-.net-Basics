using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CajerosUriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }
        Queue<Cliente> ColaUsuarios = new Queue<Cliente>();
        int a = 0, e = 0, i = 0, o = 0; 
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string nombreUsuario;
            nombreUsuario = txtNombreUsuario.Text;
            Cliente NuevoUsuario = new Cliente();
            NuevoUsuario.Nombre = nombreUsuario;
            NuevoUsuario.Tiempo = random.Next(1, 11);
            ColaUsuarios.Enqueue(NuevoUsuario);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ColaUsuarios.Count!=0) {
                Cliente usuario = new Cliente();
                if (a == 0)
                {
                    usuario = ColaUsuarios.Dequeue();
                }
                if (a != -1)
                {
                    txtCajero1.Text = Convert.ToString(a);
                }
                if (usuario.Tiempo == a)
                {
                    a = -1;
                    txtCajero1.Text = "";
                }
                a++;
            }
            else
            {
                txtCajero1.Text = "En espera de cliente";
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }
    }
}
