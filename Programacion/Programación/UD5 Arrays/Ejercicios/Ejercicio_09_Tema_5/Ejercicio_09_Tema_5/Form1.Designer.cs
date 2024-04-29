namespace Ejercicio_09_Tema_5
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
            this.btnChangeArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadArray
            // 
            this.btnReadArray.Location = new System.Drawing.Point(63, 104);
            this.btnReadArray.Name = "btnReadArray";
            this.btnReadArray.Size = new System.Drawing.Size(114, 52);
            this.btnReadArray.TabIndex = 0;
            this.btnReadArray.Text = "Read Numbers";
            this.btnReadArray.UseVisualStyleBackColor = true;
            this.btnReadArray.Click += new System.EventHandler(this.btnReadArray_Click);
            // 
            // btnChangeArray
            // 
            this.btnChangeArray.Location = new System.Drawing.Point(216, 104);
            this.btnChangeArray.Name = "btnChangeArray";
            this.btnChangeArray.Size = new System.Drawing.Size(114, 52);
            this.btnChangeArray.TabIndex = 1;
            this.btnChangeArray.Text = "Change Array";
            this.btnChangeArray.UseVisualStyleBackColor = true;
            this.btnChangeArray.Click += new System.EventHandler(this.btnChangeArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 247);
            this.Controls.Add(this.btnChangeArray);
            this.Controls.Add(this.btnReadArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadArray;
        private System.Windows.Forms.Button btnChangeArray;
    }
}

