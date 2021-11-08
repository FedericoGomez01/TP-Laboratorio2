
namespace FormPrincipalTP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNombreCorredorUno = new System.Windows.Forms.Label();
            this.lblbNombreCorredorDos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.btnImportarArchivos = new System.Windows.Forms.Button();
            this.btnExportarArchivos = new System.Windows.Forms.Button();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCorredorUno
            // 
            this.lblNombreCorredorUno.AutoSize = true;
            this.lblNombreCorredorUno.Location = new System.Drawing.Point(195, 66);
            this.lblNombreCorredorUno.Name = "lblNombreCorredorUno";
            this.lblNombreCorredorUno.Size = new System.Drawing.Size(111, 20);
            this.lblNombreCorredorUno.TabIndex = 0;
            this.lblNombreCorredorUno.Text = "Lewis Hamilton";
            // 
            // lblbNombreCorredorDos
            // 
            this.lblbNombreCorredorDos.AutoSize = true;
            this.lblbNombreCorredorDos.Location = new System.Drawing.Point(694, 66);
            this.lblbNombreCorredorDos.Name = "lblbNombreCorredorDos";
            this.lblbNombreCorredorDos.Size = new System.Drawing.Size(115, 20);
            this.lblbNombreCorredorDos.TabIndex = 1;
            this.lblbNombreCorredorDos.Text = "Max Verstappen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(584, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(312, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(124, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(756, 50);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "VOTACION DEL MEJOR CORREDOR DEL 2021";
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(519, 317);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(377, 45);
            this.btnVotar.TabIndex = 8;
            this.btnVotar.Text = "VOTAR";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(519, 388);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(377, 45);
            this.btnVerResultados.TabIndex = 9;
            this.btnVerResultados.Text = "RESULTADOS";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // btnImportarArchivos
            // 
            this.btnImportarArchivos.Location = new System.Drawing.Point(104, 317);
            this.btnImportarArchivos.Name = "btnImportarArchivos";
            this.btnImportarArchivos.Size = new System.Drawing.Size(357, 45);
            this.btnImportarArchivos.TabIndex = 10;
            this.btnImportarArchivos.Text = "IMPORTAR ARCHIVOS";
            this.btnImportarArchivos.UseVisualStyleBackColor = true;
            this.btnImportarArchivos.Click += new System.EventHandler(this.btnImportarArchivos_Click);
            // 
            // btnExportarArchivos
            // 
            this.btnExportarArchivos.Location = new System.Drawing.Point(104, 388);
            this.btnExportarArchivos.Name = "btnExportarArchivos";
            this.btnExportarArchivos.Size = new System.Drawing.Size(357, 45);
            this.btnExportarArchivos.TabIndex = 11;
            this.btnExportarArchivos.Text = "EXPORTAR ARCHIVOS";
            this.btnExportarArchivos.UseVisualStyleBackColor = true;
            this.btnExportarArchivos.Click += new System.EventHandler(this.btnExportarArchivos_Click);
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Location = new System.Drawing.Point(104, 466);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.ReadOnly = true;
            this.rtbInformacion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbInformacion.Size = new System.Drawing.Size(791, 447);
            this.rtbInformacion.TabIndex = 12;
            this.rtbInformacion.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 934);
            this.Controls.Add(this.rtbInformacion);
            this.Controls.Add(this.btnExportarArchivos);
            this.Controls.Add(this.btnImportarArchivos);
            this.Controls.Add(this.btnVerResultados);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblbNombreCorredorDos);
            this.Controls.Add(this.lblNombreCorredorUno);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCorredorUno;
        private System.Windows.Forms.Label lblbNombreCorredorDos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.Button btnImportarArchivos;
        private System.Windows.Forms.Button btnExportarArchivos;
        private System.Windows.Forms.RichTextBox rtbInformacion;
    }
}

