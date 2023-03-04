using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplopolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vaca vaca1 = new Vaca();
        perro perro1 = new perro();
        Gato1 gato2 = new Gato1();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVaca_Click(object sender, EventArgs e)
        {
            string frase;
            frase = vaca1.dice();
            textBox1.Text = frase;

        }

        private void btnPerro_Click(object sender, EventArgs e)
        {
            string frase;
            frase = perro1.dice();
            textBox1.Text = frase;
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            string frase;
            frase = gato2.dice();
            textBox1.Text = frase;
        }
    }
}
