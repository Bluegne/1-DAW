namespace Ejercicio_13_Tema_3
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
            this.btnMostrarWhile = new System.Windows.Forms.Button();
            this.btnMostrarDoWhile = new System.Windows.Forms.Button();
            this.btnMostrarFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // txtNumUsuario
            // 
            this.txtNumUsuario.Location = new System.Drawing.Point(240, 128);
            this.txtNumUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumUsuario.Name = "txtNumUsuario";
            this.txtNumUsuario.Size = new System.Drawing.Size(191, 22);
            this.txtNumUsuario.TabIndex = 1;
            // 
            // btnMostrarWhile
            // 
            this.btnMostrarWhile.Location = new System.Drawing.Point(227, 187);
            this.btnMostrarWhile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarWhile.Name = "btnMostrarWhile";
            this.btnMostrarWhile.Size = new System.Drawing.Size(216, 50);
            this.btnMostrarWhile.TabIndex = 2;
            this.btnMostrarWhile.Text = "Mostrar Pares (while)";
            this.btnMostrarWhile.UseVisualStyleBackColor = true;
            this.btnMostrarWhile.Click += new System.EventHandler(this.btnMostrarWhile_Click);
            // 
            // btnMostrarDoWhile
            // 
            this.btnMostrarDoWhile.Location = new System.Drawing.Point(227, 247);
            this.btnMostrarDoWhile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarDoWhile.Name = "btnMostrarDoWhile";
            this.btnMostrarDoWhile.Size = new System.Drawing.Size(216, 50);
            this.btnMostrarDoWhile.TabIndex = 3;
            this.btnMostrarDoWhile.Text = "Mostrar Pares (do while)";
            this.btnMostrarDoWhile.UseVisualStyleBackColor = true;
            this.btnMostrarDoWhile.Click += new System.EventHandler(this.btnMostrarDoWhile_Click);
            // 
            // btnMostrarFor
            // 
            this.btnMostrarFor.Location = new System.Drawing.Point(227, 305);
            this.btnMostrarFor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarFor.Name = "btnMostrarFor";
            this.btnMostrarFor.Size = new System.Drawing.Size(216, 50);
            this.btnMostrarFor.TabIndex = 4;
            this.btnMostrarFor.Text = "Mostrar Pares (for)";
            this.btnMostrarFor.UseVisualStyleBackColor = true;
            this.btnMostrarFor.Click += new System.EventHandler(this.btnMostrarFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 421);
            this.Controls.Add(this.btnMostrarFor);
            this.Controls.Add(this.btnMostrarDoWhile);
            this.Controls.Add(this.btnMostrarWhile);
            this.Controls.Add(this.txtNumUsuario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumUsuario;
        private System.Windows.Forms.Button btnMostrarWhile;
        private System.Windows.Forms.Button btnMostrarDoWhile;
        private System.Windows.Forms.Button btnMostrarFor;
    }
}

