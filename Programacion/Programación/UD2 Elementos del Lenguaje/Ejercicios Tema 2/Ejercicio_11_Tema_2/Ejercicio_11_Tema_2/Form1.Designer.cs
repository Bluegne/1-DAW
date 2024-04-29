namespace Ejercicio_11_Tema_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tIngreso = new System.Windows.Forms.TextBox();
            this.tInteres = new System.Windows.Forms.TextBox();
            this.tCapital = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a Ingresar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interes Anual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capital a final de año:";
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(219, 242);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(100, 37);
            this.bCalcular.TabIndex = 3;
            this.bCalcular.Text = "CALCULAR";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // tIngreso
            // 
            this.tIngreso.Location = new System.Drawing.Point(219, 102);
            this.tIngreso.Name = "tIngreso";
            this.tIngreso.Size = new System.Drawing.Size(100, 20);
            this.tIngreso.TabIndex = 4;
            // 
            // tInteres
            // 
            this.tInteres.Location = new System.Drawing.Point(219, 149);
            this.tInteres.Name = "tInteres";
            this.tInteres.Size = new System.Drawing.Size(100, 20);
            this.tInteres.TabIndex = 5;
            // 
            // tCapital
            // 
            this.tCapital.Location = new System.Drawing.Point(219, 196);
            this.tCapital.Name = "tCapital";
            this.tCapital.Size = new System.Drawing.Size(100, 20);
            this.tCapital.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 383);
            this.Controls.Add(this.tCapital);
            this.Controls.Add(this.tInteres);
            this.Controls.Add(this.tIngreso);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox tIngreso;
        private System.Windows.Forms.TextBox tInteres;
        private System.Windows.Forms.TextBox tCapital;
    }
}

