
namespace Gomez.Federico.TP3
{
    partial class FormAgregar
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
            this.gbAgregarCoche = new System.Windows.Forms.GroupBox();
            this.txtCategotia = new System.Windows.Forms.TextBox();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEliminar = new System.Windows.Forms.Button();
            this.rtbEliminar = new System.Windows.Forms.RichTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtPatenteEliminar = new System.Windows.Forms.TextBox();
            this.lblPatenteEliminar = new System.Windows.Forms.Label();
            this.gbAgregarCoche.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAgregarCoche
            // 
            this.gbAgregarCoche.Controls.Add(this.txtCategotia);
            this.gbAgregarCoche.Controls.Add(this.btnAgregarVehiculo);
            this.gbAgregarCoche.Controls.Add(this.txtAnio);
            this.gbAgregarCoche.Controls.Add(this.txtPatente);
            this.gbAgregarCoche.Controls.Add(this.txtNombre);
            this.gbAgregarCoche.Controls.Add(this.lblPatente);
            this.gbAgregarCoche.Controls.Add(this.lblCategoria);
            this.gbAgregarCoche.Controls.Add(this.lblAnio);
            this.gbAgregarCoche.Controls.Add(this.lblNombre);
            this.gbAgregarCoche.Location = new System.Drawing.Point(37, 30);
            this.gbAgregarCoche.Name = "gbAgregarCoche";
            this.gbAgregarCoche.Size = new System.Drawing.Size(713, 189);
            this.gbAgregarCoche.TabIndex = 1;
            this.gbAgregarCoche.TabStop = false;
            this.gbAgregarCoche.Text = "Agregar Vehiculo";
            // 
            // txtCategotia
            // 
            this.txtCategotia.Location = new System.Drawing.Point(411, 109);
            this.txtCategotia.Name = "txtCategotia";
            this.txtCategotia.Size = new System.Drawing.Size(197, 27);
            this.txtCategotia.TabIndex = 8;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(570, 140);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(121, 35);
            this.btnAgregarVehiculo.TabIndex = 7;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(373, 45);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(94, 27);
            this.txtAnio.TabIndex = 5;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(107, 109);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(197, 27);
            this.txtPatente.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(34, 109);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(61, 20);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(328, 109);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 20);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(328, 48);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(39, 20);
            this.lblAnio.TabIndex = 1;
            this.lblAnio.Text = "Año:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarEliminar);
            this.groupBox1.Controls.Add(this.rtbEliminar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtPatenteEliminar);
            this.groupBox1.Controls.Add(this.lblPatenteEliminar);
            this.groupBox1.Location = new System.Drawing.Point(37, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 189);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Vehiculo";
            // 
            // btnBuscarEliminar
            // 
            this.btnBuscarEliminar.Location = new System.Drawing.Point(75, 77);
            this.btnBuscarEliminar.Name = "btnBuscarEliminar";
            this.btnBuscarEliminar.Size = new System.Drawing.Size(121, 35);
            this.btnBuscarEliminar.TabIndex = 9;
            this.btnBuscarEliminar.Text = "Buscar Patente";
            this.btnBuscarEliminar.UseVisualStyleBackColor = true;
            this.btnBuscarEliminar.Click += new System.EventHandler(this.btnBuscarEliminar_Click);
            // 
            // rtbEliminar
            // 
            this.rtbEliminar.Location = new System.Drawing.Point(291, 36);
            this.rtbEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.rtbEliminar.Name = "rtbEliminar";
            this.rtbEliminar.Size = new System.Drawing.Size(402, 147);
            this.rtbEliminar.TabIndex = 8;
            this.rtbEliminar.Text = "";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(75, 134);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPatenteEliminar
            // 
            this.txtPatenteEliminar.Location = new System.Drawing.Point(80, 36);
            this.txtPatenteEliminar.Name = "txtPatenteEliminar";
            this.txtPatenteEliminar.Size = new System.Drawing.Size(197, 27);
            this.txtPatenteEliminar.TabIndex = 4;
            // 
            // lblPatenteEliminar
            // 
            this.lblPatenteEliminar.AutoSize = true;
            this.lblPatenteEliminar.Location = new System.Drawing.Point(8, 37);
            this.lblPatenteEliminar.Name = "lblPatenteEliminar";
            this.lblPatenteEliminar.Size = new System.Drawing.Size(61, 20);
            this.lblPatenteEliminar.TabIndex = 2;
            this.lblPatenteEliminar.Text = "Patente:";
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAgregarCoche);
            this.Name = "FormAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregar";
            this.gbAgregarCoche.ResumeLayout(false);
            this.gbAgregarCoche.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgregarCoche;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtPatenteEliminar;
        private System.Windows.Forms.Label lblPatenteEliminar;
        private System.Windows.Forms.Button btnBuscarEliminar;
        private System.Windows.Forms.TextBox txtCategotia;
    }
}