namespace Ejercicio_23_Tema_3
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
            this.btnCalcularPeso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularPeso
            // 
            this.btnCalcularPeso.Location = new System.Drawing.Point(168, 144);
            this.btnCalcularPeso.Name = "btnCalcularPeso";
            this.btnCalcularPeso.Size = new System.Drawing.Size(177, 71);
            this.btnCalcularPeso.TabIndex = 0;
            this.btnCalcularPeso.Text = "Calcular peso";
            this.btnCalcularPeso.UseVisualStyleBackColor = true;
            this.btnCalcularPeso.Click += new System.EventHandler(this.btnCalcularPeso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 363);
            this.Controls.Add(this.btnCalcularPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPeso;
    }
}

