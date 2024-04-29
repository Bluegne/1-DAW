namespace Ejercicio_2
{
    partial class fInicial
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
            this.btnAgregarHexagono = new System.Windows.Forms.Button();
            this.btnAgregarRectangulo = new System.Windows.Forms.Button();
            this.btnAgregarTriangulo = new System.Windows.Forms.Button();
            this.btnAgregarCuadrado = new System.Windows.Forms.Button();
            this.btnAgregarCirculo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarHexagonos = new System.Windows.Forms.Button();
            this.btnMostrarRectangulos = new System.Windows.Forms.Button();
            this.btnMostrarTriangulos = new System.Windows.Forms.Button();
            this.btnMostrarCuadrados = new System.Windows.Forms.Button();
            this.btnMostrarCirculos = new System.Windows.Forms.Button();
            this.btnMostrarFiguras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarHexagono);
            this.groupBox1.Controls.Add(this.btnAgregarRectangulo);
            this.groupBox1.Controls.Add(this.btnAgregarTriangulo);
            this.groupBox1.Controls.Add(this.btnAgregarCuadrado);
            this.groupBox1.Controls.Add(this.btnAgregarCirculo);
            this.groupBox1.Location = new System.Drawing.Point(77, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregarHexagono
            // 
            this.btnAgregarHexagono.Location = new System.Drawing.Point(31, 256);
            this.btnAgregarHexagono.Name = "btnAgregarHexagono";
            this.btnAgregarHexagono.Size = new System.Drawing.Size(85, 43);
            this.btnAgregarHexagono.TabIndex = 4;
            this.btnAgregarHexagono.Text = "Introducir Hexágono";
            this.btnAgregarHexagono.UseVisualStyleBackColor = true;
            this.btnAgregarHexagono.Click += new System.EventHandler(this.btnAgregarHexagono_Click);
            // 
            // btnAgregarRectangulo
            // 
            this.btnAgregarRectangulo.Location = new System.Drawing.Point(31, 196);
            this.btnAgregarRectangulo.Name = "btnAgregarRectangulo";
            this.btnAgregarRectangulo.Size = new System.Drawing.Size(85, 41);
            this.btnAgregarRectangulo.TabIndex = 3;
            this.btnAgregarRectangulo.Text = "Introducir Rectángulo";
            this.btnAgregarRectangulo.UseVisualStyleBackColor = true;
            this.btnAgregarRectangulo.Click += new System.EventHandler(this.btnAgregarRectangulo_Click);
            // 
            // btnAgregarTriangulo
            // 
            this.btnAgregarTriangulo.Location = new System.Drawing.Point(31, 140);
            this.btnAgregarTriangulo.Name = "btnAgregarTriangulo";
            this.btnAgregarTriangulo.Size = new System.Drawing.Size(85, 40);
            this.btnAgregarTriangulo.TabIndex = 2;
            this.btnAgregarTriangulo.Text = "Introducir Triángulo";
            this.btnAgregarTriangulo.UseVisualStyleBackColor = true;
            this.btnAgregarTriangulo.Click += new System.EventHandler(this.btnAgregarTriangulo_Click);
            // 
            // btnAgregarCuadrado
            // 
            this.btnAgregarCuadrado.Location = new System.Drawing.Point(31, 81);
            this.btnAgregarCuadrado.Name = "btnAgregarCuadrado";
            this.btnAgregarCuadrado.Size = new System.Drawing.Size(85, 39);
            this.btnAgregarCuadrado.TabIndex = 1;
            this.btnAgregarCuadrado.Text = "Introducir Cuadrado";
            this.btnAgregarCuadrado.UseVisualStyleBackColor = true;
            this.btnAgregarCuadrado.Click += new System.EventHandler(this.btnAgregarCuadrado_Click);
            // 
            // btnAgregarCirculo
            // 
            this.btnAgregarCirculo.Location = new System.Drawing.Point(31, 24);
            this.btnAgregarCirculo.Name = "btnAgregarCirculo";
            this.btnAgregarCirculo.Size = new System.Drawing.Size(85, 41);
            this.btnAgregarCirculo.TabIndex = 0;
            this.btnAgregarCirculo.Text = "Introducir Círculo";
            this.btnAgregarCirculo.UseVisualStyleBackColor = true;
            this.btnAgregarCirculo.Click += new System.EventHandler(this.btnAgregarCirculo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarHexagonos);
            this.groupBox2.Controls.Add(this.btnMostrarRectangulos);
            this.groupBox2.Controls.Add(this.btnMostrarTriangulos);
            this.groupBox2.Controls.Add(this.btnMostrarCuadrados);
            this.groupBox2.Controls.Add(this.btnMostrarCirculos);
            this.groupBox2.Controls.Add(this.btnMostrarFiguras);
            this.groupBox2.Location = new System.Drawing.Point(282, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnMostrarHexagonos
            // 
            this.btnMostrarHexagonos.Location = new System.Drawing.Point(19, 265);
            this.btnMostrarHexagonos.Name = "btnMostrarHexagonos";
            this.btnMostrarHexagonos.Size = new System.Drawing.Size(117, 34);
            this.btnMostrarHexagonos.TabIndex = 7;
            this.btnMostrarHexagonos.Text = "Mostrar Hexágonos";
            this.btnMostrarHexagonos.UseVisualStyleBackColor = true;
            this.btnMostrarHexagonos.Click += new System.EventHandler(this.btnMostrarHexagonos_Click);
            // 
            // btnMostrarRectangulos
            // 
            this.btnMostrarRectangulos.Location = new System.Drawing.Point(19, 223);
            this.btnMostrarRectangulos.Name = "btnMostrarRectangulos";
            this.btnMostrarRectangulos.Size = new System.Drawing.Size(117, 34);
            this.btnMostrarRectangulos.TabIndex = 6;
            this.btnMostrarRectangulos.Text = "Mostrar Rectángulos";
            this.btnMostrarRectangulos.UseVisualStyleBackColor = true;
            this.btnMostrarRectangulos.Click += new System.EventHandler(this.btnMostrarRectangulos_Click);
            // 
            // btnMostrarTriangulos
            // 
            this.btnMostrarTriangulos.Location = new System.Drawing.Point(19, 182);
            this.btnMostrarTriangulos.Name = "btnMostrarTriangulos";
            this.btnMostrarTriangulos.Size = new System.Drawing.Size(117, 34);
            this.btnMostrarTriangulos.TabIndex = 5;
            this.btnMostrarTriangulos.Text = "Mostrar Triángulos";
            this.btnMostrarTriangulos.UseVisualStyleBackColor = true;
            this.btnMostrarTriangulos.Click += new System.EventHandler(this.btnMostrarTriangulos_Click);
            // 
            // btnMostrarCuadrados
            // 
            this.btnMostrarCuadrados.Location = new System.Drawing.Point(19, 142);
            this.btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            this.btnMostrarCuadrados.Size = new System.Drawing.Size(117, 34);
            this.btnMostrarCuadrados.TabIndex = 4;
            this.btnMostrarCuadrados.Text = "Mostrar Cuadrados";
            this.btnMostrarCuadrados.UseVisualStyleBackColor = true;
            this.btnMostrarCuadrados.Click += new System.EventHandler(this.btnMostrarCuadrados_Click);
            // 
            // btnMostrarCirculos
            // 
            this.btnMostrarCirculos.Location = new System.Drawing.Point(19, 102);
            this.btnMostrarCirculos.Name = "btnMostrarCirculos";
            this.btnMostrarCirculos.Size = new System.Drawing.Size(117, 33);
            this.btnMostrarCirculos.TabIndex = 3;
            this.btnMostrarCirculos.Text = "Mostrar Círculos";
            this.btnMostrarCirculos.UseVisualStyleBackColor = true;
            this.btnMostrarCirculos.Click += new System.EventHandler(this.btnMostrarCirculos_Click);
            // 
            // btnMostrarFiguras
            // 
            this.btnMostrarFiguras.Location = new System.Drawing.Point(19, 24);
            this.btnMostrarFiguras.Name = "btnMostrarFiguras";
            this.btnMostrarFiguras.Size = new System.Drawing.Size(117, 67);
            this.btnMostrarFiguras.TabIndex = 2;
            this.btnMostrarFiguras.Text = "Mostrar todas las figuras";
            this.btnMostrarFiguras.UseVisualStyleBackColor = true;
            this.btnMostrarFiguras.Click += new System.EventHandler(this.btnMostrarFiguras_Click);
            // 
            // fInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fInicial";
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
        private System.Windows.Forms.Button btnAgregarRectangulo;
        private System.Windows.Forms.Button btnAgregarTriangulo;
        private System.Windows.Forms.Button btnMostrarRectangulos;
        private System.Windows.Forms.Button btnMostrarTriangulos;
        private System.Windows.Forms.Button btnAgregarHexagono;
        private System.Windows.Forms.Button btnMostrarHexagonos;
    }
}

