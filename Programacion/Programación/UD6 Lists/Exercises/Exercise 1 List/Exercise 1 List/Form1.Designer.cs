namespace Exercise_1_List
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowFirstPos = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnShowPositions = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveValues = new System.Windows.Forms.Button();
            this.btnRemovePosition = new System.Windows.Forms.Button();
            this.btnSortList = new System.Windows.Forms.Button();
            this.btnRemoveFirstVal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Number";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowFirstPos
            // 
            this.btnShowFirstPos.Location = new System.Drawing.Point(72, 229);
            this.btnShowFirstPos.Name = "btnShowFirstPos";
            this.btnShowFirstPos.Size = new System.Drawing.Size(122, 42);
            this.btnShowFirstPos.TabIndex = 1;
            this.btnShowFirstPos.Text = "Show First Position of Value";
            this.btnShowFirstPos.UseVisualStyleBackColor = true;
            this.btnShowFirstPos.Click += new System.EventHandler(this.btnShowFirstPos_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(72, 181);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(122, 42);
            this.btnShowList.TabIndex = 2;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(72, 133);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(122, 42);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert Number";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnShowPositions
            // 
            this.btnShowPositions.Location = new System.Drawing.Point(72, 277);
            this.btnShowPositions.Name = "btnShowPositions";
            this.btnShowPositions.Size = new System.Drawing.Size(122, 42);
            this.btnShowPositions.TabIndex = 4;
            this.btnShowPositions.Text = "Show Positions of Value";
            this.btnShowPositions.UseVisualStyleBackColor = true;
            this.btnShowPositions.Click += new System.EventHandler(this.btnShowPositions_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(263, 277);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(122, 42);
            this.btnRemoveAll.TabIndex = 9;
            this.btnRemoveAll.Text = "Remove all elements";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveValues
            // 
            this.btnRemoveValues.Location = new System.Drawing.Point(263, 133);
            this.btnRemoveValues.Name = "btnRemoveValues";
            this.btnRemoveValues.Size = new System.Drawing.Size(122, 42);
            this.btnRemoveValues.TabIndex = 8;
            this.btnRemoveValues.Text = "Remove Values";
            this.btnRemoveValues.UseVisualStyleBackColor = true;
            this.btnRemoveValues.Click += new System.EventHandler(this.btnRemoveValues_Click);
            // 
            // btnRemovePosition
            // 
            this.btnRemovePosition.Location = new System.Drawing.Point(263, 181);
            this.btnRemovePosition.Name = "btnRemovePosition";
            this.btnRemovePosition.Size = new System.Drawing.Size(122, 42);
            this.btnRemovePosition.TabIndex = 7;
            this.btnRemovePosition.Text = "Remove Position";
            this.btnRemovePosition.UseVisualStyleBackColor = true;
            this.btnRemovePosition.Click += new System.EventHandler(this.btnRemovePosition_Click);
            // 
            // btnSortList
            // 
            this.btnSortList.Location = new System.Drawing.Point(263, 229);
            this.btnSortList.Name = "btnSortList";
            this.btnSortList.Size = new System.Drawing.Size(122, 42);
            this.btnSortList.TabIndex = 6;
            this.btnSortList.Text = "Sort List";
            this.btnSortList.UseVisualStyleBackColor = true;
            this.btnSortList.Click += new System.EventHandler(this.btnSortList_Click);
            // 
            // btnRemoveFirstVal
            // 
            this.btnRemoveFirstVal.Location = new System.Drawing.Point(263, 85);
            this.btnRemoveFirstVal.Name = "btnRemoveFirstVal";
            this.btnRemoveFirstVal.Size = new System.Drawing.Size(122, 42);
            this.btnRemoveFirstVal.TabIndex = 5;
            this.btnRemoveFirstVal.Text = "Remove (first) Value";
            this.btnRemoveFirstVal.UseVisualStyleBackColor = true;
            this.btnRemoveFirstVal.Click += new System.EventHandler(this.btnRemoveFirstVal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Remove and Sort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveValues);
            this.Controls.Add(this.btnRemovePosition);
            this.Controls.Add(this.btnSortList);
            this.Controls.Add(this.btnRemoveFirstVal);
            this.Controls.Add(this.btnShowPositions);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnShowFirstPos);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowFirstPos;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnShowPositions;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveValues;
        private System.Windows.Forms.Button btnRemovePosition;
        private System.Windows.Forms.Button btnSortList;
        private System.Windows.Forms.Button btnRemoveFirstVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

