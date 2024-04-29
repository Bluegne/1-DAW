namespace Ejercicio_2_Tema_2
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
            this.tNumeroRecogido = new System.Windows.Forms.TextBox();
            this.bMostrarEntero = new System.Windows.Forms.Button();
            this.bMostrarReal = new System.Windows.Forms.Button();
            this.bMostrarFloat = new System.Windows.Forms.Button();
            this.bValor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // tNumeroRecogido
            // 
            this.tNumeroRecogido.Location = new System.Drawing.Point(253, 60);
            this.tNumeroRecogido.Name = "tNumeroRecogido";
            this.tNumeroRecogido.Size = new System.Drawing.Size(156, 20);
            this.tNumeroRecogido.TabIndex = 1;
            this.tNumeroRecogido.TextChanged += new System.EventHandler(this.tNumeroRecogido_TextChanged);
            // 
            // bMostrarEntero
            // 
            this.bMostrarEntero.Location = new System.Drawing.Point(253, 109);
            this.bMostrarEntero.Name = "bMostrarEntero";
            this.bMostrarEntero.Size = new System.Drawing.Size(156, 39);
            this.bMostrarEntero.TabIndex = 2;
            this.bMostrarEntero.Text = "Mostrar Número Entero";
            this.bMostrarEntero.UseVisualStyleBackColor = true;
            this.bMostrarEntero.Click += new System.EventHandler(this.bMostrarEntero_Click);
            // 
            // bMostrarReal
            // 
            this.bMostrarReal.Location = new System.Drawing.Point(253, 169);
            this.bMostrarReal.Name = "bMostrarReal";
            this.bMostrarReal.Size = new System.Drawing.Size(156, 37);
            this.bMostrarReal.TabIndex = 3;
            this.bMostrarReal.Text = "Mostrar Número Double";
            this.bMostrarReal.UseVisualStyleBackColor = true;
            this.bMostrarReal.Click += new System.EventHandler(this.bMostrarReal_Click);
            // 
            // bMostrarFloat
            // 
            this.bMostrarFloat.Location = new System.Drawing.Point(253, 228);
            this.bMostrarFloat.Name = "bMostrarFloat";
            this.bMostrarFloat.Size = new System.Drawing.Size(156, 38);
            this.bMostrarFloat.TabIndex = 4;
            this.bMostrarFloat.Text = "Mostrar Número Float";
            this.bMostrarFloat.UseVisualStyleBackColor = true;
            this.bMostrarFloat.Click += new System.EventHandler(this.bMostrarFloat_Click);
            // 
            // bValor
            // 
            this.bValor.Location = new System.Drawing.Point(253, 285);
            this.bValor.Name = "bValor";
            this.bValor.Size = new System.Drawing.Size(156, 39);
            this.bValor.TabIndex = 5;
            this.bValor.Text = "Valor";
            this.bValor.UseVisualStyleBackColor = true;
            this.bValor.Click += new System.EventHandler(this.bValor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.bValor);
            this.Controls.Add(this.bMostrarFloat);
            this.Controls.Add(this.bMostrarReal);
            this.Controls.Add(this.bMostrarEntero);
            this.Controls.Add(this.tNumeroRecogido);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNumeroRecogido;
        private System.Windows.Forms.Button bMostrarEntero;
        private System.Windows.Forms.Button bMostrarReal;
        private System.Windows.Forms.Button bMostrarFloat;
        private System.Windows.Forms.Button bValor;
    }
}

