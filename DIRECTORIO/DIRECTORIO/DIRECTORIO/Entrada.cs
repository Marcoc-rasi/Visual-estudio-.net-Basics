using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRECTORIO
{
    class Entrada
    {
        string nombre;
        string numero;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public Entrada(string b,string a)
        {
            Nombre = b;
            Numero = a;
        }
    }
}
