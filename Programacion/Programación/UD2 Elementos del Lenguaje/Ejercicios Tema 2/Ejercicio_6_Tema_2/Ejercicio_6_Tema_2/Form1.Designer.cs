namespace Ejercicio_6_Tema_2
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
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.bMostrarResultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(216, 120);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(100, 20);
            this.tNum1.TabIndex = 0;
            this.tNum1.TextChanged += new System.EventHandler(this.tNum1_TextChanged);
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(216, 186);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(100, 20);
            this.tNum2.TabIndex = 1;
            this.tNum2.TextChanged += new System.EventHandler(this.tNum2_TextChanged);
            // 
            // bMostrarResultado
            // 
            this.bMostrarResultado.Location = new System.Drawing.Point(216, 245);
            this.bMostrarResultado.Name = "bMostrarResultado";
            this.bMostrarResultado.Size = new System.Drawing.Size(100, 36);
            this.bMostrarResultado.TabIndex = 2;
            this.bMostrarResultado.Text = "Resultado";
            this.bMostrarResultado.UseVisualStyleBackColor = true;
            this.bMostrarResultado.Click += new System.EventHandler(this.bMostrarResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bMostrarResultado);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.tNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.Button bMostrarResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

