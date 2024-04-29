namespace Ejemplo_01
{
    partial class FFormulario1
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
            this.bSegundo = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.lTexto = new System.Windows.Forms.Label();
            this.tCuadro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bSegundo
            // 
            this.bSegundo.Location = new System.Drawing.Point(188, 181);
            this.bSegundo.Name = "bSegundo";
            this.bSegundo.Size = new System.Drawing.Size(133, 55);
            this.bSegundo.TabIndex = 1;
            this.bSegundo.Text = "Segundo botón";
            this.bSegundo.UseVisualStyleBackColor = true;
            this.bSegundo.Click += new System.EventHandler(this.bSegundo_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Location = new System.Drawing.Point(188, 122);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(133, 53);
            this.bPrimero.TabIndex = 0;
            this.bPrimero.Text = "Primer botón";
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // lTexto
            // 
            this.lTexto.AutoSize = true;
            this.lTexto.Location = new System.Drawing.Point(188, 55);
            this.lTexto.Name = "lTexto";
            this.lTexto.Size = new System.Drawing.Size(34, 13);
            this.lTexto.TabIndex = 2;
            this.lTexto.Text = "Texto";
            this.lTexto.UseMnemonic = false;
            // 
            // tCuadro
            // 
            this.tCuadro.Location = new System.Drawing.Point(191, 86);
            this.tCuadro.Name = "tCuadro";
            this.tCuadro.Size = new System.Drawing.Size(100, 20);
            this.tCuadro.TabIndex = 3;
            // 
            // FFormulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tCuadro);
            this.Controls.Add(this.lTexto);
            this.Controls.Add(this.bSegundo);
            this.Controls.Add(this.bPrimero);
            this.Name = "FFormulario1";
            this.Text = "Ejercicio_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSegundo;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.Label lTexto;
        private System.Windows.Forms.TextBox tCuadro;
    }
}

