namespace Ejercicio_03_Tema_5
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(288, 89);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(140, 73);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Mostrar Números Introducidos";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(91, 89);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(137, 73);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Introducir Números";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(191, 196);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 73);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Mostrar Número Menor";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 336);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCalculate;
    }
}

