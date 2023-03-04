using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfasUriel
{
    class Empleado:IComparable<Empleado>
    {
        public int salario;
        public string nombre;

        public int CompareTo(Empleado otro)
        {
            //Si el salario es igual, ordene el nombre por orden alfabetico [a to z]
            if (salario == otro.salario)
            {
                return nombre.CompareTo(otro.nombre);
            }
            //si no es igual, ordene el salario de mayor a menor
            return otro.salario.CompareTo(salario);
        }
        public override string ToString()
        {
            return salario.ToString() + "," + nombre;
        }
        public Empleado(string N, int S)
        {
            nombre = N;
            salario = S;
        }
    }
}
