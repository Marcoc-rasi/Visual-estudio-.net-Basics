using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasBibliotecaUriel
{
    public class Cola
    {
        private NodoLista head = null;
        private NodoLista Last = null;
        private NodoLista Aux = null;

        public void InsertarElemento(NodoLista Elemento)
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
        public NodoLista EliminarElemento()
        {
            if (head != null)
            {
                if (head.Siguiente != null)
                {
                    Aux = head;
                    NodoLista eliminado;
                    eliminado = Aux;
                    head = Aux.Siguiente;
                    eliminado.Siguiente = null;
                    return eliminado;
                }
                else
                {
                    NodoLista eliminado;
                    eliminado = head;
                    head = null;
                    Last = null;
                    return eliminado;
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar elementos, la lista esta vacia");
                return null;
            }
        }
    }
}
