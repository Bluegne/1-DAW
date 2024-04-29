namespace Ejercicio_8_Tema_4
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
            this.btnCalcMedia = new System.Windows.Forms.Button();
            this.txtNotaA = new System.Windows.Forms.TextBox();
            this.txtNotaC = new System.Windows.Forms.TextBox();
            this.txtNotaB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota C:";
            // 
            // btnCalcMedia
            // 
            this.btnCalcMedia.Location = new System.Drawing.Point(202, 202);
            this.btnCalcMedia.Name = "btnCalcMedia";
            this.btnCalcMedia.Size = new System.Drawing.Size(136, 52);
            this.btnCalcMedia.TabIndex = 3;
            this.btnCalcMedia.Text = "Calcular Media";
            this.btnCalcMedia.UseVisualStyleBackColor = true;
            this.btnCalcMedia.Click += new System.EventHandler(this.btnCalcMedia_Click);
            // 
            // txtNotaA
            // 
            this.txtNotaA.Location = new System.Drawing.Point(223, 70);
            this.txtNotaA.Name = "txtNotaA";
            this.txtNotaA.Size = new System.Drawing.Size(100, 20);
            this.txtNotaA.TabIndex = 4;
            // 
            // txtNotaC
            // 
            this.txtNotaC.Location = new System.Drawing.Point(223, 154);
            this.txtNotaC.Name = "txtNotaC";
            this.txtNotaC.Size = new System.Drawing.Size(100, 20);
            this.txtNotaC.TabIndex = 5;
            // 
            // txtNotaB
            // 
            this.txtNotaB.Location = new System.Drawing.Point(223, 110);
            this.txtNotaB.Name = "txtNotaB";
            this.txtNotaB.Size = new System.Drawing.Size(100, 20);
            this.txtNotaB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 329);
            this.Controls.Add(this.txtNotaB);
            this.Controls.Add(this.txtNotaC);
            this.Controls.Add(this.txtNotaA);
            this.Controls.Add(this.btnCalcMedia);
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
        private System.Windows.Forms.Button btnCalcMedia;
        private System.Windows.Forms.TextBox txtNotaA;
        private System.Windows.Forms.TextBox txtNotaC;
        private System.Windows.Forms.TextBox txtNotaB;
    }
}

