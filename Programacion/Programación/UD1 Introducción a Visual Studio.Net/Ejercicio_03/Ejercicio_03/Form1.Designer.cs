namespace Ejercicio_03
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
            this.bPulsado = new System.Windows.Forms.Label();
            this.tTexto = new System.Windows.Forms.TextBox();
            this.bBoton1 = new System.Windows.Forms.Button();
            this.bBoton2 = new System.Windows.Forms.Button();
            this.bBorrarTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPulsado
            // 
            this.bPulsado.AutoSize = true;
            this.bPulsado.Location = new System.Drawing.Point(98, 82);
            this.bPulsado.Name = "bPulsado";
            this.bPulsado.Size = new System.Drawing.Size(76, 13);
            this.bPulsado.TabIndex = 0;
            this.bPulsado.Text = "Botón Pulsado";
            this.bPulsado.Click += new System.EventHandler(this.bPulsado_Click);
            // 
            // tTexto
            // 
            this.tTexto.Location = new System.Drawing.Point(196, 79);
            this.tTexto.Name = "tTexto";
            this.tTexto.Size = new System.Drawing.Size(269, 20);
            this.tTexto.TabIndex = 1;
            this.tTexto.TextChanged += new System.EventHandler(this.tTexto_TextChanged);
            // 
            // bBoton1
            // 
            this.bBoton1.Location = new System.Drawing.Point(196, 153);
            this.bBoton1.Name = "bBoton1";
            this.bBoton1.Size = new System.Drawing.Size(75, 23);
            this.bBoton1.TabIndex = 2;
            this.bBoton1.Text = "Botón 1";
            this.bBoton1.UseVisualStyleBackColor = true;
            this.bBoton1.Click += new System.EventHandler(this.bBoton1_Click);
            // 
            // bBoton2
            // 
            this.bBoton2.Location = new System.Drawing.Point(196, 208);
            this.bBoton2.Name = "bBoton2";
            this.bBoton2.Size = new System.Drawing.Size(75, 23);
            this.bBoton2.TabIndex = 3;
            this.bBoton2.Text = "Botón 2";
            this.bBoton2.UseVisualStyleBackColor = true;
            this.bBoton2.Click += new System.EventHandler(this.bBoton2_Click);
            // 
            // bBorrarTexto
            // 
            this.bBorrarTexto.Location = new System.Drawing.Point(353, 179);
            this.bBorrarTexto.Name = "bBorrarTexto";
            this.bBorrarTexto.Size = new System.Drawing.Size(75, 23);
            this.bBorrarTexto.TabIndex = 4;
            this.bBorrarTexto.Text = "Borrar Texto";
            this.bBorrarTexto.UseVisualStyleBackColor = true;
            this.bBorrarTexto.Click += new System.EventHandler(this.bBorrarTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.bBorrarTexto);
            this.Controls.Add(this.bBoton2);
            this.Controls.Add(this.bBoton1);
            this.Controls.Add(this.tTexto);
            this.Controls.Add(this.bPulsado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bPulsado;
        private System.Windows.Forms.TextBox tTexto;
        private System.Windows.Forms.Button bBoton1;
        private System.Windows.Forms.Button bBoton2;
        private System.Windows.Forms.Button bBorrarTexto;
    }
}

