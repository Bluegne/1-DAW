namespace Ejercicio_06_Tema_5
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
            this.btnShowRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadNum
            // 
            this.btnReadNum.Location = new System.Drawing.Point(73, 96);
            this.btnReadNum.Name = "btnReadNum";
            this.btnReadNum.Size = new System.Drawing.Size(134, 55);
            this.btnReadNum.TabIndex = 0;
            this.btnReadNum.Text = "Introducir Números";
            this.btnReadNum.UseVisualStyleBackColor = true;
            this.btnReadNum.Click += new System.EventHandler(this.btnReadNum_Click);
            // 
            // btnShowRes
            // 
            this.btnShowRes.Location = new System.Drawing.Point(261, 96);
            this.btnShowRes.Name = "btnShowRes";
            this.btnShowRes.Size = new System.Drawing.Size(134, 55);
            this.btnShowRes.TabIndex = 1;
            this.btnShowRes.Text = "Son iguales?";
            this.btnShowRes.UseVisualStyleBackColor = true;
            this.btnShowRes.Click += new System.EventHandler(this.btnShowRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 250);
            this.Controls.Add(this.btnShowRes);
            this.Controls.Add(this.btnReadNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadNum;
        private System.Windows.Forms.Button btnShowRes;
    }
}

