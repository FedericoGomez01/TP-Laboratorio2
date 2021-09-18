
namespace FormCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.operadores = new System.Windows.Forms.ComboBox();
            this.operandoUno = new System.Windows.Forms.TextBox();
            this.operandoDos = new System.Windows.Forms.TextBox();
            this.listar = new System.Windows.Forms.ListBox();
            this.operar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.aBinario = new System.Windows.Forms.Button();
            this.aDecimal = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.operador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // operadores
            // 
            this.operadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.operadores.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operadores.FormattingEnabled = true;
            this.operadores.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "/",
            "*"});
            this.operadores.Location = new System.Drawing.Point(213, 71);
            this.operadores.MaximumSize = new System.Drawing.Size(131, 0);
            this.operadores.MinimumSize = new System.Drawing.Size(131, 0);
            this.operadores.Name = "operadores";
            this.operadores.Size = new System.Drawing.Size(131, 0);
            this.operadores.TabIndex = 1;
            this.operadores.SelectedIndexChanged += new System.EventHandler(this.operadores_SelectedIndexChanged);
            // 
            // operandoUno
            // 
            this.operandoUno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operandoUno.Location = new System.Drawing.Point(61, 72);
            this.operandoUno.MaximumSize = new System.Drawing.Size(131, 60);
            this.operandoUno.MinimumSize = new System.Drawing.Size(131, 51);
            this.operandoUno.Name = "operandoUno";
            this.operandoUno.Size = new System.Drawing.Size(131, 47);
            this.operandoUno.TabIndex = 0;
            this.operandoUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.operandoUno.TextChanged += new System.EventHandler(this.operadores_SelectedIndexChanged);
            this.operandoUno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.operandoUno_KeyPress);
            // 
            // operandoDos
            // 
            this.operandoDos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operandoDos.Location = new System.Drawing.Point(368, 74);
            this.operandoDos.MaximumSize = new System.Drawing.Size(131, 50);
            this.operandoDos.MinimumSize = new System.Drawing.Size(131, 50);
            this.operandoDos.Name = "operandoDos";
            this.operandoDos.Size = new System.Drawing.Size(131, 47);
            this.operandoDos.TabIndex = 2;
            this.operandoDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.operandoDos.TextChanged += new System.EventHandler(this.operandoDos_TextChanged);
            this.operandoDos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.operandoDos_KeyPress);
            // 
            // listar
            // 
            this.listar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listar.FormattingEnabled = true;
            this.listar.ItemHeight = 23;
            this.listar.Location = new System.Drawing.Point(517, 8);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(216, 326);
            this.listar.TabIndex = 3;
            this.listar.TabStop = false;
            // 
            // operar
            // 
            this.operar.Location = new System.Drawing.Point(59, 180);
            this.operar.Name = "operar";
            this.operar.Size = new System.Drawing.Size(138, 51);
            this.operar.TabIndex = 3;
            this.operar.Text = "Operar";
            this.operar.UseVisualStyleBackColor = true;
            this.operar.Click += new System.EventHandler(this.operar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(213, 180);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(138, 51);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(368, 180);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(138, 51);
            this.cerrar.TabIndex = 5;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // aBinario
            // 
            this.aBinario.Location = new System.Drawing.Point(59, 278);
            this.aBinario.Name = "aBinario";
            this.aBinario.Size = new System.Drawing.Size(220, 51);
            this.aBinario.TabIndex = 6;
            this.aBinario.Text = "Convertir a Binario";
            this.aBinario.UseVisualStyleBackColor = true;
            this.aBinario.Click += new System.EventHandler(this.aBinario_Click);
            // 
            // aDecimal
            // 
            this.aDecimal.Location = new System.Drawing.Point(286, 278);
            this.aDecimal.Name = "aDecimal";
            this.aDecimal.Size = new System.Drawing.Size(220, 51);
            this.aDecimal.TabIndex = 7;
            this.aDecimal.Text = "Convertir a Decimal";
            this.aDecimal.UseVisualStyleBackColor = true;
            this.aDecimal.Click += new System.EventHandler(this.aDecimal_Click);
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(31, 8);
            this.resultado.MaximumSize = new System.Drawing.Size(480, 61);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(480, 61);
            this.resultado.TabIndex = 9;
            this.resultado.Text = "0";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // operador
            // 
            this.operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operador.FormattingEnabled = true;
            this.operador.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.operador.Location = new System.Drawing.Point(213, 74);
            this.operador.Name = "operador";
            this.operador.Size = new System.Drawing.Size(138, 49);
            this.operador.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 364);
            this.Controls.Add(this.operador);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.aDecimal);
            this.Controls.Add(this.aBinario);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.operar);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.operandoDos);
            this.Controls.Add(this.operadores);
            this.Controls.Add(this.operandoUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Federico Gomez del curso 2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox operandoUno;
        private System.Windows.Forms.ComboBox operadores;
        private System.Windows.Forms.TextBox operandoDos;
        private System.Windows.Forms.ListBox listar;
        private System.Windows.Forms.Button operar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button aBinario;
        private System.Windows.Forms.Button aDecimal;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.ComboBox operador;
    }
}

