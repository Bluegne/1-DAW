namespace Ejercicio_2
{
    partial class fCuadrado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearCuadrado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPosY);
            this.groupBox1.Controls.Add(this.txtLado);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtPosX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCrearCuadrado);
            this.groupBox1.Location = new System.Drawing.Point(74, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca datos del Cuadrado";
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(127, 100);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(100, 20);
            this.txtPosY.TabIndex = 8;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(127, 191);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(127, 148);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 6;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(127, 51);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(100, 20);
            this.txtPosX.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posición Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posición X:";
            // 
            // btnCrearCuadrado
            // 
            this.btnCrearCuadrado.Location = new System.Drawing.Point(96, 234);
            this.btnCrearCuadrado.Name = "btnCrearCuadrado";
            this.btnCrearCuadrado.Size = new System.Drawing.Size(157, 39);
            this.btnCrearCuadrado.TabIndex = 0;
            this.btnCrearCuadrado.Text = "Añadir Cuadrado";
            this.btnCrearCuadrado.UseVisualStyleBackColor = true;
            this.btnCrearCuadrado.Click += new System.EventHandler(this.btnCrearCuadrado_Click);
            // 
            // fCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "fCuadrado";
            this.Text = "fCuadrado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearCuadrado;
    }
}