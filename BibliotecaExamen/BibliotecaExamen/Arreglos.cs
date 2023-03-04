using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BibliotecaExamen
{
    public class Arreglos
    {
        public int[] GenerarVectorEnteros(TextBox TxtBox)
        {
            //temporal es una cadena que toma todos los valores separados por la ",", en el split, sirve para saber el tamaño del arreglo
            //Se transforman cada uno de sus elementos a entero para guararlos en el vector de enteros
            string[] temporal = TxtBox.Text.Split(',');
            int[] ArregloEnteros = new int[temporal.Length];
            for (int i = 0; i < ArregloEnteros.Length; i++)
            {
                ArregloEnteros[i] = Convert.ToInt32(temporal[i]);
            }
            return ArregloEnteros;
        }
        public void ImprimirVectorEnteros(int[] VectorEnteros,TextBox TxtBox)
        {
            //tomamos el textbox, en el cual vamos a  imprimir el vector
            //ya que el vector son valores separados y enteros, los sacamos uno a uno y los convertimos
            //concatenamos la informacion en una cadena para su impresion
            string temporal =null;
            for( int i = 0; i < VectorEnteros.Length; i++)
            {
                temporal = temporal + Convert.ToString(VectorEnteros[i]);
            }
            TxtBox.Text = temporal;
        }
        public  float[] GenerarVectoresFlotantes(TextBox TxtBox)
        {
            //temporal es una cadena que toma todos los valores separados por la ",", en el split, sirve para saber el tamaño del arreglo
            //Se transforman cada uno de sus elementos a flotante para guararlos en el vector de flotantes
            string[] temporal = TxtBox.Text.Split(',');
            float[] ArregloFlotantes = new float[temporal.Length];
            for (int i = 0; i < ArregloFlotantes.Length; i++)
            {
                ArregloFlotantes[i] = Convert.ToSingle(temporal[i]);
            }
            return ArregloFlotantes;
        }
        public void ImprimirVectorFlotantes(float[] VectorFlotantes, TextBox TxtBox)
        {
            //tomamos el textbox, en el cual vamos a imprimir el vector
            //ya que el vector son valores separados y flotantes, los sacamos uno a uno y los convertimos
            //concatenamos la informacion en una cadena para su impresion
            string temporal = null;
            for (int i = 0; i < VectorFlotantes.Length; i++)
            {
                temporal = temporal + Convert.ToString(VectorFlotantes[i]);
            }
            TxtBox.Text = temporal;
        }
        public string[] GenerarVectoresCadenas(TextBox TxtBox)
        {
            //temporal es una cadena que toma todos los valores separados por la ",", en el split, sirve para saber el tamaño del arreglo
            //Se transforman cada uno de sus elementos a string para guararlos en el vector de strings
            string[] temporal = TxtBox.Text.Split(',');
            string[] ArregloString = new string[temporal.Length];
            for (int i = 0; i < ArregloString.Length; i++)
            {
                ArregloString[i] = temporal[i];
            }
            return ArregloString;
        }
        public void ImprimirVectorCadenas(string[] VectorCadenas, TextBox TxtBox)
        {
            //tomamos el textbox, en el cual vamos a imprimir el vector
            //ya que el vector son valores separados y flotantes, los sacamos uno a uno y los convertimos
            //concatenamos la informacion en una cadena para su impresion
            string temporal = null;
            for (int i = 0; i < VectorCadenas.Length; i++)
            {
                temporal = temporal + VectorCadenas[i] + "\n";
            }
            TxtBox.Text = temporal;
        }
        public int[][] GenetrizMatriz2DEnteros(TextBox txtBox)
        {
            //indicamos que los numeros se leeran como una cadena separada por comas
            //se separa la cadena por las comas y se guardan cada uno de los valores
            //Insertamos los valores separados convertidos a entero, en la matriz de enteros
            MessageBox.Show("Introduce los cuatro digitos seguidos de una coma ejemplo \n x1,y1,x2,y2");
            string[] temporal = new string[4];
            temporal = txtBox.Text.Split(',');
            int[][] MatrizEnteros = new int[2][];
            MatrizEnteros[0][0] = Convert.ToInt32(temporal[0]);
            MatrizEnteros[0][1] = Convert.ToInt32(temporal[1]);
            MatrizEnteros[1][0] = Convert.ToInt32(temporal[2]);
            MatrizEnteros[1][1] = Convert.ToInt32(temporal[3]);
            return MatrizEnteros;
        }
        public void ImprimirMatriz2DEnteros(string[][] MatrizEnteros,TextBox TxtBox)
        {
            //Almacenaremos la frase en una cadena
            //Los valores se insertan en la cadena separados por un espacio entre columnas, y un espacio entre renglones
            //te manda al textBox indicado los valores imprimir
            string cadena = null;
            for(int i=0;i< 2; i++)
            {
                for(int e = 0; e < 2; e++)
                {
                    cadena = cadena + MatrizEnteros[i][e] + "  ";
                }
                cadena = cadena + "\n";
            }
            TxtBox.Text = cadena;
        }
        public float[][] GenetrizMatriz2DFlotantes(TextBox txtBox)
        {
            //indicamos que los numeros se leeran como una cadena separada por comas
            //se separa la cadena por las comas y se guardan cada uno de los valores
            //Insertamos los valores separados convertidos a flotante, en la matriz de flotantes
            MessageBox.Show("Introduce los cuatro digitos seguidos de una coma ejemplo \n x1,y1,x2,y2");
            string[] temporal = new string[4];
            temporal = txtBox.Text.Split(',');
            float[][] MatrizFlotantes = new float[2][];
            MatrizFlotantes[0][0] = Convert.ToSingle(temporal[0]);
            MatrizFlotantes[0][1] = Convert.ToSingle(temporal[1]);
            MatrizFlotantes[1][0] = Convert.ToSingle(temporal[2]);
            MatrizFlotantes[1][1] = Convert.ToSingle(temporal[3]);
            return MatrizFlotantes;
        }
        public void ImprimirMatriz2DFlotantes(string[][] MatrizFlotantes, TextBox TxtBox)
        {
            //Almacenaremos la frase en una cadena
            //Los valores se insertan en la cadena separados por un espacio entre columnas, y un espacio entre renglones
            //te manda al textBox indicado los valores imprimir
            string cadena = null;
            for (int i = 0; i < 2; i++)
            {
                for (int e = 0; e < 2; e++)
                {
                    cadena = cadena + MatrizFlotantes[i][e] + "  ";
                }
                cadena = cadena + "\n";
            }
            TxtBox.Text = cadena;
        }
    }

}
