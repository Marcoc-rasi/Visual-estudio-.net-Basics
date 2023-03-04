using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÁrbolesBinarios
{
    class Arbol
    {
        public NodoArbol raiz;
        
        public Arbol()
        {
            raiz = null;
        }

        public void InsertarNodo(int valor)
        {
            if(raiz==null)
            {
                raiz = new NodoArbol(valor);
            }
            else
            {
                raiz.Insertar(valor);
            }
        }

        /*public void RecorridoPreorden(TextBox T1)
        {
            AyudantePreorden(raiz, T1);
        }*/

        //Método recursivo
        public void AyudantePreorden(NodoArbol nodo, TextBox T1)
        {
            if (nodo == null) return;
            T1.Text += Convert.ToString(nodo.datos + " ");
            AyudantePreorden(nodo.nodoIzquierdo, T1);
            AyudantePreorden(nodo.nodoDerecho, T1);
        }

        public void AyudanteInorden(NodoArbol nodo,TextBox T1)
        {
            if (nodo == null) return;
            AyudanteInorden(nodo.nodoIzquierdo, T1);
            T1.Text += Convert.ToString(nodo.datos + " ");
            AyudanteInorden(nodo.nodoDerecho, T1);
        }

        public void AyudantePostOrden(NodoArbol nodo, TextBox T1)
        {
            if (nodo == null) return;
            AyudantePostOrden(nodo.nodoIzquierdo, T1);
            AyudantePostOrden(nodo.nodoDerecho, T1);
            T1.Text += Convert.ToString(nodo.datos+" ");
        }
    }
}
