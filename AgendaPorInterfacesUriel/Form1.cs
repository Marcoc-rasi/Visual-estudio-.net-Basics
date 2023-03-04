using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaPorInterfacesUriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contacto> lista = new List<Contacto>(); 
        public int BusquedBinaria(List<Contacto> lista, int n, string clave)
        {
            int central, bajo, alto;
            string valorCentral;

            bajo = 0;
            alto = n -1;
            while (bajo <= alto)
            {
                central = (bajo + alto) / 2;
                valorCentral = lista[central].nombre;
                if (clave == valorCentral)
                {
                    return central;
                }
                else
                {
                    if(valorCentral.CompareTo(clave)>1)
                    {
                        alto = central - 1;
                    }
                    else
                    {
                        bajo = central + 1;
                    }
                }
            }
            return -1;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNumero.Text == "") {
                MessageBox.Show("No se puede agregar el contato, revise los campos incompletos");
            }
            else
            {
                lista.Add(new Contacto(txtNombre.Text, txtNumero.Text));
                txtNombre.Clear();
                txtNumero.Clear();
                //siempre que se agrege un nuevo elemento a la lista se ordenara la lista
                lista.Sort();
            }
            
        }

        private void BtnDesplegarContactos_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                txtListaContactos.Clear();
                txtListaContactos.Text = "No hay ningun contacto en la agenda";
            }
            else
            {
                txtListaContactos.Clear();
                foreach(var elemento in lista)
                {
                    txtListaContactos.Text += elemento.nombre +" "+ elemento.numero + "\n\t";
                }
                
            }
        }

        private void BtnBuscarContacto_Click(object sender, EventArgs e)
        {
            if(lista.Count == 0)
            {
                txtListaContactos.Clear();
                txtListaContactos.Text = "No hay ningun contacto en la agenda";
            }
            else
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("No podemos hacer una busqueda sin nombre");
                }
                else
                {
                    var encontrado = BusquedBinaria(lista, lista.Count, txtNombre.Text);
                    if (encontrado == -1)
                    {
                        MessageBox.Show("No se encontro el contacto");
                    }
                    else
                    {
                        txtListaContactos.Clear();
                        txtListaContactos.Text = lista[encontrado].nombre + "  " + lista[encontrado].numero;
                    }
                }
            }
        }
    }
}
