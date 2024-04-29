namespace Exercise_1_Objects
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
            this.btnEnterData = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnEmployeeBirthday = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterData
            // 
            this.btnEnterData.Location = new System.Drawing.Point(98, 71);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(151, 54);
            this.btnEnterData.TabIndex = 0;
            this.btnEnterData.Text = "Introducir datos empleados";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(98, 159);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(151, 54);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "Mostrar datos";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnEmployeeBirthday
            // 
            this.btnEmployeeBirthday.Location = new System.Drawing.Point(98, 244);
            this.btnEmployeeBirthday.Name = "btnEmployeeBirthday";
            this.btnEmployeeBirthday.Size = new System.Drawing.Size(151, 54);
            this.btnEmployeeBirthday.TabIndex = 2;
            this.btnEmployeeBirthday.Text = "Cumpleaños del empleado";
            this.btnEmployeeBirthday.UseVisualStyleBackColor = true;
            this.btnEmployeeBirthday.Click += new System.EventHandler(this.btnEmployeeBirthday_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(98, 331);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(151, 54);
            this.btnAddSale.TabIndex = 3;
            this.btnAddSale.Text = "Añadir Venta";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.btnEmployeeBirthday);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnEnterData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterData;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnEmployeeBirthday;
        private System.Windows.Forms.Button btnAddSale;
    }
}

