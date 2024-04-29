namespace Ejercicio_24_Tema_3
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
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(199, 111);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(147, 22);
            this.txtUserNumber.TabIndex = 1;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(199, 187);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(147, 53);
            this.btnShowTable.TabIndex = 2;
            this.btnShowTable.Text = "Show Table";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 367);
            this.Controls.Add(this.btnShowTable);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Button btnShowTable;
    }
}

