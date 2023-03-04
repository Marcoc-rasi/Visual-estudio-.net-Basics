using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pagosempleados
{
    class Empleado
    {
        string nombre, apellido;
        float salario;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public virtual void PagarEmpleado()
        {
            Salario = Salario + 1500;
        }
    }
}
