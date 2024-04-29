namespace Ejercicio_22_Tema_3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComprobar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(172, 171);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(127, 38);
            this.btnComprobar.TabIndex = 0;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Serie:";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(150, 103);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(163, 20);
            this.txtNumSerie.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 309);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprobar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumSerie;
    }
}

