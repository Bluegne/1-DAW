﻿namespace Ejercicio_19_Tema_3
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
            this.btnMostrarFactorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrarFactorial
            // 
            this.btnMostrarFactorial.Location = new System.Drawing.Point(163, 186);
            this.btnMostrarFactorial.Name = "btnMostrarFactorial";
            this.btnMostrarFactorial.Size = new System.Drawing.Size(114, 37);
            this.btnMostrarFactorial.TabIndex = 0;
            this.btnMostrarFactorial.Text = "Mostrar Factorial";
            this.btnMostrarFactorial.UseMnemonic = false;
            this.btnMostrarFactorial.UseVisualStyleBackColor = true;
            this.btnMostrarFactorial.Click += new System.EventHandler(this.btnMostrarFactorial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número:";
            // 
            // txtNumUsuario
            // 
            this.txtNumUsuario.Location = new System.Drawing.Point(174, 114);
            this.txtNumUsuario.Name = "txtNumUsuario";
            this.txtNumUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNumUsuario.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 364);
            this.Controls.Add(this.txtNumUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarFactorial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumUsuario;
    }
}

