﻿namespace Ejercicio_5_Tema_2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tNumero1 = new System.Windows.Forms.TextBox();
            this.tNumero2 = new System.Windows.Forms.TextBox();
            this.tResultado = new System.Windows.Forms.TextBox();
            this.bSuma = new System.Windows.Forms.Button();
            this.bResta = new System.Windows.Forms.Button();
            this.bMultiplicar = new System.Windows.Forms.Button();
            this.bResto = new System.Windows.Forms.Button();
            this.bDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            // 
            // tNumero1
            // 
            this.tNumero1.Location = new System.Drawing.Point(189, 65);
            this.tNumero1.Name = "tNumero1";
            this.tNumero1.Size = new System.Drawing.Size(100, 20);
            this.tNumero1.TabIndex = 3;
            // 
            // tNumero2
            // 
            this.tNumero2.Location = new System.Drawing.Point(189, 119);
            this.tNumero2.Name = "tNumero2";
            this.tNumero2.Size = new System.Drawing.Size(100, 20);
            this.tNumero2.TabIndex = 4;
            // 
            // tResultado
            // 
            this.tResultado.Location = new System.Drawing.Point(189, 201);
            this.tResultado.Name = "tResultado";
            this.tResultado.Size = new System.Drawing.Size(100, 20);
            this.tResultado.TabIndex = 5;
            // 
            // bSuma
            // 
            this.bSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSuma.Location = new System.Drawing.Point(370, 52);
            this.bSuma.Name = "bSuma";
            this.bSuma.Size = new System.Drawing.Size(47, 50);
            this.bSuma.TabIndex = 6;
            this.bSuma.Text = "+";
            this.bSuma.UseVisualStyleBackColor = true;
            this.bSuma.Click += new System.EventHandler(this.bSuma_Click);
            // 
            // bResta
            // 
            this.bResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResta.Location = new System.Drawing.Point(449, 52);
            this.bResta.Name = "bResta";
            this.bResta.Size = new System.Drawing.Size(48, 50);
            this.bResta.TabIndex = 7;
            this.bResta.Text = "-";
            this.bResta.UseVisualStyleBackColor = true;
            this.bResta.Click += new System.EventHandler(this.bResta_Click);
            // 
            // bMultiplicar
            // 
            this.bMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMultiplicar.Location = new System.Drawing.Point(370, 122);
            this.bMultiplicar.Name = "bMultiplicar";
            this.bMultiplicar.Size = new System.Drawing.Size(47, 46);
            this.bMultiplicar.TabIndex = 8;
            this.bMultiplicar.Text = "*";
            this.bMultiplicar.UseVisualStyleBackColor = true;
            this.bMultiplicar.Click += new System.EventHandler(this.bMultiplicar_Click);
            // 
            // bResto
            // 
            this.bResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResto.Location = new System.Drawing.Point(413, 188);
            this.bResto.Name = "bResto";
            this.bResto.Size = new System.Drawing.Size(47, 43);
            this.bResto.TabIndex = 9;
            this.bResto.Text = "%";
            this.bResto.UseVisualStyleBackColor = true;
            this.bResto.Click += new System.EventHandler(this.bResto_Click);
            // 
            // bDividir
            // 
            this.bDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDividir.Location = new System.Drawing.Point(449, 122);
            this.bDividir.Name = "bDividir";
            this.bDividir.Size = new System.Drawing.Size(48, 46);
            this.bDividir.TabIndex = 10;
            this.bDividir.Text = "/";
            this.bDividir.UseVisualStyleBackColor = true;
            this.bDividir.Click += new System.EventHandler(this.bDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.bDividir);
            this.Controls.Add(this.bResto);
            this.Controls.Add(this.bMultiplicar);
            this.Controls.Add(this.bResta);
            this.Controls.Add(this.bSuma);
            this.Controls.Add(this.tResultado);
            this.Controls.Add(this.tNumero2);
            this.Controls.Add(this.tNumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNumero1;
        private System.Windows.Forms.TextBox tNumero2;
        private System.Windows.Forms.TextBox tResultado;
        private System.Windows.Forms.Button bSuma;
        private System.Windows.Forms.Button bResta;
        private System.Windows.Forms.Button bMultiplicar;
        private System.Windows.Forms.Button bResto;
        private System.Windows.Forms.Button bDividir;
    }
}

