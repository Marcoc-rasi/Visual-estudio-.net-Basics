using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ListasBibliotecaUriel
{
    public class ListaEnlazada
    {
        private NodoLista head = null;
        private NodoLista Last = null;
        private NodoLista Aux = null;

        public void InsertarElementoAlFinal(NodoLista Elemento)
        {
            if(head == null && Last == null)
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
        public void InsertarElementoAlInicio(NodoLista Elemento)
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
                Elemento.Siguiente = head;
                head = Elemento;
            }
        }
        public NodoLista EliminarElementoAlFinal()
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
        public NodoLista EliminarElementoAlInicio()
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
