namespace Ejercicio_2
{
    partial class fRectangulo
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
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearRectangulo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLadoB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPosY);
            this.groupBox1.Controls.Add(this.txtLadoA);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtPosX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCrearRectangulo);
            this.groupBox1.Location = new System.Drawing.Point(55, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 371);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca datos del Rectángulo";
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(127, 236);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(100, 20);
            this.txtLadoB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lado B:";
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(127, 104);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(100, 20);
            this.txtPosY.TabIndex = 8;
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(127, 191);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(100, 20);
            this.txtLadoA.TabIndex = 7;
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
            this.txtPosX.Location = new System.Drawing.Point(127, 59);
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
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lado A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posición Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posición X:";
            // 
            // btnCrearRectangulo
            // 
            this.btnCrearRectangulo.Location = new System.Drawing.Point(93, 287);
            this.btnCrearRectangulo.Name = "btnCrearRectangulo";
            this.btnCrearRectangulo.Size = new System.Drawing.Size(157, 39);
            this.btnCrearRectangulo.TabIndex = 0;
            this.btnCrearRectangulo.Text = "Añadir Rectángulo ";
            this.btnCrearRectangulo.UseVisualStyleBackColor = true;
            this.btnCrearRectangulo.Click += new System.EventHandler(this.btnCrearRectangulo_Click);
            // 
            // fRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 478);
            this.Controls.Add(this.groupBox1);
            this.Name = "fRectangulo";
            this.Text = "fRectangulo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearRectangulo;
    }
}