namespace Exercise_5
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
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnShowEmpList = new System.Windows.Forms.Button();
            this.btnOrderEmployee = new System.Windows.Forms.Button();
            this.btnShowEmplData = new System.Windows.Forms.Button();
            this.btnAddSaleToEmpl = new System.Windows.Forms.Button();
            this.btnShowEmplHigherSale = new System.Windows.Forms.Button();
            this.btnDeleteSalesEmpl = new System.Windows.Forms.Button();
            this.btnOrderEmplBySales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(84, 73);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(138, 24);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Introducir Empleado";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(260, 73);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(138, 24);
            this.btnDeleteEmployee.TabIndex = 1;
            this.btnDeleteEmployee.Text = "Eliminar Empleado";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnShowEmpList
            // 
            this.btnShowEmpList.Location = new System.Drawing.Point(446, 73);
            this.btnShowEmpList.Name = "btnShowEmpList";
            this.btnShowEmpList.Size = new System.Drawing.Size(138, 24);
            this.btnShowEmpList.TabIndex = 2;
            this.btnShowEmpList.Text = "Mostrar Lista Empleados";
            this.btnShowEmpList.UseVisualStyleBackColor = true;
            this.btnShowEmpList.Click += new System.EventHandler(this.btnShowEmpList_Click);
            // 
            // btnOrderEmployee
            // 
            this.btnOrderEmployee.Location = new System.Drawing.Point(84, 137);
            this.btnOrderEmployee.Name = "btnOrderEmployee";
            this.btnOrderEmployee.Size = new System.Drawing.Size(247, 24);
            this.btnOrderEmployee.TabIndex = 3;
            this.btnOrderEmployee.Text = "Ordenar Empleados por Orden Alfabético";
            this.btnOrderEmployee.UseVisualStyleBackColor = true;
            this.btnOrderEmployee.Click += new System.EventHandler(this.btnOrderEmployee_Click);
            // 
            // btnShowEmplData
            // 
            this.btnShowEmplData.Location = new System.Drawing.Point(408, 137);
            this.btnShowEmplData.Name = "btnShowEmplData";
            this.btnShowEmplData.Size = new System.Drawing.Size(185, 24);
            this.btnShowEmplData.TabIndex = 4;
            this.btnShowEmplData.Text = "Mostrar Datos Empleado";
            this.btnShowEmplData.UseVisualStyleBackColor = true;
            this.btnShowEmplData.Click += new System.EventHandler(this.btnShowEmplData_Click);
            // 
            // btnAddSaleToEmpl
            // 
            this.btnAddSaleToEmpl.Location = new System.Drawing.Point(84, 247);
            this.btnAddSaleToEmpl.Name = "btnAddSaleToEmpl";
            this.btnAddSaleToEmpl.Size = new System.Drawing.Size(232, 24);
            this.btnAddSaleToEmpl.TabIndex = 5;
            this.btnAddSaleToEmpl.Text = "Añadir Ventas a Empleado";
            this.btnAddSaleToEmpl.UseVisualStyleBackColor = true;
            this.btnAddSaleToEmpl.Click += new System.EventHandler(this.btnAddSaleToEmpl_Click);
            // 
            // btnShowEmplHigherSale
            // 
            this.btnShowEmplHigherSale.Location = new System.Drawing.Point(361, 247);
            this.btnShowEmplHigherSale.Name = "btnShowEmplHigherSale";
            this.btnShowEmplHigherSale.Size = new System.Drawing.Size(232, 24);
            this.btnShowEmplHigherSale.TabIndex = 6;
            this.btnShowEmplHigherSale.Text = "Mostrar Empleado con Mayores Ventas";
            this.btnShowEmplHigherSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowEmplHigherSale.UseVisualStyleBackColor = true;
            this.btnShowEmplHigherSale.Click += new System.EventHandler(this.btnShowEmplHigherSale_Click);
            // 
            // btnDeleteSalesEmpl
            // 
            this.btnDeleteSalesEmpl.Location = new System.Drawing.Point(84, 314);
            this.btnDeleteSalesEmpl.Name = "btnDeleteSalesEmpl";
            this.btnDeleteSalesEmpl.Size = new System.Drawing.Size(232, 24);
            this.btnDeleteSalesEmpl.TabIndex = 7;
            this.btnDeleteSalesEmpl.Text = "Eliminar las ventas de  un empleado";
            this.btnDeleteSalesEmpl.UseVisualStyleBackColor = true;
            this.btnDeleteSalesEmpl.Click += new System.EventHandler(this.btnDeleteSalesEmpl_Click);
            // 
            // btnOrderEmplBySales
            // 
            this.btnOrderEmplBySales.Location = new System.Drawing.Point(361, 314);
            this.btnOrderEmplBySales.Name = "btnOrderEmplBySales";
            this.btnOrderEmplBySales.Size = new System.Drawing.Size(232, 24);
            this.btnOrderEmplBySales.TabIndex = 8;
            this.btnOrderEmplBySales.Text = "Ordenar Empleado por Ventas";
            this.btnOrderEmplBySales.UseVisualStyleBackColor = true;
            this.btnOrderEmplBySales.Click += new System.EventHandler(this.btnOrderEmplBySales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ventas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrderEmplBySales);
            this.Controls.Add(this.btnDeleteSalesEmpl);
            this.Controls.Add(this.btnShowEmplHigherSale);
            this.Controls.Add(this.btnAddSaleToEmpl);
            this.Controls.Add(this.btnShowEmplData);
            this.Controls.Add(this.btnOrderEmployee);
            this.Controls.Add(this.btnShowEmpList);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnShowEmpList;
        private System.Windows.Forms.Button btnOrderEmployee;
        private System.Windows.Forms.Button btnShowEmplData;
        private System.Windows.Forms.Button btnAddSaleToEmpl;
        private System.Windows.Forms.Button btnShowEmplHigherSale;
        private System.Windows.Forms.Button btnDeleteSalesEmpl;
        private System.Windows.Forms.Button btnOrderEmplBySales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

