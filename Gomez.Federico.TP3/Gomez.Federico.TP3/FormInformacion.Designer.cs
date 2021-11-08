
namespace Gomez.Federico.TP3
{
    partial class FormInformacion
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
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(63, 44);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(141, 20);
            this.lblNombreBusqueda.TabIndex = 0;
            this.lblNombreBusqueda.Text = "Buscar por Nombre:";
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Location = new System.Drawing.Point(210, 41);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(197, 27);
            this.txtNombreBusqueda.TabIndex = 3;
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Location = new System.Drawing.Point(6, 85);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.ReadOnly = true;
            this.rtbInformacion.Size = new System.Drawing.Size(701, 305);
            this.rtbInformacion.TabIndex = 4;
            this.rtbInformacion.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.rtbInformacion);
            this.groupBox1.Controls.Add(this.txtNombreBusqueda);
            this.groupBox1.Controls.Add(this.lblNombreBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(30, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Vehiculo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(413, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(36, 35);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(279, 37);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Agregar o Eliminar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
    }
}