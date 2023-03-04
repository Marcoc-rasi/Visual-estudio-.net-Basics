using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Fraccion
    {
        public int n, d;
        public Fraccion(int num, int den)
        {
            n = num;
            d = den;
        }
        public static Fraccion operator + (Fraccion x, Fraccion y)
        {
            int numerador = x.n*((x.d * y.d)/x.d) + y.n*((x.d * y.d)/y.d);
            int denominador = x.d * y.d;
            Fraccion F1 = new Fraccion(numerador, denominador);
            return F1;
        }
        public static Fraccion operator - (Fraccion x, Fraccion y)
        {
            int numerador = x.n * ((x.d * y.d) / x.d) - y.n * ((x.d * y.d) / y.d);
            int denominador = x.d * y.d;
            Fraccion F1 = new Fraccion(numerador, denominador);
            return F1;
        }
        public static Fraccion operator * (Fraccion x, Fraccion y)
        {
            int numerador = x.n * y.n;
            int denominador = x.d * y.d;
            Fraccion F1 = new Fraccion(numerador, denominador);
            return F1;
        }
        public static Fraccion operator / (Fraccion x, Fraccion y)
        {
            int numerador = x.n * y.d;
            int denominador = x.d * y.n;
            Fraccion F1 = new Fraccion(numerador, denominador);
            return F1;
        }
    }
}
