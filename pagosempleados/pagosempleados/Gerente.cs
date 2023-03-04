using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pagosempleados
{
    class Gerente:Empleado
    {
        private string puesto = "Gerente";
        public string Puesto
        {
            get { return puesto; }
        }
        public override void PagarEmpleado()
        {
            Salario = Salario + 3000;
        }
    }
}
