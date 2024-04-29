namespace Exercise_3_List
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
            this.btnReadList = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnCopyPrimeNum = new System.Windows.Forms.Button();
            this.btnMovePrimeNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadList
            // 
            this.btnReadList.Location = new System.Drawing.Point(91, 73);
            this.btnReadList.Name = "btnReadList";
            this.btnReadList.Size = new System.Drawing.Size(157, 70);
            this.btnReadList.TabIndex = 0;
            this.btnReadList.Text = "Read List";
            this.btnReadList.UseVisualStyleBackColor = true;
            this.btnReadList.Click += new System.EventHandler(this.btnReadList_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(91, 194);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(157, 70);
            this.btnShowList.TabIndex = 1;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnCopyPrimeNum
            // 
            this.btnCopyPrimeNum.Location = new System.Drawing.Point(324, 73);
            this.btnCopyPrimeNum.Name = "btnCopyPrimeNum";
            this.btnCopyPrimeNum.Size = new System.Drawing.Size(157, 70);
            this.btnCopyPrimeNum.TabIndex = 2;
            this.btnCopyPrimeNum.Text = "Copy prime numbers to another list";
            this.btnCopyPrimeNum.UseVisualStyleBackColor = true;
            this.btnCopyPrimeNum.Click += new System.EventHandler(this.btnCopyPrimeNum_Click);
            // 
            // btnMovePrimeNum
            // 
            this.btnMovePrimeNum.Location = new System.Drawing.Point(324, 194);
            this.btnMovePrimeNum.Name = "btnMovePrimeNum";
            this.btnMovePrimeNum.Size = new System.Drawing.Size(157, 70);
            this.btnMovePrimeNum.TabIndex = 3;
            this.btnMovePrimeNum.Text = "Move prime numbers to another list";
            this.btnMovePrimeNum.UseVisualStyleBackColor = true;
            this.btnMovePrimeNum.Click += new System.EventHandler(this.btnMovePrimeNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 360);
            this.Controls.Add(this.btnMovePrimeNum);
            this.Controls.Add(this.btnCopyPrimeNum);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnReadList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadList;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnCopyPrimeNum;
        private System.Windows.Forms.Button btnMovePrimeNum;
    }
}

