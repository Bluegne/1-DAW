namespace Ejercicio_21_Tema_3
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
            this.btnMostrarFor = new System.Windows.Forms.Button();
            this.btnMostrarWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número entre 1 y 15:";
            // 
            // txtNumUsuario
            // 
            this.txtNumUsuario.Location = new System.Drawing.Point(264, 117);
            this.txtNumUsuario.Name = "txtNumUsuario";
            this.txtNumUsuario.Size = new System.Drawing.Size(211, 22);
            this.txtNumUsuario.TabIndex = 1;
            // 
            // btnMostrarFor
            // 
            this.btnMostrarFor.Location = new System.Drawing.Point(112, 204);
            this.btnMostrarFor.Name = "btnMostrarFor";
            this.btnMostrarFor.Size = new System.Drawing.Size(186, 67);
            this.btnMostrarFor.TabIndex = 2;
            this.btnMostrarFor.Text = "Mostrar For";
            this.btnMostrarFor.UseVisualStyleBackColor = true;
            this.btnMostrarFor.Click += new System.EventHandler(this.btnMostrarFor_Click);
            // 
            // btnMostrarWhile
            // 
            this.btnMostrarWhile.Location = new System.Drawing.Point(343, 204);
            this.btnMostrarWhile.Name = "btnMostrarWhile";
            this.btnMostrarWhile.Size = new System.Drawing.Size(186, 67);
            this.btnMostrarWhile.TabIndex = 3;
            this.btnMostrarWhile.Text = "Mostrar While";
            this.btnMostrarWhile.UseVisualStyleBackColor = true;
            this.btnMostrarWhile.Click += new System.EventHandler(this.btnMostrarWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.btnMostrarWhile);
            this.Controls.Add(this.btnMostrarFor);
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
        private System.Windows.Forms.Button btnMostrarFor;
        private System.Windows.Forms.Button btnMostrarWhile;
    }
}

