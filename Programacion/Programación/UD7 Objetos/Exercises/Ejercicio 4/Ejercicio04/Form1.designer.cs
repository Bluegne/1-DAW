namespace Ejercicio04
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bNuevo = new System.Windows.Forms.Button();
            this.bMostrar = new System.Windows.Forms.Button();
            this.bAnyadir = new System.Windows.Forms.Button();
            this.bCumpleaños = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(94, 62);
            this.bNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(243, 51);
            this.bNuevo.TabIndex = 0;
            this.bNuevo.Text = "Nuevo Empleado";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(375, 62);
            this.bMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(242, 52);
            this.bMostrar.TabIndex = 1;
            this.bMostrar.Text = "Mostrar Lista Empleados";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // bAnyadir
            // 
            this.bAnyadir.Location = new System.Drawing.Point(375, 186);
            this.bAnyadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAnyadir.Name = "bAnyadir";
            this.bAnyadir.Size = new System.Drawing.Size(238, 55);
            this.bAnyadir.TabIndex = 2;
            this.bAnyadir.Text = "Añadir Venta";
            this.bAnyadir.UseVisualStyleBackColor = true;
            this.bAnyadir.Click += new System.EventHandler(this.bAnyadir_Click);
            // 
            // bCumpleaños
            // 
            this.bCumpleaños.Location = new System.Drawing.Point(98, 186);
            this.bCumpleaños.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCumpleaños.Name = "bCumpleaños";
            this.bCumpleaños.Size = new System.Drawing.Size(238, 54);
            this.bCumpleaños.TabIndex = 3;
            this.bCumpleaños.Text = "Cumpleaños Empleado";
            this.bCumpleaños.UseVisualStyleBackColor = true;
            this.bCumpleaños.Click += new System.EventHandler(this.bCumpleaños_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 351);
            this.Controls.Add(this.bCumpleaños);
            this.Controls.Add(this.bAnyadir);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.bNuevo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Ejercicio 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bMostrar;
        private System.Windows.Forms.Button bAnyadir;
        private System.Windows.Forms.Button bCumpleaños;
    }
}

