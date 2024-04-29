namespace Ejercicio_2
{
    partial class fCirculo
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
            this.btnCrearCirculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPosY);
            this.groupBox1.Controls.Add(this.txtRadio);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtPosX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCrearCirculo);
            this.groupBox1.Location = new System.Drawing.Point(70, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca datos del Círculo";
            // 
            // btnCrearCirculo
            // 
            this.btnCrearCirculo.Location = new System.Drawing.Point(96, 234);
            this.btnCrearCirculo.Name = "btnCrearCirculo";
            this.btnCrearCirculo.Size = new System.Drawing.Size(157, 39);
            this.btnCrearCirculo.TabIndex = 0;
            this.btnCrearCirculo.Text = "Añadir Círculo";
            this.btnCrearCirculo.UseVisualStyleBackColor = true;
            this.btnCrearCirculo.Click += new System.EventHandler(this.btnAnyadirCirculo_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posición Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Radio:";
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
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(127, 51);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(100, 20);
            this.txtPosX.TabIndex = 5;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(127, 148);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 6;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(127, 191);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 7;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(127, 100);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(100, 20);
            this.txtPosY.TabIndex = 8;
            // 
            // fCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 463);
            this.Controls.Add(this.groupBox1);
            this.Name = "fCirculo";
            this.Text = "fCirculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearCirculo;
    }
}