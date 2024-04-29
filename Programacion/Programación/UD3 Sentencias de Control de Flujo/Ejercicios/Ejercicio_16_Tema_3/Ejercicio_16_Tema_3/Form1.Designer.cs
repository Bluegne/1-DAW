namespace Ejercicio_16_Tema_3
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
            this.btnMostrarSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarSuma
            // 
            this.btnMostrarSuma.Location = new System.Drawing.Point(189, 132);
            this.btnMostrarSuma.Name = "btnMostrarSuma";
            this.btnMostrarSuma.Size = new System.Drawing.Size(152, 70);
            this.btnMostrarSuma.TabIndex = 0;
            this.btnMostrarSuma.Text = "Mostrar Suma";
            this.btnMostrarSuma.UseVisualStyleBackColor = true;
            this.btnMostrarSuma.Click += new System.EventHandler(this.btnMostrarSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 349);
            this.Controls.Add(this.btnMostrarSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarSuma;
    }
}

