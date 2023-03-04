using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasBibliotecaUriel
{
    public class Pila
    {
        private NodoLista head = null;
        private NodoLista Last = null;
        private NodoLista Aux = null;
        public NodoLista Pop()
        {
            if (head != null)
            {
                Aux = head;
                NodoLista Eliminado;
                while (Aux.Siguiente != null)
                {
                    if (Aux.Siguiente.Siguiente != null)
                    {
                        Aux = Aux.Siguiente;
                    }
                }
                if (head.Siguiente != null)
                {
                    Eliminado = Aux.Siguiente;
                    Aux.Siguiente = null;
                    Last = Aux;
                    return Eliminado;
                }
                else
                {
                    Eliminado = Aux;
                    head = null;
                    Last = null;
                    return Eliminado;
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar elementos, la lista esta vacia");
                return null;
            }
        }
        public void Push(NodoLista Elemento)
        {
            if (head == null && Last == null)
            {
                head = Elemento;
                head.Siguiente = null;
                Last = Elemento;
                Last.Siguiente = null;
            }
            else
            {
                Aux = Elemento;
                Last.Siguiente = Aux;
                Last = Aux;
                Last.Siguiente = null;
            }
        }
    }
}
