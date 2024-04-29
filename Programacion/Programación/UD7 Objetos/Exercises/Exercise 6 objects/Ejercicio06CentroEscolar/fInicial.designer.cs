namespace Ejercicio06CentroEscolar
{
    partial class fInicial
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(72, 47);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(136, 29);
            this.btnCursos.TabIndex = 0;
            this.btnCursos.Text = "Gestión Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Location = new System.Drawing.Point(72, 117);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(136, 29);
            this.btnAlumnos.TabIndex = 1;
            this.btnAlumnos.Text = "Gestión Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Location = new System.Drawing.Point(72, 188);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(136, 29);
            this.btnProfesores.TabIndex = 2;
            this.btnProfesores.Text = "Gestión Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // fInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.btnCursos);
            this.Name = "fInicial";
            this.Text = "Gestión de Instituto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnProfesores;
    }
}

