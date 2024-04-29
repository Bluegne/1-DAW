namespace Ejercicio_10_Tema_2
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
            this.tEuros = new System.Windows.Forms.TextBox();
            this.tPesetas = new System.Windows.Forms.TextBox();
            this.bConvertToPeseta = new System.Windows.Forms.Button();
            this.bConvertToEuro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Euros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesetas:";
            // 
            // tEuros
            // 
            this.tEuros.Location = new System.Drawing.Point(226, 118);
            this.tEuros.Name = "tEuros";
            this.tEuros.Size = new System.Drawing.Size(100, 20);
            this.tEuros.TabIndex = 2;
            // 
            // tPesetas
            // 
            this.tPesetas.Location = new System.Drawing.Point(226, 176);
            this.tPesetas.Name = "tPesetas";
            this.tPesetas.Size = new System.Drawing.Size(100, 20);
            this.tPesetas.TabIndex = 3;
            // 
            // bConvertToPeseta
            // 
            this.bConvertToPeseta.Location = new System.Drawing.Point(226, 225);
            this.bConvertToPeseta.Name = "bConvertToPeseta";
            this.bConvertToPeseta.Size = new System.Drawing.Size(100, 38);
            this.bConvertToPeseta.TabIndex = 4;
            this.bConvertToPeseta.Text = "Pasar a Pesetas";
            this.bConvertToPeseta.UseVisualStyleBackColor = true;
            this.bConvertToPeseta.Click += new System.EventHandler(this.bConvertToPeseta_Click);
            // 
            // bConvertToEuro
            // 
            this.bConvertToEuro.Location = new System.Drawing.Point(226, 289);
            this.bConvertToEuro.Name = "bConvertToEuro";
            this.bConvertToEuro.Size = new System.Drawing.Size(100, 38);
            this.bConvertToEuro.TabIndex = 5;
            this.bConvertToEuro.Text = "Pasar a Euros";
            this.bConvertToEuro.UseVisualStyleBackColor = true;
            this.bConvertToEuro.Click += new System.EventHandler(this.bConvertToEuro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 394);
            this.Controls.Add(this.bConvertToEuro);
            this.Controls.Add(this.bConvertToPeseta);
            this.Controls.Add(this.tPesetas);
            this.Controls.Add(this.tEuros);
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
        private System.Windows.Forms.TextBox tEuros;
        private System.Windows.Forms.TextBox tPesetas;
        private System.Windows.Forms.Button bConvertToPeseta;
        private System.Windows.Forms.Button bConvertToEuro;
    }
}

