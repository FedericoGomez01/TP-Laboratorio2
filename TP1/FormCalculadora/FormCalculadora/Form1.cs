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
        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Inicializa el formulario con los valores vacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
            
        }
        /// <summary>
        /// Lipia los valores en operandoUno, operandoDos, operador y resultado
        /// </summary>
        private void Limpiar()
        {
            operandoUno.Text = "";
            operandoDos.Text = "";
            operador.Text = "";
            resultado.Text = "";
        }
        /// <summary>
        /// Realiza la operacion y carga los valores en la listar y resultado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Recibe los operandos y el operador y realiza la respectiva cuenta.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            char auxOperador;
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char.TryParse(operador, out auxOperador);
            return Calculadora.Operar(num1, num2, auxOperador);
        }

        /// <summary>
        /// Lipia los valores en operandoUno, operandoDos, operador y resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }
        /// <summary>
        /// Cransforma un numero decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Convierte un numero binario a decimal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cierra la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cuando el formulario se esté cerrando pregunta al usuario si esta seguro de salir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Valida la entrada de los datos que ingrese el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operandoUno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)) ||
            (e.KeyChar.ToString().Equals(",") && !(this.operandoUno.Text.Contains(","))) ||
            (e.KeyChar.ToString().Equals("-") && this.operandoUno.Text.Length == 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Se aceptan numeros enteros o numeros con coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Valida la entrada de los datos que ingrese el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operandoDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)) ||
            (e.KeyChar.ToString().Equals(",") && !(this.operandoDos.Text.Contains(","))) ||
            (e.KeyChar.ToString().Equals("-") && this.operandoDos.Text.Length == 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Se aceptan numeros enteros o numeros con coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void operadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void operandoDos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
