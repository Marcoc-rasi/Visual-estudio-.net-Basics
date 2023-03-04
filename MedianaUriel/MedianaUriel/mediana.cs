using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianaUriel
{
    class mediana
    {
        public mediana() { }
        public float medianaVector=-1256;
     public void calculoMediana(float[] vector)
        {
            float auxili;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                auxili = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > auxili)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = auxili;
            }
           
            medianaVector = vector[Convert.ToInt32((vector.Length)/2)];
        }
     public int Comprueba(mediana medianaU, float[] vector)
        {
            int bandera=0;
            for (int i = 0; i < vector.Length; i++)
            {
                if(i < vector.Length / 2)
                {
                    if (vector[i] > medianaU.medianaVector)
                    {
                        bandera = 1;
                    }
                }
                if(i > vector.Length / 2)
                {
                    if (vector[i] < medianaU.medianaVector)
                    {
                        bandera = 1;
                    }
                }
                
            }
            return bandera;
            
        }
    }
}
