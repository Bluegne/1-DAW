namespace Ejercicio06CentroEscolar
{
    partial class fAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarAlum = new System.Windows.Forms.Button();
            this.btnBorrarAlum = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnMostrarAlumCur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.btnMostrarAluNotaMayor5 = new System.Windows.Forms.Button();
            this.btnbtnMostrarAluNotaMenor5 = new System.Windows.Forms.Button();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarAlum
            // 
            this.btnAgregarAlum.Location = new System.Drawing.Point(19, 34);
            this.btnAgregarAlum.Name = "btnAgregarAlum";
            this.btnAgregarAlum.Size = new System.Drawing.Size(162, 38);
            this.btnAgregarAlum.TabIndex = 0;
            this.btnAgregarAlum.Text = "Introducir Alumno";
            this.btnAgregarAlum.UseVisualStyleBackColor = true;
            this.btnAgregarAlum.Click += new System.EventHandler(this.btnAgregarAlum_Click);
            // 
            // btnBorrarAlum
            // 
            this.btnBorrarAlum.Location = new System.Drawing.Point(257, 34);
            this.btnBorrarAlum.Name = "btnBorrarAlum";
            this.btnBorrarAlum.Size = new System.Drawing.Size(162, 38);
            this.btnBorrarAlum.TabIndex = 1;
            this.btnBorrarAlum.Text = "Eliminar Alumno";
            this.btnBorrarAlum.UseVisualStyleBackColor = true;
            this.btnBorrarAlum.Click += new System.EventHandler(this.btnBorrarAlum_Click);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(489, 34);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(162, 38);
            this.btnMostrarLista.TabIndex = 2;
            this.btnMostrarLista.Text = "Mostrar Lista Alumnos";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(19, 89);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(301, 38);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar Alumnos por Orden Alfabético";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(350, 89);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(301, 38);
            this.btnMostrarDatos.TabIndex = 4;
            this.btnMostrarDatos.Text = "Mostrar Datos Alumno (por dni)";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnMostrarAlumCur
            // 
            this.btnMostrarAlumCur.Location = new System.Drawing.Point(183, 151);
            this.btnMostrarAlumCur.Name = "btnMostrarAlumCur";
            this.btnMostrarAlumCur.Size = new System.Drawing.Size(301, 38);
            this.btnMostrarAlumCur.TabIndex = 5;
            this.btnMostrarAlumCur.Text = "Mostrar alumnos pertenecientes a un curso";
            this.btnMostrarAlumCur.UseVisualStyleBackColor = true;
            this.btnMostrarAlumCur.Click += new System.EventHandler(this.btnMostrarAlumCur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarAlumCur);
            this.groupBox1.Controls.Add(this.btnAgregarAlum);
            this.groupBox1.Controls.Add(this.btnBorrarAlum);
            this.groupBox1.Controls.Add(this.btnMostrarDatos);
            this.groupBox1.Controls.Add(this.btnMostrarLista);
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Location = new System.Drawing.Point(40, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarNota);
            this.groupBox2.Controls.Add(this.btnMostrarAluNotaMayor5);
            this.groupBox2.Controls.Add(this.btnbtnMostrarAluNotaMenor5);
            this.groupBox2.Controls.Add(this.btnEliminarNota);
            this.groupBox2.Location = new System.Drawing.Point(40, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 213);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.Location = new System.Drawing.Point(20, 37);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(301, 38);
            this.btnAgregarNota.TabIndex = 0;
            this.btnAgregarNota.Text = "Añadir notas a Alumno";
            this.btnAgregarNota.UseVisualStyleBackColor = true;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // btnMostrarAluNotaMayor5
            // 
            this.btnMostrarAluNotaMayor5.Location = new System.Drawing.Point(351, 37);
            this.btnMostrarAluNotaMayor5.Name = "btnMostrarAluNotaMayor5";
            this.btnMostrarAluNotaMayor5.Size = new System.Drawing.Size(300, 38);
            this.btnMostrarAluNotaMayor5.TabIndex = 1;
            this.btnMostrarAluNotaMayor5.Text = "Mostrar alumnos con nota media mayor o igual a 5";
            this.btnMostrarAluNotaMayor5.UseVisualStyleBackColor = true;
            this.btnMostrarAluNotaMayor5.Click += new System.EventHandler(this.btnMostrarAluNotaMayor5_Click);
            // 
            // btnbtnMostrarAluNotaMenor5
            // 
            this.btnbtnMostrarAluNotaMenor5.Location = new System.Drawing.Point(350, 127);
            this.btnbtnMostrarAluNotaMenor5.Name = "btnbtnMostrarAluNotaMenor5";
            this.btnbtnMostrarAluNotaMenor5.Size = new System.Drawing.Size(301, 38);
            this.btnbtnMostrarAluNotaMenor5.TabIndex = 2;
            this.btnbtnMostrarAluNotaMenor5.Text = "Mostrar alumnos con nota media menor a 5";
            this.btnbtnMostrarAluNotaMenor5.UseVisualStyleBackColor = true;
            this.btnbtnMostrarAluNotaMenor5.Click += new System.EventHandler(this.btnbtnMostrarAluNotaMenor5_Click);
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.Location = new System.Drawing.Point(20, 127);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(301, 38);
            this.btnEliminarNota.TabIndex = 3;
            this.btnEliminarNota.Text = "Eliminar las notas de un alumno";
            this.btnEliminarNota.UseVisualStyleBackColor = true;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fAlumnos";
            this.Text = "fAlumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAlum;
        private System.Windows.Forms.Button btnBorrarAlum;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnMostrarAlumCur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.Button btnMostrarAluNotaMayor5;
        private System.Windows.Forms.Button btnbtnMostrarAluNotaMenor5;
        private System.Windows.Forms.Button btnEliminarNota;
    }
}