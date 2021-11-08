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

namespace FormPrincipalTP3
{
    public partial class FormVotacion : Form
    {

        Form1 form1;
        public FormVotacion()
        {
            InitializeComponent();
            form1 = new Form1();
        }

        private void FormVotacion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCmb();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo no salio como se esperaba");
            }
        }

        private void CargarCmb()
        {
            this.cmbEscuderiaVotante.DataSource = Enum.GetValues(typeof(Votante.Escuderias));
            this.cmbSexoVotante.DataSource = Enum.GetValues(typeof(Votante.Sexos));

        }


        private void btnVotar_Click(object sender, EventArgs e)
        {
            try
            {
                this.form1.AgregarUnVotante(txtNombreVotante.Text, short.Parse(txtEdadVotante.Text), ((Votante.Sexos)cmbSexoVotante.SelectedIndex),
                    txtPaisVotante.Text, ((Votante.Escuderias)cmbEscuderiaVotante.SelectedIndex));
                MessageBox.Show("Se cargo la informacion con exito", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal");
            }
            finally
            {
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal");
            }
        }
    }
}
