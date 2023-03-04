using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedianaUriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        mediana medianaUsuario = new mediana();
        public string[] vectortxt;
        public float[] vectornum;
        private void btnMediana_Click(object sender, EventArgs e)
        {
            
            string[] cadena;
            cadena = txtVector.Text.Split(',');
            if (cadena.Length % 2 != 0)
            {
                vectortxt = new string[cadena.Length];
                vectornum = new float[cadena.Length];

                vectortxt = txtVector.Text.Split(',');
                for (int i = 0; i < vectortxt.Length; i++)
                {
                    vectornum[i] = Convert.ToSingle(vectortxt[i]);
                }
                medianaUsuario.calculoMediana(vectornum);
                txtResultado.Text = Convert.ToString(medianaUsuario.medianaVector);
            }
            else
            {
                MessageBox.Show("El vector no es impar");
                //throw (new Exception("El vector no es impar"));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
    }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (medianaUsuario.medianaVector != -1256)
            {
                int resultado;
                resultado = medianaUsuario.Comprueba(medianaUsuario, vectornum);
                if (resultado == 0)
                {
                    MessageBox.Show("La medina es correcta");
                }
                if (resultado == 1)
                {
                    MessageBox.Show("La medina no es correcta");
                }
            }
            else
            {
                MessageBox.Show("No se puede comprobar la mediana si no hay vector");
            }
        }
    }
}
