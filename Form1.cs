using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;
        Form2 f2;
        bool modal;

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Selección de directorio para almacenar datos";
            this.openFileDialog1.Filter = "imagenes (*.jpg, *.png)|*.jpg;*.png|Todos los archivos (*.*)|*.*";
            this.openFileDialog1.ValidateNames = true;
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                path = openFileDialog1.FileName;
                
                f2= new Form2(path, modal);
                f2.Text = openFileDialog1.SafeFileName;

                if (checkBox1.Checked)
                {
                    f2.ShowDialog();
                } else
                {
                    f2.Show();
                }
            }

        }

        private void CerrarFormulario(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.Red;
            }
            else
            {
                checkBox1.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
