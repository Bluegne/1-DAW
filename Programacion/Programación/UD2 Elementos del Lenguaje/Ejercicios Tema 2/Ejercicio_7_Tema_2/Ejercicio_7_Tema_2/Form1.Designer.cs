namespace Ejercicio_7_Tema_2
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
            this.tAltura = new System.Windows.Forms.TextBox();
            this.cms = new System.Windows.Forms.Label();
            this.bResultado = new System.Windows.Forms.Button();
            this.lMuestraAltura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura:";
            // 
            // tAltura
            // 
            this.tAltura.Location = new System.Drawing.Point(161, 96);
            this.tAltura.Name = "tAltura";
            this.tAltura.Size = new System.Drawing.Size(100, 20);
            this.tAltura.TabIndex = 1;
            // 
            // cms
            // 
            this.cms.AutoSize = true;
            this.cms.Location = new System.Drawing.Point(267, 99);
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(26, 13);
            this.cms.TabIndex = 2;
            this.cms.Text = "cms";
            // 
            // bResultado
            // 
            this.bResultado.Location = new System.Drawing.Point(270, 148);
            this.bResultado.Name = "bResultado";
            this.bResultado.Size = new System.Drawing.Size(75, 23);
            this.bResultado.TabIndex = 3;
            this.bResultado.Text = "Resultado";
            this.bResultado.UseVisualStyleBackColor = true;
            this.bResultado.Click += new System.EventHandler(this.bResultado_Click);
            // 
            // lMuestraAltura
            // 
            this.lMuestraAltura.AutoSize = true;
            this.lMuestraAltura.Location = new System.Drawing.Point(165, 220);
            this.lMuestraAltura.Name = "lMuestraAltura";
            this.lMuestraAltura.Size = new System.Drawing.Size(0, 13);
            this.lMuestraAltura.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 399);
            this.Controls.Add(this.lMuestraAltura);
            this.Controls.Add(this.bResultado);
            this.Controls.Add(this.cms);
            this.Controls.Add(this.tAltura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tAltura;
        private System.Windows.Forms.Label cms;
        private System.Windows.Forms.Button bResultado;
        private System.Windows.Forms.Label lMuestraAltura;
    }
}

