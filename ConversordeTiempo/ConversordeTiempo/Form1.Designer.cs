namespace ConversordeTiempo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo1ConvertirTiem = new System.Windows.Forms.ComboBox();
            this.cbo2ConvertirTiem = new System.Windows.Forms.ComboBox();
            this.txtCantidadTiem = new System.Windows.Forms.TextBox();
            this.txt2Resultado = new System.Windows.Forms.TextBox();
            this.btn1Convertir = new System.Windows.Forms.Button();
            this.btn2Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convertir a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equivale a:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "A:";
            // 
            // cbo1ConvertirTiem
            // 
            this.cbo1ConvertirTiem.FormattingEnabled = true;
            this.cbo1ConvertirTiem.Items.AddRange(new object[] {
            "Minuto",
            "Hora",
            "Dia",
            "Semana",
            "Mes",
            "Año",
            "Década",
            "Siglo",
            "Segundo",
            "Milisegundo"});
            this.cbo1ConvertirTiem.Location = new System.Drawing.Point(501, 186);
            this.cbo1ConvertirTiem.Name = "cbo1ConvertirTiem";
            this.cbo1ConvertirTiem.Size = new System.Drawing.Size(120, 21);
            this.cbo1ConvertirTiem.TabIndex = 5;
            // 
            // cbo2ConvertirTiem
            // 
            this.cbo2ConvertirTiem.FormattingEnabled = true;
            this.cbo2ConvertirTiem.Items.AddRange(new object[] {
            "Minuto",
            "Hora",
            "Dia",
            "Semana",
            "Mes",
            "Año",
            "Década",
            "Siglo",
            "Segundo",
            "Milisegundo"});
            this.cbo2ConvertirTiem.Location = new System.Drawing.Point(270, 186);
            this.cbo2ConvertirTiem.Name = "cbo2ConvertirTiem";
            this.cbo2ConvertirTiem.Size = new System.Drawing.Size(121, 21);
            this.cbo2ConvertirTiem.TabIndex = 6;
            // 
            // txtCantidadTiem
            // 
            this.txtCantidadTiem.Location = new System.Drawing.Point(306, 99);
            this.txtCantidadTiem.Name = "txtCantidadTiem";
            this.txtCantidadTiem.Size = new System.Drawing.Size(157, 20);
            this.txtCantidadTiem.TabIndex = 7;
            this.txtCantidadTiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2Resultado
            // 
            this.txt2Resultado.Location = new System.Drawing.Point(306, 261);
            this.txt2Resultado.Name = "txt2Resultado";
            this.txt2Resultado.Size = new System.Drawing.Size(162, 20);
            this.txt2Resultado.TabIndex = 8;
            this.txt2Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn1Convertir
            // 
            this.btn1Convertir.Location = new System.Drawing.Point(287, 337);
            this.btn1Convertir.Name = "btn1Convertir";
            this.btn1Convertir.Size = new System.Drawing.Size(88, 40);
            this.btn1Convertir.TabIndex = 9;
            this.btn1Convertir.Text = "Convertir";
            this.btn1Convertir.UseVisualStyleBackColor = true;
            this.btn1Convertir.Click += new System.EventHandler(this.btn1Convertir_Click);
            // 
            // btn2Salir
            // 
            this.btn2Salir.Location = new System.Drawing.Point(446, 344);
            this.btn2Salir.Name = "btn2Salir";
            this.btn2Salir.Size = new System.Drawing.Size(84, 33);
            this.btn2Salir.TabIndex = 10;
            this.btn2Salir.Text = "Salir";
            this.btn2Salir.UseVisualStyleBackColor = true;
            this.btn2Salir.Click += new System.EventHandler(this.btn2Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2Salir);
            this.Controls.Add(this.btn1Convertir);
            this.Controls.Add(this.txt2Resultado);
            this.Controls.Add(this.txtCantidadTiem);
            this.Controls.Add(this.cbo2ConvertirTiem);
            this.Controls.Add(this.cbo1ConvertirTiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo1ConvertirTiem;
        private System.Windows.Forms.ComboBox cbo2ConvertirTiem;
        private System.Windows.Forms.TextBox txtCantidadTiem;
        private System.Windows.Forms.TextBox txt2Resultado;
        private System.Windows.Forms.Button btn1Convertir;
        private System.Windows.Forms.Button btn2Salir;
    }
}

