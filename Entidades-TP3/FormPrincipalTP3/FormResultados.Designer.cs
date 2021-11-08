
namespace FormPrincipalTP3
{
    partial class FormResultados
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
            this.txtboxNombreCorredorUno = new System.Windows.Forms.TextBox();
            this.txtboxNombreLEWIS = new System.Windows.Forms.TextBox();
            this.gbInfoCorredorUno = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtboxNombreCorredorUno
            // 
            this.txtboxNombreCorredorUno.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxNombreCorredorUno.Location = new System.Drawing.Point(66, 45);
            this.txtboxNombreCorredorUno.Name = "txtboxNombreCorredorUno";
            this.txtboxNombreCorredorUno.ReadOnly = true;
            this.txtboxNombreCorredorUno.Size = new System.Drawing.Size(243, 43);
            this.txtboxNombreCorredorUno.TabIndex = 0;
            this.txtboxNombreCorredorUno.Text = "LEWIS HAMILTON";
            this.txtboxNombreCorredorUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxNombreLEWIS
            // 
            this.txtboxNombreLEWIS.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxNombreLEWIS.Location = new System.Drawing.Point(464, 45);
            this.txtboxNombreLEWIS.Name = "txtboxNombreLEWIS";
            this.txtboxNombreLEWIS.ReadOnly = true;
            this.txtboxNombreLEWIS.Size = new System.Drawing.Size(243, 43);
            this.txtboxNombreLEWIS.TabIndex = 1;
            this.txtboxNombreLEWIS.Text = "MAX VERSTAPPEN";
            this.txtboxNombreLEWIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbInfoCorredorUno
            // 
            this.gbInfoCorredorUno.Location = new System.Drawing.Point(29, 109);
            this.gbInfoCorredorUno.Name = "gbInfoCorredorUno";
            this.gbInfoCorredorUno.Size = new System.Drawing.Size(324, 329);
            this.gbInfoCorredorUno.TabIndex = 2;
            this.gbInfoCorredorUno.TabStop = false;
            this.gbInfoCorredorUno.Text = "Informacion de los votantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(418, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 329);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de los votantes";
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInfoCorredorUno);
            this.Controls.Add(this.txtboxNombreLEWIS);
            this.Controls.Add(this.txtboxNombreCorredorUno);
            this.Name = "FormResultados";
            this.Text = "Resultados de la votación ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNombreCorredorUno;
        private System.Windows.Forms.TextBox txtboxNombreLEWIS;
        private System.Windows.Forms.GroupBox gbInfoCorredorUno;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}