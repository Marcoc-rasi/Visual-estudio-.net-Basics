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

namespace DialogosArchivosUriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.FileName = "";
            openFileDialog1.FileName = "";
        }
        StreamWriter SW;
        StreamReader SR;
        private void Abrir_Click(object sender, EventArgs e)
        {//para guardar si el usuario quiere guardar
            if (MessageBox.Show("¿Deseas guardar los cambios?","blog de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SW = new StreamWriter(saveFileDialog1.FileName+".txt");
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
            //Codigo para abrir
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SR = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = SR.ReadToEnd();
                SR.Close();
            }
            saveFileDialog1.FileName = "";
        }

        private void nNuevo_Click(object sender, EventArgs e)
        {
            //para guardar si el usuario quiere guardar
            if (MessageBox.Show("¿Deseas guardar los cambios?", "blog de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
            //limpia el cuadro de texto para el nuevo archivo
            textBox1.Clear();
            saveFileDialog1.FileName = "";
            openFileDialog1.FileName = "";
        }

        private void GuardarComo_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                SW.WriteLine(textBox1.Text);
                SW.Close();
            }
            openFileDialog1.FileName = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName !="")
            {
                SW = new StreamWriter(saveFileDialog1.FileName);
                SW.Write(textBox1.Text);
                SW.Close();
            }
            if (openFileDialog1.FileName != "")
            {
                
                SW = new StreamWriter(openFileDialog1.FileName);
                SW.Write(textBox1.Text);
                SW.Close();
            }
            if(saveFileDialog1.FileName == "" && openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName != "")
            {
                SW = new StreamWriter(saveFileDialog1.FileName);
                SW.Write(textBox1.Text);
                SW.Close();
            }
            if (openFileDialog1.FileName != "")
            {

                SW = new StreamWriter(openFileDialog1.FileName);
                SW.Write(textBox1.Text);
                SW.Close();
            }
            if (saveFileDialog1.FileName == "" && openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
            this.Close();
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comuniquese con el programador");
        }
    }
}
