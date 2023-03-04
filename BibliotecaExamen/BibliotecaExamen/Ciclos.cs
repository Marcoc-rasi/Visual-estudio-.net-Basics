using System;
namespace BibliotecaExamen
{
    public class Ciclos
    {
        public float SumarVector(float [] Vector)
        {
            //este metodo recibe un vector a sumar
            //la variable s toma el valor de cada uno de los elementos del arreglo y los suma
            float suma = 0;
            foreach (float s in Vector)
            {
                suma += s;
            }
            return suma;
        }

        public float MultiplicarVector(float [] Vector)
        {
            //este metodo recibe el vertor que va a multiplicar
            // la variable e toma el valor de cada elemento en el vector para multiplicarlo cada vez que entra al ciclo
            // la variable multi, empieza en uno para que se pueda multiplicar por la siguiente entrada
            float mult = 1;
            foreach(float e in Vector)
            {
                mult *= e;
            }
            return mult;
        }

        public float SumarMatriz(float [][] Matriz)
        {
            //la matriz tiene un numero indefinido de renglones, y columnas
            //la variable i toma los renglones completos sin importar las columnas
            //la variable a pasa por cada elemento del renglon guardado en i y lo suma
            //cuando los ciclos acaban la variable i cambia de renglon
            float suma = 0;
            foreach(float[] i in Matriz)
            {
                foreach(float a in i)
                {
                    suma += a;
                }
            }
            return suma;
        }

        public int Fibonacci(int n)
        {
            //la SERIE SUMA LOS DOS NUMEROS ANTERIORES PARA OBTENER EL SIGUIENTE VALOS
            //LS OPERACINO ES SENCILLA CON UN VECTOR DE DOS POSICIONES, QUE SON LAS QUE SE SUMAN,
            //SE SUMAN LOS NUMEROS Y SE MODIFICA EL ARREGLO HASTA LLEGAR AL NUMERO SE LA SERIE QUE DESEAMOS
            if (n == 1)
            {
                return 0;
            }
            else
            {
                int [] fib = {0,1};
                for (int i = 2; i < n; i++)
                {
                    fib[1] = fib[1] + fib[0];
                    fib[0] = fib[1] - fib[0];
                }
                return fib[1];
            }
        }

        public int Factorial(int n)
        {
            //El numero de iteraciones va a ser igual que el numero que metammos
            //el factorial se multiplica por si mismo mientras la variable que guarda el numero se disminuye
            //cuando llegue a uno la multiplicacino es no necesaria, y cesamos el ciclo
            int factorial = 1;
            for(int i=n;i>1;i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        public float Potencia(float n, int potencia)
        {
            //se multiplica el numero por si mismo
            //hasta que el contador i llegue al numero de potencia que se pidio
            float p=1;
            int i = 0;
            do
            {
                p *= n;
                i++;

            } while (potencia>i);
            return p;
        }

        public string Mayusculas(string s)
        {
            //la funcion tochararray convierte la cadena en texto unicode a a la cadena de caracteres Frase
            //Se iguala c a cada caracter en el areglo y si es texto de hace mayuscula
            //se retorna el valor del arreglo en forma de cadena
            char[] Frase = s.ToCharArray();
            int i = 0;
            foreach(char c in Frase)
            {
                if(c>='a' && c<='z')
                {
                    Frase[i] = (char)(Frase[i] - 32);
                }
                i++;
            }
            return new string(Frase);
        }

        public string Minusculas(string s)
        {
            //la funcion tochararray convierte la cadena en texto unicode a a la cadena de caracteres Frase
            //Se iguala c a cada caracter en el areglo y si es texto de hace minusculas
            //se retorna el valor del arreglo en forma de cadena
            char[] Frase = s.ToCharArray();
            int i = 0;
            foreach (char c in Frase)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    Frase[i] = (char)(Frase[i] + 32);
                }
                i++;
            }
            return new string(Frase);
        }


    }
}
