using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListasBibliotecaUriel;

namespace ListaUriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ListaEnlazada lista = new ListaEnlazada();
        public Cola cola = new Cola();
        public Pila pila = new Pila();
        public NodoLista nodo = new NodoLista();
        private void btnEliminarInicioLista_Click(object sender, EventArgs e)
        {
            nodo = lista.EliminarElementoAlInicio();
            txtEliminadoLista.Text = Convert.ToString(nodo.Datos);
        }

        private void btnEliminarFinalLista_Click(object sender, EventArgs e)
        {
            nodo = lista.EliminarElementoAlFinal();
            txtEliminadoLista.Text = Convert.ToString(nodo.Datos);
        }

        private void btnInsertarInicioLista_Click(object sender, EventArgs e)
        {
            nodo.Datos = txtLista.Text;
            lista.InsertarElementoAlInicio(nodo);
        }

        private void btnInsertarFinalLista_Click(object sender, EventArgs e)
        {
            nodo.Datos = txtLista.Text;
            lista.InsertarElementoAlFinal(nodo);
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            nodo.Datos = txtPila.Text;
            pila.Push(nodo);
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            nodo.Datos = txtPila.Text;
            pila.Pop();
            txtEliminadoPila.Text = Convert.ToString(nodo.Datos);
        }

        private void btnInsertarCola_Click(object sender, EventArgs e)
        {
            nodo.Datos = txtCola.Text;
            cola.InsertarElemento(nodo);
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            nodo = cola.EliminarElemento();
            txtEliminadoCola.Text = Convert.ToString(nodo.Datos);
        }
    }
}
