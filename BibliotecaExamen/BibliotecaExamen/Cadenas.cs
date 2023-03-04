using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaExamen
{
    class Cadenas
    {
        public void ImprimirCadenaDesdeTextBox(TextBox TxtBox, string cadena)
        {
            //recibe una cadena a imprimir en un textBox
            TxtBox.Text = cadena;
        }
        public bool VerificarCadenaVacia(string cadena)
        {
            //Manda un mensaje si la cadena es vacia o no
            // regresa un valor bool para sabes el resultado
            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("La cadena esta vacia");
                return true;
            }
            else
            {
                MessageBox.Show("La cadena no esta vacia");
                return false;
            }
        }
        public void DatosAutor()
        {
            //imprime los datos del programador
            MessageBox.Show("Marcos Uriel Martinez Ortiz \n\r Ing. Mecatronica\n\r ");
        }
    }
}
