namespace Practica_2._1
{
    partial class ejercicio5
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
            this.btnFechaHoy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnFechaUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultarFechaUsuario = new System.Windows.Forms.Button();
            this.btnConsultarFechaHoy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechaHoy
            // 
            this.btnFechaHoy.Location = new System.Drawing.Point(146, 12);
            this.btnFechaHoy.Name = "btnFechaHoy";
            this.btnFechaHoy.Size = new System.Drawing.Size(75, 23);
            this.btnFechaHoy.TabIndex = 0;
            this.btnFechaHoy.Text = "Crear Fecha";
            this.btnFechaHoy.UseVisualStyleBackColor = true;
            this.btnFechaHoy.Click += new System.EventHandler(this.btnFechaHoy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha del dia de hoy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crear una Fecha";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(12, 91);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(36, 20);
            this.txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(54, 91);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(36, 20);
            this.txtMes.TabIndex = 4;
            this.txtMes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(96, 91);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(49, 20);
            this.txtAnio.TabIndex = 5;
            // 
            // btnFechaUsuario
            // 
            this.btnFechaUsuario.Location = new System.Drawing.Point(151, 88);
            this.btnFechaUsuario.Name = "btnFechaUsuario";
            this.btnFechaUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnFechaUsuario.TabIndex = 6;
            this.btnFechaUsuario.Text = "Crear Fecha";
            this.btnFechaUsuario.UseVisualStyleBackColor = true;
            this.btnFechaUsuario.Click += new System.EventHandler(this.btnFechaUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Año";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnConsultarFechaUsuario
            // 
            this.btnConsultarFechaUsuario.Location = new System.Drawing.Point(232, 88);
            this.btnConsultarFechaUsuario.Name = "btnConsultarFechaUsuario";
            this.btnConsultarFechaUsuario.Size = new System.Drawing.Size(105, 23);
            this.btnConsultarFechaUsuario.TabIndex = 11;
            this.btnConsultarFechaUsuario.Text = "Consultar Fecha";
            this.btnConsultarFechaUsuario.UseVisualStyleBackColor = true;
            this.btnConsultarFechaUsuario.Click += new System.EventHandler(this.btnConsultarFechaUsuario_Click);
            // 
            // btnConsultarFechaHoy
            // 
            this.btnConsultarFechaHoy.Location = new System.Drawing.Point(227, 12);
            this.btnConsultarFechaHoy.Name = "btnConsultarFechaHoy";
            this.btnConsultarFechaHoy.Size = new System.Drawing.Size(105, 23);
            this.btnConsultarFechaHoy.TabIndex = 10;
            this.btnConsultarFechaHoy.Text = "Consultar Fecha";
            this.btnConsultarFechaHoy.UseVisualStyleBackColor = true;
            this.btnConsultarFechaHoy.Click += new System.EventHandler(this.btnConsultarFechaHoy_Click);
            // 
            // ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.btnConsultarFechaUsuario);
            this.Controls.Add(this.btnConsultarFechaHoy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFechaUsuario);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechaHoy);
            this.Name = "ejercicio5";
            this.Text = "Ejercicio 5";
            this.Load += new System.EventHandler(this.ejercicio5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechaHoy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnFechaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultarFechaUsuario;
        private System.Windows.Forms.Button btnConsultarFechaHoy;
    }
}