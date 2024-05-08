namespace Ejercicio03
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.txtAnyo = new System.Windows.Forms.TextBox();
            this.txtEpisodios = new System.Windows.Forms.TextBox();
            this.lblAnyo = new System.Windows.Forms.Label();
            this.lblEpisodios = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorAnyo = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnBuscarPorGenero = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorTitulo = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(79, 66);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(0, 17);
            this.lblRegistro.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(540, 433);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(389, 89);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar y Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(235, 36);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(52, 36);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnAnyadir);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(83, 433);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(389, 89);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Registro";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(217, 36);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar Nuevo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(48, 36);
            this.btnAnyadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(100, 28);
            this.btnAnyadir.TabIndex = 0;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUltimo);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.btnPrimero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(847, 90);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegar";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(597, 34);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(100, 28);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(443, 34);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 28);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(289, 34);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 28);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(140, 34);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(100, 28);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // txtAnyo
            // 
            this.txtAnyo.Location = new System.Drawing.Point(708, 192);
            this.txtAnyo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.Size = new System.Drawing.Size(220, 22);
            this.txtAnyo.TabIndex = 24;
            this.txtAnyo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // txtEpisodios
            // 
            this.txtEpisodios.Location = new System.Drawing.Point(652, 132);
            this.txtEpisodios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEpisodios.Name = "txtEpisodios";
            this.txtEpisodios.Size = new System.Drawing.Size(276, 22);
            this.txtEpisodios.TabIndex = 23;
            this.txtEpisodios.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // lblAnyo
            // 
            this.lblAnyo.AutoSize = true;
            this.lblAnyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnyo.Location = new System.Drawing.Point(561, 201);
            this.lblAnyo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnyo.Name = "lblAnyo";
            this.lblAnyo.Size = new System.Drawing.Size(133, 17);
            this.lblAnyo.TabIndex = 22;
            this.lblAnyo.Text = "Año lanzamiento:";
            // 
            // lblEpisodios
            // 
            this.lblEpisodios.AutoSize = true;
            this.lblEpisodios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodios.Location = new System.Drawing.Point(561, 135);
            this.lblEpisodios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodios.Name = "lblEpisodios";
            this.lblEpisodios.Size = new System.Drawing.Size(83, 17);
            this.lblEpisodios.TabIndex = 21;
            this.lblEpisodios.Text = "Episodios:";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(164, 192);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(275, 22);
            this.txtGenero.TabIndex = 20;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // txtEstudio
            // 
            this.txtEstudio.Location = new System.Drawing.Point(164, 250);
            this.txtEstudio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(275, 22);
            this.txtEstudio.TabIndex = 19;
            this.txtEstudio.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(164, 132);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(275, 22);
            this.txtTitulo.TabIndex = 18;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudio.Location = new System.Drawing.Point(79, 254);
            this.lblEstudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(67, 17);
            this.lblEstudio.TabIndex = 17;
            this.lblEstudio.Text = "Estudio:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(79, 192);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(67, 17);
            this.lblGenero.TabIndex = 16;
            this.lblGenero.Text = "Género:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(79, 132);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 17);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Título:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(652, 250);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(276, 22);
            this.txtEstado.TabIndex = 30;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarPorAnyo);
            this.groupBox4.Controls.Add(this.btnMostrarTodo);
            this.groupBox4.Controls.Add(this.btnBuscarPorGenero);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(83, 569);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(389, 132);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar lista de Animes";
            this.groupBox4.UseCompatibleTextRendering = true;
            // 
            // btnBuscarPorAnyo
            // 
            this.btnBuscarPorAnyo.Location = new System.Drawing.Point(123, 82);
            this.btnBuscarPorAnyo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPorAnyo.Name = "btnBuscarPorAnyo";
            this.btnBuscarPorAnyo.Size = new System.Drawing.Size(155, 28);
            this.btnBuscarPorAnyo.TabIndex = 1;
            this.btnBuscarPorAnyo.Text = "Por año";
            this.btnBuscarPorAnyo.UseVisualStyleBackColor = true;
            this.btnBuscarPorAnyo.Click += new System.EventHandler(this.btnBuscarPorAnyo_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(217, 36);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(155, 28);
            this.btnMostrarTodo.TabIndex = 1;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnBuscarPorGenero
            // 
            this.btnBuscarPorGenero.Location = new System.Drawing.Point(20, 36);
            this.btnBuscarPorGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPorGenero.Name = "btnBuscarPorGenero";
            this.btnBuscarPorGenero.Size = new System.Drawing.Size(165, 28);
            this.btnBuscarPorGenero.TabIndex = 0;
            this.btnBuscarPorGenero.Text = "Por género";
            this.btnBuscarPorGenero.UseVisualStyleBackColor = true;
            this.btnBuscarPorGenero.Click += new System.EventHandler(this.btnBuscarPorGenero_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscarPorTitulo);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(540, 569);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(389, 132);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar Anime";
            this.groupBox5.UseCompatibleTextRendering = true;
            // 
            // btnBuscarPorTitulo
            // 
            this.btnBuscarPorTitulo.Location = new System.Drawing.Point(112, 55);
            this.btnBuscarPorTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPorTitulo.Name = "btnBuscarPorTitulo";
            this.btnBuscarPorTitulo.Size = new System.Drawing.Size(165, 28);
            this.btnBuscarPorTitulo.TabIndex = 0;
            this.btnBuscarPorTitulo.Text = "Por título";
            this.btnBuscarPorTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarPorTitulo.Click += new System.EventHandler(this.btnBuscarPorNombre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 738);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAnyo);
            this.Controls.Add(this.txtEpisodios);
            this.Controls.Add(this.lblAnyo);
            this.Controls.Add(this.lblEpisodios);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtEstudio);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Animes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.TextBox txtAnyo;
        private System.Windows.Forms.TextBox txtEpisodios;
        private System.Windows.Forms.Label lblAnyo;
        private System.Windows.Forms.Label lblEpisodios;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEstudio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnBuscarPorGenero;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuscarPorAnyo;
        private System.Windows.Forms.Button btnBuscarPorTitulo;
    }
}

