using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Fraccion f1, f2, f3;
        int n1, n2, d1, d2;
        NumComplejo numc1, numc2, numc3;
        float r1, r2, c1, c2;
        public int convertir(TextBox t1)
        {
            int num;
            string s = t1.Text;
            num = Convert.ToInt32(s);
            return num;
        }
        public float convertir2(TextBox t2)
        {
            float num;
            string s = t2.Text;
            num = Convert.ToSingle(s);
            return num;
        }
        private void btnDivisionC_Click(object sender, EventArgs e)
        {
            r1 = convertir2(txtR1);
            r2 = convertir2(txtR2);
            c1 = convertir2(txtC1);
            c2 = convertir2(txtC2);
            numc1 = new NumComplejo(r1, c1);
            numc2 = new NumComplejo(r2, c2);
            numc3 = numc1 / numc2;
            txtOp2.Text = "/";
            txtR3.Text = Convert.ToString(numc3.r);
            txtC3.Text = Convert.ToString(numc3.c);
        }

        
        private void btnMultiplicacionC_Click(object sender, EventArgs e)
        {
            r1 = convertir2(txtR1);
            r2 = convertir2(txtR2);
            c1 = convertir2(txtC1);
            c2 = convertir2(txtC2);
            numc1 = new NumComplejo(r1, c1);
            numc2 = new NumComplejo(r2, c2);
            numc3 = numc1 * numc2;
            txtOp2.Text = "*";
            txtR3.Text = Convert.ToString(numc3.r);
            txtC3.Text = Convert.ToString(numc3.c);
        }

       
        private void btnRestaC_Click(object sender, EventArgs e)
        {
            r1 = convertir2(txtR1);
            r2 = convertir2(txtR2);
            c1 = convertir2(txtC1);
            c2 = convertir2(txtC2);
            numc1 = new NumComplejo(r1, c1);
            numc2 = new NumComplejo(r2, c2);
            numc3 = numc1 - numc2;
            txtOp2.Text = "-";
            txtR3.Text = Convert.ToString(numc3.r);
            txtC3.Text = Convert.ToString(numc3.c);
        }

        
        private void btnSumaC_Click(object sender, EventArgs e)
        {
            r1 = convertir2(txtR1);
            r2 = convertir2(txtR2);
            c1 = convertir2(txtC1);
            c2 = convertir2(txtC2);
            numc1 = new NumComplejo(r1, c1);
            numc2 = new NumComplejo(r2, c2);
            numc3 = numc1 + numc2;
            txtOp2.Text = "+";
            txtR3.Text = Convert.ToString(numc3.r);
            txtC3.Text = Convert.ToString(numc3.c);
        }

        private void txtOp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
        
        private void button4_Click(object sender, EventArgs e)
        {
            n1 = convertir(txtN1);
            n2 = convertir(txtN2);
            d1 = convertir(txtD1);
            d2 = convertir(txtD2);
            txtOp.Text = "/";
            f1 = new Fraccion(n1, d1);
            f2 = new Fraccion(n2, d2);
            f3 = f1 / f2;
            txtN3.Text = Convert.ToString(f3.n);
            txtD3.Text = Convert.ToString(f3.d);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            n1 = convertir(txtN1);
            n2 = convertir(txtN2);
            d1 = convertir(txtD1);
            d2 = convertir(txtD2);
            txtOp.Text = "*";
            f1 = new Fraccion(n1, d1);
            f2 = new Fraccion(n2, d2);
            f3 = f1 * f2;
            txtN3.Text = Convert.ToString(f3.n);
            txtD3.Text = Convert.ToString(f3.d);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            n1 = convertir(txtN1);
            n2 = convertir(txtN2);
            d1 = convertir(txtD1);
            d2 = convertir(txtD2);
            txtOp.Text = "-";
            f1 = new Fraccion(n1, d1);
            f2 = new Fraccion(n2, d2);
            f3 = f1 - f2;
            txtN3.Text = Convert.ToString(f3.n);
            txtD3.Text = Convert.ToString(f3.d);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            n1 = convertir(txtN1);
            n2 = convertir(txtN2);
            d1 = convertir(txtD1);
            d2 = convertir(txtD2);
            txtOp.Text = "+";
            f1 = new Fraccion(n1, d1);
            f2 = new Fraccion(n2, d2);
            f3 = f1 + f2;
            txtN3.Text = Convert.ToString(f3.n);
            txtD3.Text = Convert.ToString(f3.d);
        }
        

    }
}
