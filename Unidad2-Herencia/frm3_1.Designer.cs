namespace Unidad2_Herencia
{
    partial class frm3_1
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
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rdbCD = new System.Windows.Forms.RadioButton();
            this.rdbLibro = new System.Windows.Forms.RadioButton();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNumPaginas = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.gpbTipo.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rdbCD);
            this.gpbTipo.Controls.Add(this.rdbLibro);
            this.gpbTipo.Location = new System.Drawing.Point(12, 12);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(144, 100);
            this.gpbTipo.TabIndex = 0;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo Publicacion";
            // 
            // rdbCD
            // 
            this.rdbCD.AutoSize = true;
            this.rdbCD.Location = new System.Drawing.Point(16, 61);
            this.rdbCD.Name = "rdbCD";
            this.rdbCD.Size = new System.Drawing.Size(101, 21);
            this.rdbCD.TabIndex = 1;
            this.rdbCD.TabStop = true;
            this.rdbCD.Text = "Audio Libro";
            this.rdbCD.UseVisualStyleBackColor = true;
            this.rdbCD.CheckedChanged += new System.EventHandler(this.rdbCD_CheckedChanged);
            // 
            // rdbLibro
            // 
            this.rdbLibro.AutoSize = true;
            this.rdbLibro.Location = new System.Drawing.Point(16, 34);
            this.rdbLibro.Name = "rdbLibro";
            this.rdbLibro.Size = new System.Drawing.Size(115, 21);
            this.rdbLibro.TabIndex = 0;
            this.rdbLibro.TabStop = true;
            this.rdbLibro.Text = "Libro Impreso";
            this.rdbLibro.UseVisualStyleBackColor = true;
            this.rdbLibro.CheckedChanged += new System.EventHandler(this.rdbLibro_CheckedChanged);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(188, 12);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 43);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar Datos";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(188, 59);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 49);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(188, 114);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 25);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.lblTiempo);
            this.gpbDatos.Controls.Add(this.lblPaginas);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.label1);
            this.gpbDatos.Controls.Add(this.txtTiempo);
            this.gpbDatos.Controls.Add(this.txtNumPaginas);
            this.gpbDatos.Controls.Add(this.txtPrecio);
            this.gpbDatos.Controls.Add(this.txtTitulo);
            this.gpbDatos.Location = new System.Drawing.Point(12, 145);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(251, 140);
            this.gpbDatos.TabIndex = 5;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos de la publicacion";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(145, 21);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 22);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(145, 50);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtNumPaginas
            // 
            this.txtNumPaginas.Location = new System.Drawing.Point(145, 78);
            this.txtNumPaginas.Name = "txtNumPaginas";
            this.txtNumPaginas.Size = new System.Drawing.Size(100, 22);
            this.txtNumPaginas.TabIndex = 2;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(145, 106);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 22);
            this.txtTiempo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(13, 83);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(96, 17);
            this.lblPaginas.TabIndex = 6;
            this.lblPaginas.Text = "Num. Paginas";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(13, 109);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(118, 17);
            this.lblTiempo.TabIndex = 7;
            this.lblTiempo.Text = "Tiempo (minutos)";
            // 
            // frm3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 307);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.gpbTipo);
            this.Name = "frm3_1";
            this.Text = "3.1-1";
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rdbCD;
        private System.Windows.Forms.RadioButton rdbLibro;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtNumPaginas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}