namespace Ejercicio_8_Tema_2
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
            this.bResultado = new System.Windows.Forms.Button();
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.tNum3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero 3: ";
            // 
            // bResultado
            // 
            this.bResultado.Location = new System.Drawing.Point(221, 250);
            this.bResultado.Name = "bResultado";
            this.bResultado.Size = new System.Drawing.Size(100, 39);
            this.bResultado.TabIndex = 3;
            this.bResultado.Text = "Resultado";
            this.bResultado.UseVisualStyleBackColor = true;
            this.bResultado.Click += new System.EventHandler(this.bResultado_Click);
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(221, 90);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(100, 20);
            this.tNum1.TabIndex = 4;
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(221, 144);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(100, 20);
            this.tNum2.TabIndex = 5;
            // 
            // tNum3
            // 
            this.tNum3.Location = new System.Drawing.Point(221, 195);
            this.tNum3.Name = "tNum3";
            this.tNum3.Size = new System.Drawing.Size(100, 20);
            this.tNum3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tNum3);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.tNum1);
            this.Controls.Add(this.bResultado);
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
        private System.Windows.Forms.Button bResultado;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.TextBox tNum3;
    }
}

