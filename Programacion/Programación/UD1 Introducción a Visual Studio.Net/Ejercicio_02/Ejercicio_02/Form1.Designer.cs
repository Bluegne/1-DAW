namespace Ejercicio_02
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
            this.titulo1 = new System.Windows.Forms.Label();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.tCuadroTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo1.Location = new System.Drawing.Point(179, 38);
            this.titulo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(221, 29);
            this.titulo1.TabIndex = 0;
            this.titulo1.Text = "Mi Primer Formulario";
            this.titulo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.boton1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(148, 139);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(284, 23);
            this.boton1.TabIndex = 1;
            this.boton1.Text = "Muestra el Contenido del Cuadro Texto";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(148, 186);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(284, 23);
            this.boton2.TabIndex = 2;
            this.boton2.Text = "Cambia el Color del Formulario";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(148, 231);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(284, 23);
            this.boton3.TabIndex = 3;
            this.boton3.Text = "Cambia el Color del Texto del Cuadro";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // tCuadroTexto
            // 
            this.tCuadroTexto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCuadroTexto.Location = new System.Drawing.Point(148, 87);
            this.tCuadroTexto.Name = "tCuadroTexto";
            this.tCuadroTexto.Size = new System.Drawing.Size(284, 23);
            this.tCuadroTexto.TabIndex = 4;
            this.tCuadroTexto.Text = "Escribir aquí";
            this.tCuadroTexto.TextChanged += new System.EventHandler(this.tCuadroTexto_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tCuadroTexto);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.titulo1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.TextBox tCuadroTexto;
    }
}

