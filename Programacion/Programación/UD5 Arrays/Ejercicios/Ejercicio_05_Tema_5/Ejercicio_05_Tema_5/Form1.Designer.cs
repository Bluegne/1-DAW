namespace Ejercicio_05_Tema_5
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
            this.btnReadA = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadA
            // 
            this.btnReadA.Location = new System.Drawing.Point(111, 106);
            this.btnReadA.Name = "btnReadA";
            this.btnReadA.Size = new System.Drawing.Size(122, 55);
            this.btnReadA.TabIndex = 0;
            this.btnReadA.Text = "Introducir Números";
            this.btnReadA.UseVisualStyleBackColor = true;
            this.btnReadA.Click += new System.EventHandler(this.btnReadA_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(290, 106);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(122, 55);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Sumar Posición Números";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 272);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnReadA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadA;
        private System.Windows.Forms.Button btnSum;
    }
}

