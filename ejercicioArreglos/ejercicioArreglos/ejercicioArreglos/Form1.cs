using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioArreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float[] vector = new float[4];
        float[] vector2 = new float[4];

        string[] usuario = new string[4];
        string[] usuario2 = new string[4];
        string cadenausuario;
        int i;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float suma=0;
            cadenausuario = txtVector1.Text;
            txtVector2.Text = cadenausuario;
            usuario = cadenausuario.Split(',');
            for (i=0;i<=3; i++)
            {
                vector[i] = Convert.ToSingle(usuario[i]);
                suma= vector[i] + suma;
            }

            txtSuma.Text = Convert.ToString(suma);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar2_Click(object sender, EventArgs e)
        {
            float sumai = 0;
            float sumaj = 0;
            float sumak = 0;
            cadenausuario = txtVectorU1.Text;
            usuario = cadenausuario.Split(',');
            cadenausuario = txtVectorU2.Text;
            usuario2 = cadenausuario.Split(',');
            for (i = 0; i <= 2; i++)
            {
                vector[i] = Convert.ToSingle(usuario[i]);
                vector2[i] = Convert.ToSingle(usuario2[i]);
            }
            sumai = vector[0] + vector2[0];
            sumaj = vector[1] + vector2[1];
            sumak = vector[2] + vector2[2];
            txtResultado2.Text = Convert.ToString(sumai)+ "i + " + Convert.ToString(sumaj) + "j + " + Convert.ToString(sumak) + "k";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            float sumai = 0;
            float sumaj = 0;
            float sumak = 0;
            cadenausuario = txtVectorU1.Text;
            usuario = cadenausuario.Split(',');
            cadenausuario = txtVectorU2.Text;
            usuario2 = cadenausuario.Split(',');
            for (i = 0; i <= 2; i++)
            {
                vector[i] = Convert.ToSingle(usuario[i]);
                vector2[i] = Convert.ToSingle(usuario2[i]);
            }
            sumai = vector[0] - vector2[0];
            sumaj = vector[1] - vector2[1];
            sumak = vector[2] - vector2[2];
            txtResultado2.Text = Convert.ToString(sumai) + "i + " + Convert.ToString(sumaj) + "j + " + Convert.ToString(sumak) + "k";
        }

        private void btnMultiplicarE_Click(object sender, EventArgs e)
        {
            float suma = 0;
            
            cadenausuario = txtVectorU1.Text;
            usuario = cadenausuario.Split(',');
            cadenausuario = txtVectorU2.Text;
            usuario2 = cadenausuario.Split(',');
            for (i = 0; i <= 2; i++)
            {
                vector[i] = Convert.ToSingle(usuario[i]);
                vector2[i] = Convert.ToSingle(usuario2[i]);
                suma = vector[i] * vector2[i] + suma;
            }
          
            txtResultado2.Text = Convert.ToString(suma);
        }
    }
}
