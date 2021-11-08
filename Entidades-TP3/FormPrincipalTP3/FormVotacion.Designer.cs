
namespace FormPrincipalTP3
{
    partial class FormVotacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInfoVotante = new System.Windows.Forms.GroupBox();
            this.cmbEscuderiaVotante = new System.Windows.Forms.ComboBox();
            this.lblPasiVotante = new System.Windows.Forms.Label();
            this.lblEscuderiaVotante = new System.Windows.Forms.Label();
            this.txtPaisVotante = new System.Windows.Forms.TextBox();
            this.lblSexoVotante = new System.Windows.Forms.Label();
            this.lblEdadVotante = new System.Windows.Forms.Label();
            this.lblNombreVotante = new System.Windows.Forms.Label();
            this.cmbSexoVotante = new System.Windows.Forms.ComboBox();
            this.txtEdadVotante = new System.Windows.Forms.TextBox();
            this.txtNombreVotante = new System.Windows.Forms.TextBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbInfoVotante.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfoVotante
            // 
            this.gbInfoVotante.Controls.Add(this.cmbEscuderiaVotante);
            this.gbInfoVotante.Controls.Add(this.lblPasiVotante);
            this.gbInfoVotante.Controls.Add(this.lblEscuderiaVotante);
            this.gbInfoVotante.Controls.Add(this.txtPaisVotante);
            this.gbInfoVotante.Controls.Add(this.lblSexoVotante);
            this.gbInfoVotante.Controls.Add(this.lblEdadVotante);
            this.gbInfoVotante.Controls.Add(this.lblNombreVotante);
            this.gbInfoVotante.Controls.Add(this.cmbSexoVotante);
            this.gbInfoVotante.Controls.Add(this.txtEdadVotante);
            this.gbInfoVotante.Controls.Add(this.txtNombreVotante);
            this.gbInfoVotante.Location = new System.Drawing.Point(21, 36);
            this.gbInfoVotante.Name = "gbInfoVotante";
            this.gbInfoVotante.Size = new System.Drawing.Size(791, 250);
            this.gbInfoVotante.TabIndex = 7;
            this.gbInfoVotante.TabStop = false;
            this.gbInfoVotante.Text = "Ingrese su información";
            // 
            // cmbEscuderiaVotante
            // 
            this.cmbEscuderiaVotante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscuderiaVotante.FormattingEnabled = true;
            this.cmbEscuderiaVotante.Location = new System.Drawing.Point(367, 179);
            this.cmbEscuderiaVotante.Name = "cmbEscuderiaVotante";
            this.cmbEscuderiaVotante.Size = new System.Drawing.Size(302, 28);
            this.cmbEscuderiaVotante.TabIndex = 10;
            // 
            // lblPasiVotante
            // 
            this.lblPasiVotante.AutoSize = true;
            this.lblPasiVotante.Location = new System.Drawing.Point(26, 156);
            this.lblPasiVotante.Name = "lblPasiVotante";
            this.lblPasiVotante.Size = new System.Drawing.Size(34, 20);
            this.lblPasiVotante.TabIndex = 9;
            this.lblPasiVotante.Text = "Pais";
            // 
            // lblEscuderiaVotante
            // 
            this.lblEscuderiaVotante.AutoSize = true;
            this.lblEscuderiaVotante.Location = new System.Drawing.Point(363, 157);
            this.lblEscuderiaVotante.Name = "lblEscuderiaVotante";
            this.lblEscuderiaVotante.Size = new System.Drawing.Size(137, 20);
            this.lblEscuderiaVotante.TabIndex = 8;
            this.lblEscuderiaVotante.Text = "Escuderia preferida";
            // 
            // txtPaisVotante
            // 
            this.txtPaisVotante.Location = new System.Drawing.Point(31, 179);
            this.txtPaisVotante.Name = "txtPaisVotante";
            this.txtPaisVotante.Size = new System.Drawing.Size(231, 27);
            this.txtPaisVotante.TabIndex = 6;
            // 
            // lblSexoVotante
            // 
            this.lblSexoVotante.AutoSize = true;
            this.lblSexoVotante.Location = new System.Drawing.Point(365, 33);
            this.lblSexoVotante.Name = "lblSexoVotante";
            this.lblSexoVotante.Size = new System.Drawing.Size(41, 20);
            this.lblSexoVotante.TabIndex = 5;
            this.lblSexoVotante.Text = "Sexo";
            // 
            // lblEdadVotante
            // 
            this.lblEdadVotante.AutoSize = true;
            this.lblEdadVotante.Location = new System.Drawing.Point(27, 94);
            this.lblEdadVotante.Name = "lblEdadVotante";
            this.lblEdadVotante.Size = new System.Drawing.Size(46, 20);
            this.lblEdadVotante.TabIndex = 4;
            this.lblEdadVotante.Text = "Edad:";
            // 
            // lblNombreVotante
            // 
            this.lblNombreVotante.AutoSize = true;
            this.lblNombreVotante.Location = new System.Drawing.Point(27, 33);
            this.lblNombreVotante.Name = "lblNombreVotante";
            this.lblNombreVotante.Size = new System.Drawing.Size(67, 20);
            this.lblNombreVotante.TabIndex = 3;
            this.lblNombreVotante.Text = "Nombre:";
            // 
            // cmbSexoVotante
            // 
            this.cmbSexoVotante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoVotante.FormattingEnabled = true;
            this.cmbSexoVotante.Location = new System.Drawing.Point(367, 56);
            this.cmbSexoVotante.Name = "cmbSexoVotante";
            this.cmbSexoVotante.Size = new System.Drawing.Size(302, 28);
            this.cmbSexoVotante.TabIndex = 2;
            // 
            // txtEdadVotante
            // 
            this.txtEdadVotante.Location = new System.Drawing.Point(31, 117);
            this.txtEdadVotante.Name = "txtEdadVotante";
            this.txtEdadVotante.Size = new System.Drawing.Size(231, 27);
            this.txtEdadVotante.TabIndex = 1;
            // 
            // txtNombreVotante
            // 
            this.txtNombreVotante.Location = new System.Drawing.Point(30, 56);
            this.txtNombreVotante.Name = "txtNombreVotante";
            this.txtNombreVotante.Size = new System.Drawing.Size(232, 27);
            this.txtNombreVotante.TabIndex = 0;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(571, 311);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(241, 47);
            this.btnVotar.TabIndex = 8;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(357, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(194, 47);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 366);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.gbInfoVotante);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVotacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votando";
            this.Load += new System.EventHandler(this.FormVotacion_Load);
            this.gbInfoVotante.ResumeLayout(false);
            this.gbInfoVotante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoVotante;
        private System.Windows.Forms.ComboBox cmbEscuderiaVotante;
        private System.Windows.Forms.Label lblPasiVotante;
        private System.Windows.Forms.Label lblEscuderiaVotante;
        private System.Windows.Forms.TextBox txtPaisVotante;
        private System.Windows.Forms.Label lblSexoVotante;
        private System.Windows.Forms.Label lblEdadVotante;
        private System.Windows.Forms.Label lblNombreVotante;
        private System.Windows.Forms.ComboBox cmbSexoVotante;
        private System.Windows.Forms.TextBox txtEdadVotante;
        private System.Windows.Forms.TextBox txtNombreVotante;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnCancelar;
    }
}