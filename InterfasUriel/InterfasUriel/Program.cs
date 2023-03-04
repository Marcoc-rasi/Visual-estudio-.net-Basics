using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfasUriel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> lista = new List<Empleado>();
            lista.Add(new Empleado("Juana", 10000));
            lista.Add(new Empleado("Mario", 10000));
            lista.Add(new Empleado("Julian", 10000));
            lista.Add(new Empleado("Rocio", 10000));
            lista.Add(new Empleado("Lucia", 10000));

            // Uses IComparable.CompareTo()
            lista.Sort();

            //Uses Emplooye.ToString
            foreach(var element in lista)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }


}
