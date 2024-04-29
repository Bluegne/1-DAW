namespace Ejercicio_4_Tema_4
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
            this.txtNumUsuario = new System.Windows.Forms.TextBox();
            this.btnMostrarValorAbs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // txtNumUsuario
            // 
            this.txtNumUsuario.Location = new System.Drawing.Point(175, 93);
            this.txtNumUsuario.Name = "txtNumUsuario";
            this.txtNumUsuario.Size = new System.Drawing.Size(139, 20);
            this.txtNumUsuario.TabIndex = 1;
            // 
            // btnMostrarValorAbs
            // 
            this.btnMostrarValorAbs.Location = new System.Drawing.Point(167, 158);
            this.btnMostrarValorAbs.Name = "btnMostrarValorAbs";
            this.btnMostrarValorAbs.Size = new System.Drawing.Size(147, 50);
            this.btnMostrarValorAbs.TabIndex = 2;
            this.btnMostrarValorAbs.Text = "Mostrar Valor Absoluto";
            this.btnMostrarValorAbs.UseVisualStyleBackColor = true;
            this.btnMostrarValorAbs.Click += new System.EventHandler(this.btnMostrarValorAbs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 326);
            this.Controls.Add(this.btnMostrarValorAbs);
            this.Controls.Add(this.txtNumUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumUsuario;
        private System.Windows.Forms.Button btnMostrarValorAbs;
    }
}

