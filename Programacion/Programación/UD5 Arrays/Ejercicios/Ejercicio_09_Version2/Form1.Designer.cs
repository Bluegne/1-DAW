namespace Ejercicio_09_Version2
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnShowRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(127, 109);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(145, 70);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read Array";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnShowRes
            // 
            this.btnShowRes.Location = new System.Drawing.Point(338, 109);
            this.btnShowRes.Name = "btnShowRes";
            this.btnShowRes.Size = new System.Drawing.Size(145, 70);
            this.btnShowRes.TabIndex = 1;
            this.btnShowRes.Text = "Show Result";
            this.btnShowRes.UseVisualStyleBackColor = true;
            this.btnShowRes.Click += new System.EventHandler(this.btnShowRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 303);
            this.Controls.Add(this.btnShowRes);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnShowRes;
    }
}

