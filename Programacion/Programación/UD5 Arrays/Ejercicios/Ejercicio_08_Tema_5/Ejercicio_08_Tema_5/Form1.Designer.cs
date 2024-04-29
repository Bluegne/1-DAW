namespace Ejercicio_08_Tema_5
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
            this.btnReadArray = new System.Windows.Forms.Button();
            this.btnShowArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadArray
            // 
            this.btnReadArray.Location = new System.Drawing.Point(84, 86);
            this.btnReadArray.Name = "btnReadArray";
            this.btnReadArray.Size = new System.Drawing.Size(105, 47);
            this.btnReadArray.TabIndex = 1;
            this.btnReadArray.Text = "Introducir Números";
            this.btnReadArray.UseVisualStyleBackColor = true;
            this.btnReadArray.Click += new System.EventHandler(this.btnReadArray_Click);
            // 
            // btnShowArray
            // 
            this.btnShowArray.Location = new System.Drawing.Point(236, 86);
            this.btnShowArray.Name = "btnShowArray";
            this.btnShowArray.Size = new System.Drawing.Size(105, 47);
            this.btnShowArray.TabIndex = 2;
            this.btnShowArray.Text = "Mostrar Array";
            this.btnShowArray.UseVisualStyleBackColor = true;
            this.btnShowArray.Click += new System.EventHandler(this.btnShowArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 235);
            this.Controls.Add(this.btnShowArray);
            this.Controls.Add(this.btnReadArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadArray;
        private System.Windows.Forms.Button btnShowArray;
    }
}

