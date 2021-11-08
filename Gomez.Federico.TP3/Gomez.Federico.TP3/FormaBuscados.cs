using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.TP3;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gomez.Federico.TP3
{
    public partial class FormaBuscados : Form
    {
        private FormInformacion formInformacion;


        public FormaBuscados()
        {
            InitializeComponent();
            formInformacion = new FormInformacion();
        }

        public void MostrarVehiculos(Vehiculo vehiculo)
        {
            try
            {
                this.lblNombre.Text += vehiculo.Nombre;
                this.rtbBuscados.Text += JsonSerializer.Serialize(vehiculo);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
