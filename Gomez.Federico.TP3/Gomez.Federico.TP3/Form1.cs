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
using Entidades.TP3;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gomez.Federico.TP3
{
    
    public partial class Form1MiCochera : Form
    {
        private FormInformacion formInformacion;
        private string path;

        public Form1MiCochera()
        {
            InitializeComponent();
        }

        private void tsmAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = " |*.txt";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.path = archivo.FileName;
                    formInformacion = new FormInformacion();
                    GestorDeArchivos gda = new GestorDeArchivos(this.path); ;
                    formInformacion.Show();
                    formInformacion.CargarInformacion(gda.Leer());
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(this.path, formInformacion.RetornarInformacion());
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
