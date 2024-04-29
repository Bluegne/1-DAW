namespace Ejercicio_12_Tema_2
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
            this.label5 = new System.Windows.Forms.Label();
            this.tProd1 = new System.Windows.Forms.TextBox();
            this.tProd3 = new System.Windows.Forms.TextBox();
            this.tProd2 = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IVA 21%";
            // 
            // tProd1
            // 
            this.tProd1.Location = new System.Drawing.Point(212, 71);
            this.tProd1.Name = "tProd1";
            this.tProd1.Size = new System.Drawing.Size(105, 20);
            this.tProd1.TabIndex = 5;
            // 
            // tProd3
            // 
            this.tProd3.Location = new System.Drawing.Point(212, 146);
            this.tProd3.Name = "tProd3";
            this.tProd3.Size = new System.Drawing.Size(105, 20);
            this.tProd3.TabIndex = 6;
            // 
            // tProd2
            // 
            this.tProd2.Location = new System.Drawing.Point(212, 108);
            this.tProd2.Name = "tProd2";
            this.tProd2.Size = new System.Drawing.Size(105, 20);
            this.tProd2.TabIndex = 7;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(212, 221);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(105, 38);
            this.bCalcular.TabIndex = 11;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 375);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tProd2);
            this.Controls.Add(this.tProd3);
            this.Controls.Add(this.tProd1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tProd1;
        private System.Windows.Forms.TextBox tProd3;
        private System.Windows.Forms.TextBox tProd2;
        private System.Windows.Forms.Button bCalcular;
    }
}

