namespace CalculadoraCsharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnValor1 = new System.Windows.Forms.Button();
            this.btnValor2 = new System.Windows.Forms.Button();
            this.btnValor3 = new System.Windows.Forms.Button();
            this.btnValor4 = new System.Windows.Forms.Button();
            this.btnValor5 = new System.Windows.Forms.Button();
            this.btnValor6 = new System.Windows.Forms.Button();
            this.btnValor7 = new System.Windows.Forms.Button();
            this.btnValor8 = new System.Windows.Forms.Button();
            this.btnValor9 = new System.Windows.Forms.Button();
            this.btnValor0 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDatos.Location = new System.Drawing.Point(12, 27);
            this.txtDatos.MaxLength = 21;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ReadOnly = true;
            this.txtDatos.Size = new System.Drawing.Size(263, 29);
            this.txtDatos.TabIndex = 0;
            this.txtDatos.Text = "0";
            this.txtDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.Location = new System.Drawing.Point(204, 181);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(42, 32);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResta.Location = new System.Drawing.Point(204, 143);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(42, 32);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Location = new System.Drawing.Point(151, 219);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(95, 30);
            this.btnIgual.TabIndex = 3;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.clickIGual);
            // 
            // btnValor1
            // 
            this.btnValor1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor1.Location = new System.Drawing.Point(51, 183);
            this.btnValor1.Name = "btnValor1";
            this.btnValor1.Size = new System.Drawing.Size(44, 30);
            this.btnValor1.TabIndex = 4;
            this.btnValor1.Text = "1";
            this.btnValor1.UseVisualStyleBackColor = true;
            this.btnValor1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor2
            // 
            this.btnValor2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor2.Location = new System.Drawing.Point(101, 183);
            this.btnValor2.Name = "btnValor2";
            this.btnValor2.Size = new System.Drawing.Size(44, 30);
            this.btnValor2.TabIndex = 5;
            this.btnValor2.Text = "2";
            this.btnValor2.UseVisualStyleBackColor = true;
            this.btnValor2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor3
            // 
            this.btnValor3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor3.Location = new System.Drawing.Point(151, 183);
            this.btnValor3.Name = "btnValor3";
            this.btnValor3.Size = new System.Drawing.Size(44, 30);
            this.btnValor3.TabIndex = 6;
            this.btnValor3.Text = "3";
            this.btnValor3.UseVisualStyleBackColor = true;
            this.btnValor3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor4
            // 
            this.btnValor4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor4.Location = new System.Drawing.Point(51, 147);
            this.btnValor4.Name = "btnValor4";
            this.btnValor4.Size = new System.Drawing.Size(44, 30);
            this.btnValor4.TabIndex = 7;
            this.btnValor4.Text = "4";
            this.btnValor4.UseVisualStyleBackColor = true;
            this.btnValor4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor5
            // 
            this.btnValor5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor5.Location = new System.Drawing.Point(101, 147);
            this.btnValor5.Name = "btnValor5";
            this.btnValor5.Size = new System.Drawing.Size(44, 30);
            this.btnValor5.TabIndex = 8;
            this.btnValor5.Text = "5";
            this.btnValor5.UseVisualStyleBackColor = true;
            this.btnValor5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor6
            // 
            this.btnValor6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor6.Location = new System.Drawing.Point(151, 147);
            this.btnValor6.Name = "btnValor6";
            this.btnValor6.Size = new System.Drawing.Size(44, 30);
            this.btnValor6.TabIndex = 9;
            this.btnValor6.Text = "6";
            this.btnValor6.UseVisualStyleBackColor = true;
            this.btnValor6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor7
            // 
            this.btnValor7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor7.Location = new System.Drawing.Point(51, 109);
            this.btnValor7.Name = "btnValor7";
            this.btnValor7.Size = new System.Drawing.Size(44, 30);
            this.btnValor7.TabIndex = 10;
            this.btnValor7.Text = "7";
            this.btnValor7.UseVisualStyleBackColor = true;
            this.btnValor7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor8
            // 
            this.btnValor8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor8.Location = new System.Drawing.Point(101, 109);
            this.btnValor8.Name = "btnValor8";
            this.btnValor8.Size = new System.Drawing.Size(44, 30);
            this.btnValor8.TabIndex = 11;
            this.btnValor8.Text = "8";
            this.btnValor8.UseVisualStyleBackColor = true;
            this.btnValor8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor9
            // 
            this.btnValor9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor9.Location = new System.Drawing.Point(151, 110);
            this.btnValor9.Name = "btnValor9";
            this.btnValor9.Size = new System.Drawing.Size(44, 30);
            this.btnValor9.TabIndex = 12;
            this.btnValor9.Text = "9";
            this.btnValor9.UseVisualStyleBackColor = true;
            this.btnValor9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnValor0
            // 
            this.btnValor0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValor0.Location = new System.Drawing.Point(101, 219);
            this.btnValor0.Name = "btnValor0";
            this.btnValor0.Size = new System.Drawing.Size(44, 30);
            this.btnValor0.TabIndex = 13;
            this.btnValor0.Text = "0";
            this.btnValor0.UseVisualStyleBackColor = true;
            this.btnValor0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(202, 110);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(44, 30);
            this.btnMultiplicar.TabIndex = 14;
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.Location = new System.Drawing.Point(202, 77);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(44, 30);
            this.btnDivision.TabIndex = 15;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnCe
            // 
            this.btnCe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCe.Location = new System.Drawing.Point(151, 77);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(44, 30);
            this.btnCe.TabIndex = 16;
            this.btnCe.Text = "C";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarTodo.Location = new System.Drawing.Point(101, 77);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(44, 30);
            this.btnBorrarTodo.TabIndex = 17;
            this.btnBorrarTodo.Text = "Ce";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 288);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnValor0);
            this.Controls.Add(this.btnValor9);
            this.Controls.Add(this.btnValor8);
            this.Controls.Add(this.btnValor7);
            this.Controls.Add(this.btnValor6);
            this.Controls.Add(this.btnValor5);
            this.Controls.Add(this.btnValor4);
            this.Controls.Add(this.btnValor3);
            this.Controls.Add(this.btnValor2);
            this.Controls.Add(this.btnValor1);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtDatos);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDatos;
        private Button btnSuma;
        private Button btnResta;
        private Button btnIgual;
        private Button btnValor1;
        private Button btnValor2;
        private Button btnValor3;
        private Button btnValor4;
        private Button btnValor5;
        private Button btnValor6;
        private Button btnValor7;
        private Button btnValor8;
        private Button btnValor9;
        private Button btnValor0;
        private Button btnMultiplicar;
        private Button btnDivision;
        private Button btnCe;
        private Button btnBorrarTodo;
    }
}