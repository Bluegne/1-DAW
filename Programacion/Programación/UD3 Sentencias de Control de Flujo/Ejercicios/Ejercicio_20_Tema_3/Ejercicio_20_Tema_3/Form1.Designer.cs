namespace Ejercicio_20_Tema_3
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
            this.btnCalcularPotencia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaseUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exponente:";
            // 
            // txtNumUsuario
            // 
            this.txtNumUsuario.Location = new System.Drawing.Point(209, 169);
            this.txtNumUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumUsuario.Name = "txtNumUsuario";
            this.txtNumUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtNumUsuario.TabIndex = 1;
            // 
            // btnCalcularPotencia
            // 
            this.btnCalcularPotencia.Location = new System.Drawing.Point(200, 230);
            this.btnCalcularPotencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularPotencia.Name = "btnCalcularPotencia";
            this.btnCalcularPotencia.Size = new System.Drawing.Size(163, 43);
            this.btnCalcularPotencia.TabIndex = 2;
            this.btnCalcularPotencia.Text = "Calcular Potencia";
            this.btnCalcularPotencia.UseVisualStyleBackColor = true;
            this.btnCalcularPotencia.Click += new System.EventHandler(this.btnCalcularPotencia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número Base:";
            // 
            // txtBaseUsuario
            // 
            this.txtBaseUsuario.Location = new System.Drawing.Point(209, 127);
            this.txtBaseUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseUsuario.Name = "txtBaseUsuario";
            this.txtBaseUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtBaseUsuario.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 497);
            this.Controls.Add(this.txtBaseUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcularPotencia);
            this.Controls.Add(this.txtNumUsuario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumUsuario;
        private System.Windows.Forms.Button btnCalcularPotencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaseUsuario;
    }
}

