namespace Ejercicio_8_Tema_3
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
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadirTexto = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(203, 107);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(153, 22);
            this.txtTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Texto:";
            // 
            // btnAñadirTexto
            // 
            this.btnAñadirTexto.Location = new System.Drawing.Point(221, 169);
            this.btnAñadirTexto.Name = "btnAñadirTexto";
            this.btnAñadirTexto.Size = new System.Drawing.Size(108, 23);
            this.btnAñadirTexto.TabIndex = 2;
            this.btnAñadirTexto.Text = "Añadir Texto";
            this.btnAñadirTexto.UseVisualStyleBackColor = true;
            this.btnAñadirTexto.Click += new System.EventHandler(this.btnAñadirTexto_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(136, 252);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(0, 16);
            this.lblLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnAñadirTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAñadirTexto;
        private System.Windows.Forms.Label lblLabel;
    }
}

