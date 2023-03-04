using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÁrbolesBinarios
{
    public partial class Form1 : Form
    {
        Arbol miArbol = new Arbol();
        Random aleatorio = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorInsercion=0;
            for (int i = 0;i<=10;i++)
            {
                valorInsercion = aleatorio.Next(100);
                textBox4.Text += valorInsercion.ToString() +",";
                miArbol.InsertarNodo(valorInsercion);
            }
            miArbol.AyudantePreorden(miArbol.raiz, textBox1);
            miArbol.AyudantePostOrden(miArbol.raiz, textBox2);
            miArbol.AyudanteInorden(miArbol.raiz, textBox3);
            
        }
    }
}
