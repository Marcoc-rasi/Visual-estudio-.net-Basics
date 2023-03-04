using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManejadorArchivos
{
    public partial class frmPrincipal : Form
    {
        //Declaracion del objeto tipo FileStream
        FileStream Archivo;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Declara e inicializa el dato a escribir
            byte dato = 65;

            //Crea un objeto FileStream con la ruta, modo de apertura y modo de acceso
            Archivo = new FileStream("Dato.txt", FileMode.Create, FileAccess.Write);

            //Escribe el primer byte del archivo
            Archivo.WriteByte(dato);

            //Cierra el archivo
            Archivo.Close();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Declara e inicializa el dato a leer
            int DatoLeído = 0;

            //Crea un objeto FileStream con la ruta, modo de apertura y modo de acceso
            Archivo = new FileStream("Dato.txt", FileMode.Open, FileAccess.Read);

            //Leer el primer byte del archivo
            DatoLeído = Archivo.ReadByte();

            //Cierra el archivo
            Archivo.Close();

            //Escribe el dato leído en la etiqueta
            lblLeído.Text = Convert.ToString(DatoLeído);
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            //Declara e inicializa el dato a escribir
            byte[] datos = { 65, 66, 67, 68, 69, 70 };

            //Crea un objeto FileStream con la ruta, modo de apertura y modo de acceso
            Archivo = new FileStream("Datos.txt", FileMode.Create, FileAccess.Write);

            //Escribe 6 bytes en el archivo
            Archivo.Write(datos, 0, 6);

            //Cierra el archivo
            Archivo.Close();
        }

        private void btnLeer2_Click(object sender, EventArgs e)
        {
            //Declara e inicializa el dato a leer
            byte[] DatosLeídos = new byte[6];

            //Crea un objeto FileStream con la ruta, modo de apertura y modo de acceso
            Archivo = new FileStream("Datos.txt", FileMode.Open, FileAccess.Read);

            //Lee los primeros 6 bytes del archivo
            Archivo.Read(DatosLeídos, 0, 6);

            //Cierra el archivo
            Archivo.Close();

            //Escribe el dato leído en la etiqueta
            lblLeído2.Text = "";
            foreach (byte Dato in DatosLeídos)
                lblLeído2.Text += Convert.ToString(Dato);
        }

        private void btnGuardar3_Click(object sender, EventArgs e)
        {
            //Crea el objeto para escribir en un archivo
            StreamWriter Escribir = new StreamWriter("Tabla.csv");

            //Ciclo para escribir cadenas de texto con 2 numeros separados por una coma
            //en cada fila 
            for (int i = 0; i < 15; i += 2)
                Escribir.WriteLine(Convert.ToString(i) + "," + Convert.ToString(i + 1));

            //Cierra el archivo
            Escribir.Close();
        }

        private void btnLeer3_Click(object sender, EventArgs e)
        {
            //Crea el objeto para leer un archivo
            StreamReader Leer = new StreamReader("Tabla.csv");

            //Escribe los datos leídos en la etiqueta
            lblLeído3.Text = Leer.ReadToEnd();

            //Cierra el archivo
            Leer.Close();
        }

        private void btnGuardar4_Click(object sender, EventArgs e)
        {
            //Crea el objeto para escribir en un archivo
            StreamWriter Escribir = new StreamWriter(txtNombreArchivo.Text);

            //con escribir mandamos los datos al archivo que ya tenemos
            Escribir.Write(txtDatos.Text);

            //Cierra el archivo
            Escribir.Close();
        }

        private void btnLeer4_Click(object sender, EventArgs e)
        {
            //Crea el objeto para leer un archivo
            StreamReader Leer = new StreamReader(txtNombreArchivo.Text);

            //Escribe los datos leídos en la etiqueta
            lblLeído4.Text = Leer.ReadToEnd();

            //Cierra el archivo
            Leer.Close();
        }
    }
}
