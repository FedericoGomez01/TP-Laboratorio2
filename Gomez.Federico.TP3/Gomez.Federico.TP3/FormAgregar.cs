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
    public partial class FormAgregar : Form
    {
        public delegate void AgregarVehiculo(Vehiculo vehiculo);
        private AgregarVehiculo agregarVehiculo;

        public delegate void EliminarVehiculo(Vehiculo vehiculo);
        private EliminarVehiculo eliminarVehiculo;

        public delegate Vehiculo BuscarVehiculo(string vehiculoPatente);
        private BuscarVehiculo buscarVehiculo;

        private Vehiculo vehiculo;
        private FormInformacion formInformacion;
        
        public FormAgregar() 
        {
            InitializeComponent();
        }
        public FormAgregar(AgregarVehiculo agregarVehiculo, EliminarVehiculo eliminarVehiculo, BuscarVehiculo buscarVehiculo)
            :this()
        {
            this.agregarVehiculo = agregarVehiculo;
            this.eliminarVehiculo = eliminarVehiculo;
            this.buscarVehiculo = buscarVehiculo;
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                vehiculo = new Vehiculo(txtNombre.Text, txtPatente.Text, int.Parse(txtAnio.Text), txtCategotia.Text);
                agregarVehiculo.Invoke(vehiculo);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = JsonSerializer.Deserialize<Vehiculo>(this.rtbEliminar.Text);
                eliminarVehiculo.Invoke(vehiculo);
                MessageBox.Show("Se elimino correctamente el vehiculo", "Eliminacion exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = buscarVehiculo.Invoke(this.txtPatenteEliminar.Text);
                this.rtbEliminar.Text =  JsonSerializer.Serialize(vehiculo);
             }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
