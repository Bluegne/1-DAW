namespace Ejercicio_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCuadrado = new System.Windows.Forms.Button();
            this.btnAgregarCirculo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarCuadrados = new System.Windows.Forms.Button();
            this.btnMostrarCirculos = new System.Windows.Forms.Button();
            this.btnMostrarFiguras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarCuadrado);
            this.groupBox1.Controls.Add(this.btnAgregarCirculo);
            this.groupBox1.Location = new System.Drawing.Point(65, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregarCuadrado
            // 
            this.btnAgregarCuadrado.Location = new System.Drawing.Point(42, 146);
            this.btnAgregarCuadrado.Name = "btnAgregarCuadrado";
            this.btnAgregarCuadrado.Size = new System.Drawing.Size(85, 52);
            this.btnAgregarCuadrado.TabIndex = 1;
            this.btnAgregarCuadrado.Text = "Introducir Cuadrado";
            this.btnAgregarCuadrado.UseVisualStyleBackColor = true;
            this.btnAgregarCuadrado.Click += new System.EventHandler(this.btnAgregarCuadrado_Click);
            // 
            // btnAgregarCirculo
            // 
            this.btnAgregarCirculo.Location = new System.Drawing.Point(42, 67);
            this.btnAgregarCirculo.Name = "btnAgregarCirculo";
            this.btnAgregarCirculo.Size = new System.Drawing.Size(85, 52);
            this.btnAgregarCirculo.TabIndex = 0;
            this.btnAgregarCirculo.Text = "Introducir Círculo";
            this.btnAgregarCirculo.UseVisualStyleBackColor = true;
            this.btnAgregarCirculo.Click += new System.EventHandler(this.btnAgregarCirculo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarCuadrados);
            this.groupBox2.Controls.Add(this.btnMostrarCirculos);
            this.groupBox2.Controls.Add(this.btnMostrarFiguras);
            this.groupBox2.Location = new System.Drawing.Point(282, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnMostrarCuadrados
            // 
            this.btnMostrarCuadrados.Location = new System.Drawing.Point(53, 189);
            this.btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            this.btnMostrarCuadrados.Size = new System.Drawing.Size(78, 47);
            this.btnMostrarCuadrados.TabIndex = 4;
            this.btnMostrarCuadrados.Text = "Mostrar Cuadrados";
            this.btnMostrarCuadrados.UseVisualStyleBackColor = true;
            this.btnMostrarCuadrados.Click += new System.EventHandler(this.btnMostrarCuadrados_Click);
            // 
            // btnMostrarCirculos
            // 
            this.btnMostrarCirculos.Location = new System.Drawing.Point(53, 121);
            this.btnMostrarCirculos.Name = "btnMostrarCirculos";
            this.btnMostrarCirculos.Size = new System.Drawing.Size(78, 47);
            this.btnMostrarCirculos.TabIndex = 3;
            this.btnMostrarCirculos.Text = "Mostrar Círculos";
            this.btnMostrarCirculos.UseVisualStyleBackColor = true;
            this.btnMostrarCirculos.Click += new System.EventHandler(this.btnMostrarCirculos_Click);
            // 
            // btnMostrarFiguras
            // 
            this.btnMostrarFiguras.Location = new System.Drawing.Point(53, 36);
            this.btnMostrarFiguras.Name = "btnMostrarFiguras";
            this.btnMostrarFiguras.Size = new System.Drawing.Size(78, 67);
            this.btnMostrarFiguras.TabIndex = 2;
            this.btnMostrarFiguras.Text = "Mostrar todas las figuras";
            this.btnMostrarFiguras.UseVisualStyleBackColor = true;
            this.btnMostrarFiguras.Click += new System.EventHandler(this.btnMostrarFiguras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCuadrado;
        private System.Windows.Forms.Button btnAgregarCirculo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarCuadrados;
        private System.Windows.Forms.Button btnMostrarCirculos;
        private System.Windows.Forms.Button btnMostrarFiguras;
    }
}

