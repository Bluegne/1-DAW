namespace Ejercicio_01
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
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(222, 112);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 23);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "Primer Botón";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(222, 167);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(75, 23);
            this.boton2.TabIndex = 1;
            this.boton2.Text = "Segundo Botón";
            this.boton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio_01.Properties.Resources.OIP;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
    }
}

