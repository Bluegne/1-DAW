namespace Exercise_4_objects
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(96, 73);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(181, 53);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Nuevo Empleado";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(337, 73);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(181, 53);
            this.btnShowList.TabIndex = 2;
            this.btnShowList.Text = "Mostrar Lista Empleados";
            this.btnShowList.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(337, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 335);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button button4;
    }
}

