namespace Ejercicio_04_Tema_5
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
            this.btnNegativeNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadNum
            // 
            this.btnReadNum.Location = new System.Drawing.Point(63, 82);
            this.btnReadNum.Name = "btnReadNum";
            this.btnReadNum.Size = new System.Drawing.Size(121, 47);
            this.btnReadNum.TabIndex = 0;
            this.btnReadNum.Text = "Introducir Números";
            this.btnReadNum.UseVisualStyleBackColor = true;
            this.btnReadNum.Click += new System.EventHandler(this.btnReadNum_Click);
            // 
            // btnNegativeNum
            // 
            this.btnNegativeNum.Location = new System.Drawing.Point(235, 82);
            this.btnNegativeNum.Name = "btnNegativeNum";
            this.btnNegativeNum.Size = new System.Drawing.Size(121, 47);
            this.btnNegativeNum.TabIndex = 2;
            this.btnNegativeNum.Text = "Cantidad núm negativos introducidos?";
            this.btnNegativeNum.UseVisualStyleBackColor = true;
            this.btnNegativeNum.Click += new System.EventHandler(this.btnNegativeNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 224);
            this.Controls.Add(this.btnNegativeNum);
            this.Controls.Add(this.btnReadNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadNum;
        private System.Windows.Forms.Button btnNegativeNum;
    }
}

