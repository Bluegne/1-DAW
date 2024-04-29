namespace Ejercicio_17_Tema_5
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOrganize = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(127, 78);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(204, 42);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Introducir Vector";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(127, 159);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(204, 42);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Buscar Elemento";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOrganize
            // 
            this.btnOrganize.Location = new System.Drawing.Point(127, 238);
            this.btnOrganize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(204, 42);
            this.btnOrganize.TabIndex = 2;
            this.btnOrganize.Text = "Ordenar Vector";
            this.btnOrganize.UseVisualStyleBackColor = true;
            this.btnOrganize.Click += new System.EventHandler(this.btnOrganize_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(127, 318);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(204, 42);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Mostrar Vector";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 417);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnOrganize);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRead);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.Button btnShow;
    }
}

