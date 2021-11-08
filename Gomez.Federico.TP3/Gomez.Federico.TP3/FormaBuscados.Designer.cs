
namespace Gomez.Federico.TP3
{
    partial class FormaBuscados
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
            this.rtbBuscados = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbBuscados
            // 
            this.rtbBuscados.Location = new System.Drawing.Point(15, 51);
            this.rtbBuscados.Name = "rtbBuscados";
            this.rtbBuscados.ReadOnly = true;
            this.rtbBuscados.Size = new System.Drawing.Size(772, 388);
            this.rtbBuscados.TabIndex = 0;
            this.rtbBuscados.Text = "";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(220, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(115, 31);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre : ";
            // 
            // FormaBuscados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rtbBuscados);
            this.Name = "FormaBuscados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaBuscados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBuscados;
        private System.Windows.Forms.Label lblNombre;
    }
}