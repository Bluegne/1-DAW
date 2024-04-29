namespace Ejercicio_14_Tema_3
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
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(171, 108);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(123, 59);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "Sumar (for)";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(171, 197);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(123, 61);
            this.btnWhile.TabIndex = 3;
            this.btnWhile.Text = "Sumar (while)";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 382);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
    }
}

