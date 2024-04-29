namespace Ejercicio_07_Tema_5
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
            this.btnReadNum = new System.Windows.Forms.Button();
            this.btnShowArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadNum
            // 
            this.btnReadNum.Location = new System.Drawing.Point(124, 107);
            this.btnReadNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadNum.Name = "btnReadNum";
            this.btnReadNum.Size = new System.Drawing.Size(166, 62);
            this.btnReadNum.TabIndex = 0;
            this.btnReadNum.Text = "Introducir Números";
            this.btnReadNum.UseVisualStyleBackColor = true;
            this.btnReadNum.Click += new System.EventHandler(this.btnReadNum_Click);
            // 
            // btnShowArray
            // 
            this.btnShowArray.Location = new System.Drawing.Point(327, 107);
            this.btnShowArray.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowArray.Name = "btnShowArray";
            this.btnShowArray.Size = new System.Drawing.Size(166, 62);
            this.btnShowArray.TabIndex = 1;
            this.btnShowArray.Text = "Mostrar Array";
            this.btnShowArray.UseVisualStyleBackColor = true;
            this.btnShowArray.Click += new System.EventHandler(this.btnShowArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 273);
            this.Controls.Add(this.btnShowArray);
            this.Controls.Add(this.btnReadNum);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadNum;
        private System.Windows.Forms.Button btnShowArray;
    }
}

