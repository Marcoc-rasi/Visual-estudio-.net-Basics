using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolesBinarios
{
    class NodoArbol
    {
        public NodoArbol nodoIzquierdo;
        public int datos;
        public NodoArbol nodoDerecho;

        //Inicializa el nodo como hoja
        public NodoArbol(int datosNodo)
        {
            datos = datosNodo;
            nodoIzquierdo = nodoDerecho = null;
        }

        //Insertar nodos en el árbol que ya tiene nodos
        public void Insertar(int valorInsercion)
        {
            if (valorInsercion < datos)
            {
                if (nodoIzquierdo == null)
                {
                    nodoIzquierdo = new NodoArbol(valorInsercion);
                }
                else
                {
                    nodoIzquierdo.Insertar(valorInsercion);
                }
            }
            else if (valorInsercion > datos)
            {
                if (nodoDerecho == null)
                {
                    nodoDerecho = new NodoArbol(valorInsercion);
                }
                else
                    nodoDerecho.Insertar(valorInsercion);
            }
            
        }
    }
}
