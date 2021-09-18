using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormCalculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
            
        }
          
        private void Limpiar()
        {
            operandoUno.Text = "";
            operandoDos.Text = "";
            operador.Text = "";
            resultado.Text = "";
        }
        private void operar_Click(object sender, EventArgs e)
        {
            double auxOperar = Operar(operandoUno.Text, operandoDos.Text, operador.Text);
            resultado.Text = auxOperar.ToString();

            StringBuilder sb = new StringBuilder();

            sb.Append(operandoUno.Text);
            if (operador.Text == "")
            {
                sb.Append("+");
            }
            else
            {
                sb.Append(operador.Text);
            }
            sb.Append(operandoDos.Text);
            sb.Append("=");
            sb.Append(resultado.Text);
            listar.Items.Add(sb.ToString());
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            char auxOperador;
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char.TryParse(operador, out auxOperador);
            return Calculadora.Operar(num1, num2, auxOperador);
        }



        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }

        private void aBinario_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(resultado.Text);
            string auxBinario = operando.DecimalBinario(resultado.Text);
            resultado.Text = auxBinario;

            sb.AppendLine("=");
            sb.AppendLine(resultado.Text);

            listar.Items.Add(sb.ToString());
        }

        private void aDecimal_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(resultado.Text);
            string auxDecimal = operando.BinarioDecimal(resultado.Text);
            resultado.Text = auxDecimal;


            sb.AppendLine("=");
            sb.AppendLine(resultado.Text);
            listar.Items.Add(sb.ToString());

        }



        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void operandoUno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals(",") && !(this.operandoUno.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("-") && this.operandoUno.Text.Length == 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros (Positivos/Negativos) o numeros con coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void operadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void operandoDos_TextChanged(object sender, EventArgs e)
        {

        }

        private void operandoDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals(",") && !(this.operandoDos.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("-") && this.operandoDos.Text.Length == 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros (Positivos/Negativos) o numeros con coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
