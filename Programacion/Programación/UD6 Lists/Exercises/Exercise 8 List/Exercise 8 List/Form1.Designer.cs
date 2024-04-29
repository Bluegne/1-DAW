namespace Exercise_8_List
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
            this.btnReadWinningNum = new System.Windows.Forms.Button();
            this.btnReadUserNum = new System.Windows.Forms.Button();
            this.btnCheckResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadWinningNum
            // 
            this.btnReadWinningNum.Location = new System.Drawing.Point(205, 71);
            this.btnReadWinningNum.Name = "btnReadWinningNum";
            this.btnReadWinningNum.Size = new System.Drawing.Size(130, 63);
            this.btnReadWinningNum.TabIndex = 0;
            this.btnReadWinningNum.Text = "Read Primitiva";
            this.btnReadWinningNum.UseVisualStyleBackColor = true;
            this.btnReadWinningNum.Click += new System.EventHandler(this.btnReadWinningNum_Click);
            // 
            // btnReadUserNum
            // 
            this.btnReadUserNum.Location = new System.Drawing.Point(121, 162);
            this.btnReadUserNum.Name = "btnReadUserNum";
            this.btnReadUserNum.Size = new System.Drawing.Size(128, 63);
            this.btnReadUserNum.TabIndex = 1;
            this.btnReadUserNum.Text = "Read User Numbers";
            this.btnReadUserNum.UseVisualStyleBackColor = true;
            this.btnReadUserNum.Click += new System.EventHandler(this.btnReadUserNum_Click);
            // 
            // btnCheckResults
            // 
            this.btnCheckResults.Location = new System.Drawing.Point(292, 162);
            this.btnCheckResults.Name = "btnCheckResults";
            this.btnCheckResults.Size = new System.Drawing.Size(128, 63);
            this.btnCheckResults.TabIndex = 3;
            this.btnCheckResults.Text = "Check Result";
            this.btnCheckResults.UseVisualStyleBackColor = true;
            this.btnCheckResults.Click += new System.EventHandler(this.btnCheckResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 329);
            this.Controls.Add(this.btnCheckResults);
            this.Controls.Add(this.btnReadUserNum);
            this.Controls.Add(this.btnReadWinningNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadWinningNum;
        private System.Windows.Forms.Button btnReadUserNum;
        private System.Windows.Forms.Button btnCheckResults;
    }
}

