using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pagosempleados
{
    class Becario:Empleado
    {
        private string puesto = "becario";
        public string Puesto
        {
            get { return puesto; }
        }
        public override void PagarEmpleado()
        {
            Salario = Salario + 500;
        }
    }
}
