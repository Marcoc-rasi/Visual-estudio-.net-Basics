using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPorInterfacesUriel
{
    public class Contacto: IComparable<Contacto>
    {
        public string nombre;
        public string numero;
        public Contacto(string name, string number)
        {
            nombre = name;
            numero = number;
        }
        public int CompareTo(Contacto miContacto)
        {
            //Si el salario es igual, ordene el nombre por orden alfabetico [a to z]
            if (nombre == miContacto.nombre)
            {
                return numero.CompareTo(miContacto.numero);
            }
            //si no es igual, ordene el salario de mayor a menor
            return miContacto.nombre.CompareTo(nombre);
        }
    }
}
