namespace EjercicioPrestamo
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listTipoPrestamos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtComisionTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listPrestamos = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Controls.Add(this.txtCuotaTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCuotaInteres);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCuotaCapital);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSimular);
            this.panel1.Controls.Add(this.txtPlazo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTNA);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLinea);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listTipoPrestamos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 463);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(315, 401);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(273, 44);
            this.btnAlta.TabIndex = 19;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtCuotaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaTotal.Location = new System.Drawing.Point(461, 363);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.Size = new System.Drawing.Size(127, 22);
            this.txtCuotaTotal.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "CUOTA TOTAL";
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.BackColor = System.Drawing.SystemColors.Control;
            this.txtCuotaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaInteres.Location = new System.Drawing.Point(461, 322);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.Size = new System.Drawing.Size(127, 22);
            this.txtCuotaInteres.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cuota (Interés)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.BackColor = System.Drawing.SystemColors.Control;
            this.txtCuotaCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaCapital.Location = new System.Drawing.Point(461, 281);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.Size = new System.Drawing.Size(127, 22);
            this.txtCuotaCapital.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cuota (Capital)";
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(315, 227);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(273, 28);
            this.btnSimular.TabIndex = 12;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(420, 186);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(168, 22);
            this.txtPlazo.TabIndex = 11;
            this.txtPlazo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Plazo";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(420, 150);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(168, 22);
            this.txtMonto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monto";
            // 
            // txtTNA
            // 
            this.txtTNA.BackColor = System.Drawing.SystemColors.Control;
            this.txtTNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTNA.Location = new System.Drawing.Point(420, 110);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Size = new System.Drawing.Size(168, 22);
            this.txtTNA.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "TNA";
            // 
            // txtLinea
            // 
            this.txtLinea.BackColor = System.Drawing.SystemColors.Control;
            this.txtLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.Location = new System.Drawing.Point(420, 72);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(168, 22);
            this.txtLinea.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Linea";
            // 
            // listTipoPrestamos
            // 
            this.listTipoPrestamos.FormattingEnabled = true;
            this.listTipoPrestamos.ItemHeight = 16;
            this.listTipoPrestamos.Location = new System.Drawing.Point(19, 56);
            this.listTipoPrestamos.Name = "listTipoPrestamos";
            this.listTipoPrestamos.Size = new System.Drawing.Size(275, 388);
            this.listTipoPrestamos.TabIndex = 3;
            this.listTipoPrestamos.SelectedIndexChanged += new System.EventHandler(this.listTipoPrestamos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "TIPOS PRESTAMO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtComisionTotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.listPrestamos);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(665, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 463);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtComisionTotal
            // 
            this.txtComisionTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComisionTotal.Location = new System.Drawing.Point(204, 420);
            this.txtComisionTotal.Name = "txtComisionTotal";
            this.txtComisionTotal.Size = new System.Drawing.Size(143, 24);
            this.txtComisionTotal.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Comisión Total";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // listPrestamos
            // 
            this.listPrestamos.FormattingEnabled = true;
            this.listPrestamos.ItemHeight = 16;
            this.listPrestamos.Location = new System.Drawing.Point(15, 56);
            this.listPrestamos.Name = "listPrestamos";
            this.listPrestamos.Size = new System.Drawing.Size(332, 340);
            this.listPrestamos.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 556);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listTipoPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComisionTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listPrestamos;
        private System.Windows.Forms.Label label9;
    }
}

