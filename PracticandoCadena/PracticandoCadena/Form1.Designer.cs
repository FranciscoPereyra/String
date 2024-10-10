
namespace PracticandoCadena
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
            this.tbCadena = new System.Windows.Forms.TextBox();
            this.tbLongitud = new System.Windows.Forms.TextBox();
            this.tbUltimo = new System.Windows.Forms.TextBox();
            this.tbPrimer = new System.Windows.Forms.TextBox();
            this.tbEntreDosySeis = new System.Windows.Forms.TextBox();
            this.tbLetraA = new System.Windows.Forms.TextBox();
            this.tbMayusculas = new System.Windows.Forms.TextBox();
            this.tbMinuscula = new System.Windows.Forms.TextBox();
            this.tbBorrarEspacios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCadena
            // 
            this.tbCadena.Location = new System.Drawing.Point(144, 25);
            this.tbCadena.Name = "tbCadena";
            this.tbCadena.Size = new System.Drawing.Size(294, 20);
            this.tbCadena.TabIndex = 0;
            // 
            // tbLongitud
            // 
            this.tbLongitud.Location = new System.Drawing.Point(144, 67);
            this.tbLongitud.Name = "tbLongitud";
            this.tbLongitud.Size = new System.Drawing.Size(294, 20);
            this.tbLongitud.TabIndex = 1;
            // 
            // tbUltimo
            // 
            this.tbUltimo.Location = new System.Drawing.Point(144, 109);
            this.tbUltimo.Name = "tbUltimo";
            this.tbUltimo.Size = new System.Drawing.Size(294, 20);
            this.tbUltimo.TabIndex = 2;
            // 
            // tbPrimer
            // 
            this.tbPrimer.Location = new System.Drawing.Point(144, 151);
            this.tbPrimer.Name = "tbPrimer";
            this.tbPrimer.Size = new System.Drawing.Size(294, 20);
            this.tbPrimer.TabIndex = 3;
            // 
            // tbEntreDosySeis
            // 
            this.tbEntreDosySeis.Location = new System.Drawing.Point(144, 193);
            this.tbEntreDosySeis.Name = "tbEntreDosySeis";
            this.tbEntreDosySeis.Size = new System.Drawing.Size(294, 20);
            this.tbEntreDosySeis.TabIndex = 4;
            this.tbEntreDosySeis.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbLetraA
            // 
            this.tbLetraA.Location = new System.Drawing.Point(144, 235);
            this.tbLetraA.Name = "tbLetraA";
            this.tbLetraA.Size = new System.Drawing.Size(294, 20);
            this.tbLetraA.TabIndex = 5;
            // 
            // tbMayusculas
            // 
            this.tbMayusculas.Location = new System.Drawing.Point(144, 277);
            this.tbMayusculas.Name = "tbMayusculas";
            this.tbMayusculas.Size = new System.Drawing.Size(294, 20);
            this.tbMayusculas.TabIndex = 6;
            // 
            // tbMinuscula
            // 
            this.tbMinuscula.Location = new System.Drawing.Point(144, 319);
            this.tbMinuscula.Name = "tbMinuscula";
            this.tbMinuscula.Size = new System.Drawing.Size(294, 20);
            this.tbMinuscula.TabIndex = 7;
            // 
            // tbBorrarEspacios
            // 
            this.tbBorrarEspacios.Location = new System.Drawing.Point(144, 361);
            this.tbBorrarEspacios.Name = "tbBorrarEspacios";
            this.tbBorrarEspacios.Size = new System.Drawing.Size(294, 20);
            this.tbBorrarEspacios.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Longitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Último Caracter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Primer Caracter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "2do. y 6to. Caracter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Posición de la letra \"A\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mayúsculas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Minúsculas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Borrar espacios en blanco";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FloralWhite;
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcesar.Location = new System.Drawing.Point(11, 396);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(799, 38);
            this.btnProcesar.TabIndex = 18;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.tbCadena);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbLongitud);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbUltimo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPrimer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbEntreDosySeis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbLetraA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMayusculas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMinuscula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBorrarEspacios);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 489);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso Cadena";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(469, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 355);
            this.listBox1.TabIndex = 19;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FloralWhite;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(11, 440);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(799, 38);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Procesando Cadena de Caracteres";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCadena;
        private System.Windows.Forms.TextBox tbLongitud;
        private System.Windows.Forms.TextBox tbUltimo;
        private System.Windows.Forms.TextBox tbPrimer;
        private System.Windows.Forms.TextBox tbEntreDosySeis;
        private System.Windows.Forms.TextBox tbLetraA;
        private System.Windows.Forms.TextBox tbMayusculas;
        private System.Windows.Forms.TextBox tbMinuscula;
        private System.Windows.Forms.TextBox tbBorrarEspacios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCerrar;
    }
}

