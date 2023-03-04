using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class NumComplejo
    {
        public float r, c;
        public NumComplejo(float num1, float num2)
        {
            r = num1;
            c = num2;
        }
        public static NumComplejo operator + (NumComplejo x,NumComplejo y)
        {
            float real = x.r + y.r;
            float complejo = x.c + y.c;
            NumComplejo F1 = new NumComplejo(real, complejo);
            return F1;
        }
        public static NumComplejo operator - (NumComplejo x, NumComplejo y)
        {
            float real = x.r - y.r;
            float complejo = x.c - y.c;
            NumComplejo F1 = new NumComplejo(real, complejo);
            return F1;
        }
        public static NumComplejo operator * (NumComplejo x, NumComplejo y)
        {
            float real = x.r * y.r + (x.c*y.c)*-1;
            float complejo = x.r*y.c + x.c*y.r;
            NumComplejo F1 = new NumComplejo(real, complejo);
            return F1;
        }
        public static NumComplejo operator / (NumComplejo x, NumComplejo y)
        {
            float denominador = y.r * y.r + y.c * y.c;
            float real = x.r * y.r + (x.c * y.c) * -1;
            float complejo = x.r * y.c + x.c * y.r;
            float real2 = real * y.r + (complejo * (y.c) * -1) * -1;
            float complejo2 = real * (y.c * -1) + complejo * y.r;
            NumComplejo F1 = new NumComplejo(real2/denominador, complejo2/denominador);
            return F1;
        }
    }
}
