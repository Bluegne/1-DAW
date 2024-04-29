namespace Ejercicio_14_Tema_2
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
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.bMayor = new System.Windows.Forms.Button();
            this.bMenor = new System.Windows.Forms.Button();
            this.bIgual = new System.Windows.Forms.Button();
            this.bNoIgual = new System.Windows.Forms.Button();
            this.lRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(186, 94);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(100, 20);
            this.tNum1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2:";
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(186, 207);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(100, 20);
            this.tNum2.TabIndex = 3;
            // 
            // bMayor
            // 
            this.bMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMayor.Location = new System.Drawing.Point(63, 144);
            this.bMayor.Name = "bMayor";
            this.bMayor.Size = new System.Drawing.Size(52, 40);
            this.bMayor.TabIndex = 4;
            this.bMayor.Text = ">";
            this.bMayor.UseVisualStyleBackColor = true;
            this.bMayor.Click += new System.EventHandler(this.bMayor_Click);
            // 
            // bMenor
            // 
            this.bMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMenor.Location = new System.Drawing.Point(148, 144);
            this.bMenor.Name = "bMenor";
            this.bMenor.Size = new System.Drawing.Size(52, 40);
            this.bMenor.TabIndex = 5;
            this.bMenor.Text = "<";
            this.bMenor.UseVisualStyleBackColor = true;
            this.bMenor.Click += new System.EventHandler(this.bMenor_Click);
            // 
            // bIgual
            // 
            this.bIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIgual.Location = new System.Drawing.Point(234, 144);
            this.bIgual.Name = "bIgual";
            this.bIgual.Size = new System.Drawing.Size(52, 40);
            this.bIgual.TabIndex = 6;
            this.bIgual.Text = "==";
            this.bIgual.UseVisualStyleBackColor = true;
            this.bIgual.Click += new System.EventHandler(this.bIgual_Click);
            // 
            // bNoIgual
            // 
            this.bNoIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNoIgual.Location = new System.Drawing.Point(319, 144);
            this.bNoIgual.Name = "bNoIgual";
            this.bNoIgual.Size = new System.Drawing.Size(52, 40);
            this.bNoIgual.TabIndex = 7;
            this.bNoIgual.Text = "!=";
            this.bNoIgual.UseVisualStyleBackColor = true;
            this.bNoIgual.Click += new System.EventHandler(this.bNoIgual_Click);
            // 
            // lRespuesta
            // 
            this.lRespuesta.AutoSize = true;
            this.lRespuesta.Location = new System.Drawing.Point(214, 266);
            this.lRespuesta.Name = "lRespuesta";
            this.lRespuesta.Size = new System.Drawing.Size(0, 13);
            this.lRespuesta.TabIndex = 8;
            this.lRespuesta.Click += new System.EventHandler(this.lRespuesta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 380);
            this.Controls.Add(this.lRespuesta);
            this.Controls.Add(this.bNoIgual);
            this.Controls.Add(this.bIgual);
            this.Controls.Add(this.bMenor);
            this.Controls.Add(this.bMayor);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.Button bMayor;
        private System.Windows.Forms.Button bMenor;
        private System.Windows.Forms.Button bIgual;
        private System.Windows.Forms.Button bNoIgual;
        private System.Windows.Forms.Label lRespuesta;
    }
}

