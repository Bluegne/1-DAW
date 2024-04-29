namespace Exercise_2_List
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
            this.btnCopyEvenNum = new System.Windows.Forms.Button();
            this.btnMoveEvenNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadList
            // 
            this.btnReadList.Location = new System.Drawing.Point(60, 61);
            this.btnReadList.Name = "btnReadList";
            this.btnReadList.Size = new System.Drawing.Size(142, 57);
            this.btnReadList.TabIndex = 0;
            this.btnReadList.Text = "Read List";
            this.btnReadList.UseVisualStyleBackColor = true;
            this.btnReadList.Click += new System.EventHandler(this.btnReadList_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(60, 179);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(142, 64);
            this.btnShowList.TabIndex = 1;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnCopyEvenNum
            // 
            this.btnCopyEvenNum.Location = new System.Drawing.Point(297, 61);
            this.btnCopyEvenNum.Name = "btnCopyEvenNum";
            this.btnCopyEvenNum.Size = new System.Drawing.Size(140, 57);
            this.btnCopyEvenNum.TabIndex = 2;
            this.btnCopyEvenNum.Text = "Copy even numbers to another list";
            this.btnCopyEvenNum.UseVisualStyleBackColor = true;
            this.btnCopyEvenNum.Click += new System.EventHandler(this.btnCopyEvenNum_Click);
            // 
            // btnMoveEvenNum
            // 
            this.btnMoveEvenNum.Location = new System.Drawing.Point(297, 179);
            this.btnMoveEvenNum.Name = "btnMoveEvenNum";
            this.btnMoveEvenNum.Size = new System.Drawing.Size(140, 64);
            this.btnMoveEvenNum.TabIndex = 3;
            this.btnMoveEvenNum.Text = "Move even numbers to another list";
            this.btnMoveEvenNum.UseVisualStyleBackColor = true;
            this.btnMoveEvenNum.Click += new System.EventHandler(this.btnMoveEvenNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 315);
            this.Controls.Add(this.btnMoveEvenNum);
            this.Controls.Add(this.btnCopyEvenNum);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnReadList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadList;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnCopyEvenNum;
        private System.Windows.Forms.Button btnMoveEvenNum;
    }
}

