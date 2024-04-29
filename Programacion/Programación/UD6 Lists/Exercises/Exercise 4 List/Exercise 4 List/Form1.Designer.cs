namespace Exercise_4_List
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReadExponent = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(64, 67);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(159, 76);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read Numbers";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnReadExponent
            // 
            this.btnReadExponent.Location = new System.Drawing.Point(64, 182);
            this.btnReadExponent.Name = "btnReadExponent";
            this.btnReadExponent.Size = new System.Drawing.Size(159, 76);
            this.btnReadExponent.TabIndex = 1;
            this.btnReadExponent.Text = "Read Exponent numbers";
            this.btnReadExponent.UseVisualStyleBackColor = true;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(273, 67);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(159, 76);
            this.btnShowList.TabIndex = 2;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 398);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnReadExponent);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnReadExponent;
        private System.Windows.Forms.Button btnShowList;
    }
}

