using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIRECTORIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Entrada[] directorio = new Entrada[10];
        int numerodeusuario=0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadena;
            int i;
            cadena = txtNombre.Text;
            try
            {
                for (i = 0; i <= directorio.Length; i++)
                {
                 
                    if (string.Equals(directorio[i].Nombre, cadena) == true)
                    {
                        MessageBox.Show("nombre encontrado");
                        txtCelular.Text = directorio[i].Numero;
                    }
                    if (i == directorio.Length)
                    {
                        MessageBox.Show("no se encontro el nombre");
                    }
                }
            }
            catch (Exception y) {
                MessageBox.Show("no se ha registrado ningun usuario");
            }

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre, numero;
            nombre = txtNombre.Text;
            numero = txtCelular.Text;
            directorio[numerodeusuario] = new Entrada(nombre, numero);
            MessageBox.Show("el numero se guardo exitosamente");
            numerodeusuario = numerodeusuario + 1;
        }
    }
}
