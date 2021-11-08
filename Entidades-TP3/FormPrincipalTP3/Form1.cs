using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_TP3;
using System.IO;

namespace FormPrincipalTP3
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\Santiago\source\repos\Entidades-TP3\InformacionVotantes.txt";
        private Votante votante;
        private List<Votante> votantes;
        public Form1()
        {
            InitializeComponent();
            votantes = new List<Votante>();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnVerResultados.Enabled = false;
            this.rtbInformacion.ReadOnly = true;
            
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {

        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            try
            {
                FormVotacion votacion = new FormVotacion();
                votacion.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal!");
            }
        }

        private void btnImportarArchivos_Click(object sender, EventArgs e)
        {
            try
            {
                string auxInformacion = string.Empty;
                this.rtbInformacion.Text = this.LeerArchivo();
                this.btnVerResultados.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() , "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExportarArchivos_Click(object sender, EventArgs e)
        {
            this.EscribirArchivo();
        }

        private void AgregarInformacion(string informacion)
        {
            try
            {
                if (informacion != null)
                {
                    string aux = this.rtbInformacion.Text + informacion;
                    this.rtbInformacion.Clear();
                    this.rtbInformacion.Text = aux;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener la informacion");
            }
        }

        private void EscribirArchivo()
        {
            if(this.rtbInformacion.Text != null)
            {
                GestorDeArchivos gda = new GestorDeArchivos(this.path);
                gda.GuardadArchivo(this.rtbInformacion.Text);
            }
        }

        private string LeerArchivo()
        {
            string auxInfoArchivo = string.Empty;
            try
            {
                if (this.rtbInformacion != null)
                {
                    GestorDeArchivos gda = new GestorDeArchivos(this.path);
                    auxInfoArchivo = gda.CargarArchivo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return auxInfoArchivo;
        }

        public void AgregarUnVotante(string nombre, short edad, Votante.Sexos sexo,string  pais, Votante.Escuderias escuderia)
        {
            try
            {
                this.votante = new Votante(nombre, edad, sexo, pais, escuderia);
                //bool estaEnLista = false;
                this.votantes.Add(this.votante);
                this.AgregarInformacion(this.votante.ToString());

                //if (!estaEnLista)
                //{
                //    this.votantes.Add(this.votante);
                //    this.AgregarInformacion(this.votante.ToString());
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "No se pudo cargar el votante");
            }

        }
    }
}
