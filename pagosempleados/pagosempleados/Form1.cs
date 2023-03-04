using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pagosempleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Becario becario1 = new Becario();
        EmpleadoExtras empleado1 = new EmpleadoExtras();
        Gerente gerente1 = new Gerente();
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if( checkBecario.Checked == true)
            {
                becario1.PagarEmpleado();
                MessageBox.Show("Su cantidad en nomina es " + becario1.Salario);
            }
            if (checkGerente.Checked == true)
            {
                gerente1.PagarEmpleado();
                MessageBox.Show("Su cantidad en nomina es " + gerente1.Salario);
            }
            if (checkExtras.Checked == true)
            {
                empleado1.PagarEmpleado();
                MessageBox.Show("Su cantidad en nomina es " + empleado1.Salario);
            }
        }

        private void checkEmpleado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkGerente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBecario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
