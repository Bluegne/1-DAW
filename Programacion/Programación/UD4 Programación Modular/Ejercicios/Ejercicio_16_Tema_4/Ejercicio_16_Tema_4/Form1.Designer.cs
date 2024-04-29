namespace Ejercicio_16_Tema_4
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
            this.btbCalcFactorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbCalcFactorial
            // 
            this.btbCalcFactorial.Location = new System.Drawing.Point(130, 136);
            this.btbCalcFactorial.Name = "btbCalcFactorial";
            this.btbCalcFactorial.Size = new System.Drawing.Size(135, 42);
            this.btbCalcFactorial.TabIndex = 2;
            this.btbCalcFactorial.Text = "Calcular Factorial";
            this.btbCalcFactorial.UseVisualStyleBackColor = true;
            this.btbCalcFactorial.Click += new System.EventHandler(this.btbCalcFactorial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número:";
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(130, 79);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(135, 20);
            this.txtUserNumber.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 275);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbCalcFactorial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbCalcFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNumber;
    }
}

