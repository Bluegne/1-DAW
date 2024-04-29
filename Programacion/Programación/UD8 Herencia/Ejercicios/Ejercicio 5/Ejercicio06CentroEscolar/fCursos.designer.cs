namespace Ejercicio06CentroEscolar
{
    partial class fCursos
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
            this.btnAñadirCurso = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnMostrarCursos = new System.Windows.Forms.Button();
            this.btnAlumnosCursos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAñadirCurso
            // 
            this.btnAñadirCurso.Location = new System.Drawing.Point(58, 34);
            this.btnAñadirCurso.Name = "btnAñadirCurso";
            this.btnAñadirCurso.Size = new System.Drawing.Size(176, 35);
            this.btnAñadirCurso.TabIndex = 0;
            this.btnAñadirCurso.Text = "Añadir Curso";
            this.btnAñadirCurso.UseVisualStyleBackColor = true;
            this.btnAñadirCurso.Click += new System.EventHandler(this.btnAñadirCurso_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Location = new System.Drawing.Point(58, 86);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(176, 35);
            this.btnEliminarCurso.TabIndex = 1;
            this.btnEliminarCurso.Text = "Eliminar Curso";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // btnMostrarCursos
            // 
            this.btnMostrarCursos.Location = new System.Drawing.Point(58, 137);
            this.btnMostrarCursos.Name = "btnMostrarCursos";
            this.btnMostrarCursos.Size = new System.Drawing.Size(176, 35);
            this.btnMostrarCursos.TabIndex = 2;
            this.btnMostrarCursos.Text = "Mostrar todos los cursos";
            this.btnMostrarCursos.UseVisualStyleBackColor = true;
            this.btnMostrarCursos.Click += new System.EventHandler(this.btnMostrarCursos_Click);
            // 
            // btnAlumnosCursos
            // 
            this.btnAlumnosCursos.Location = new System.Drawing.Point(58, 187);
            this.btnAlumnosCursos.Name = "btnAlumnosCursos";
            this.btnAlumnosCursos.Size = new System.Drawing.Size(176, 47);
            this.btnAlumnosCursos.TabIndex = 3;
            this.btnAlumnosCursos.Text = "Mostrar todos los alumnos pertenecientes a un curso";
            this.btnAlumnosCursos.UseVisualStyleBackColor = true;
            this.btnAlumnosCursos.Click += new System.EventHandler(this.btnAlumnosCursos_Click);
            // 
            // fCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnAlumnosCursos);
            this.Controls.Add(this.btnMostrarCursos);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnAñadirCurso);
            this.Name = "fCursos";
            this.Text = "fCursos";
            this.Load += new System.EventHandler(this.fCursos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnMostrarCursos;
        private System.Windows.Forms.Button btnAlumnosCursos;
    }
}