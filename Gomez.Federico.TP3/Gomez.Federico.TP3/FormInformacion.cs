using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Entidades.TP3;

namespace Gomez.Federico.TP3
{
    public partial class FormInformacion : Form
    {
        private FormaBuscados formBuscados;
        private FormAgregar formAgregar;
        private Cochera cochera;


        public FormInformacion()
        {
            InitializeComponent();
            cochera = new Cochera();
        }


        public void CargarInformacion(string informacion)
        {
            this.rtbInformacion.Text = informacion;
        }
        public void ActualizarInformacion()
        {
            try
            {
                if(this.cochera.Vehiculos.Count != 0)
                {
                    foreach (Vehiculo v in this.cochera.Vehiculos)
                    {
                        this.rtbInformacion.Text += JsonSerializer.Serialize(v);
                    }
                }else
                {
                    this.rtbInformacion.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                this.cochera += vehiculo;
                this.rtbInformacion.Text += JsonSerializer.Serialize(vehiculo);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string RetornarInformacion()
        {
            return this.rtbInformacion.Text;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                formAgregar = new FormAgregar(AgregarVehiculo, EliminarVehiculo, BuscarVehiculo);
                this.formAgregar.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void EliminarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                foreach (Vehiculo v in this.cochera.Vehiculos)
                {
                    if(v == vehiculo)
                    {
                        this.cochera.Vehiculos.Remove(v);
                        this.ActualizarInformacion();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public Vehiculo BuscarVehiculo(string patente)
        {
            try
            {
                foreach (Vehiculo v in this.cochera.Vehiculos)
                {
                    if(v.Patente == patente)
                    {
                        return v;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                formBuscados = new FormaBuscados();
                foreach (Vehiculo v in this.cochera.Vehiculos)
                {
                    if (v.Nombre == this.txtNombreBusqueda.Text)
                    {
                        formBuscados.MostrarVehiculos(v);
                    }
                }
                formBuscados.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //public void ActualizarLista()
        //{
        //    try
        //    {
        //        if (this.rtbInformacion.Text != null)
        //        {
        //            Cochera cocheraAux = new Cochera();
        //            cocheraAux.Vehiculos = JsonSerializer.Deserialize<List<Vehiculo>>(this.rtbInformacion.Text);
        //            this.cochera = cocheraAux;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
