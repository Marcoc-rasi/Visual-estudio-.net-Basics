using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasBibliotecaUriel
{
    public class NodoLista
    {
        private object datos;
        private NodoLista siguiente;
        public object Datos
        {
            get
            {
                return datos;
            }
            set
            {
                datos = value;
            }
        }
        public NodoLista Siguiente
        {
            get
            {
                return siguiente;
            }
            set
            {
                siguiente = value;
            }
        }
    }
}
