namespace Exercise_5_List
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMergeAndMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadList
            // 
            this.btnReadList.Location = new System.Drawing.Point(92, 60);
            this.btnReadList.Name = "btnReadList";
            this.btnReadList.Size = new System.Drawing.Size(169, 63);
            this.btnReadList.TabIndex = 0;
            this.btnReadList.Text = "Read Numbers";
            this.btnReadList.UseVisualStyleBackColor = true;
            this.btnReadList.Click += new System.EventHandler(this.btnReadList_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(92, 143);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(169, 63);
            this.btnShowList.TabIndex = 1;
            this.btnShowList.Text = "Show List ";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(298, 60);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(169, 63);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Merge and Sort List";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMergeAndMove
            // 
            this.btnMergeAndMove.Location = new System.Drawing.Point(298, 143);
            this.btnMergeAndMove.Name = "btnMergeAndMove";
            this.btnMergeAndMove.Size = new System.Drawing.Size(169, 63);
            this.btnMergeAndMove.TabIndex = 3;
            this.btnMergeAndMove.Text = "Merge and Move List";
            this.btnMergeAndMove.UseVisualStyleBackColor = true;
            this.btnMergeAndMove.Click += new System.EventHandler(this.btnMergeAndMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 271);
            this.Controls.Add(this.btnMergeAndMove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnReadList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadList;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMergeAndMove;
    }
}

