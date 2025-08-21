namespace Longitud
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
            this.cbo1ConvertidoLong = new System.Windows.Forms.ComboBox();
            this.cbo2ConvertidoLong = new System.Windows.Forms.ComboBox();
            this.txt1CantidadLong = new System.Windows.Forms.TextBox();
            this.txt2Resultado = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Longitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convertir de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Equivale a:";
            // 
            // cbo1ConvertidoLong
            // 
            this.cbo1ConvertidoLong.FormattingEnabled = true;
            this.cbo1ConvertidoLong.Items.AddRange(new object[] {
            "Kilómetro",
            "Metro",
            "Centímetro",
            "Milimetro",
            "Micrómetro",
            "Nanómetro",
            "Milla",
            "Yarda",
            "Pie",
            "Pulgada"});
            this.cbo1ConvertidoLong.Location = new System.Drawing.Point(494, 172);
            this.cbo1ConvertidoLong.Name = "cbo1ConvertidoLong";
            this.cbo1ConvertidoLong.Size = new System.Drawing.Size(121, 21);
            this.cbo1ConvertidoLong.TabIndex = 5;
            // 
            // cbo2ConvertidoLong
            // 
            this.cbo2ConvertidoLong.FormattingEnabled = true;
            this.cbo2ConvertidoLong.Items.AddRange(new object[] {
            "Kilómetro",
            "Metro",
            "Centímetro",
            "Milimetro",
            "Micrómetro",
            "Nanómetro",
            "Milla",
            "Yarda",
            "Pie",
            "Pulgada"});
            this.cbo2ConvertidoLong.Location = new System.Drawing.Point(286, 175);
            this.cbo2ConvertidoLong.Name = "cbo2ConvertidoLong";
            this.cbo2ConvertidoLong.Size = new System.Drawing.Size(121, 21);
            this.cbo2ConvertidoLong.TabIndex = 6;
            // 
            // txt1CantidadLong
            // 
            this.txt1CantidadLong.Location = new System.Drawing.Point(307, 97);
            this.txt1CantidadLong.Name = "txt1CantidadLong";
            this.txt1CantidadLong.Size = new System.Drawing.Size(100, 20);
            this.txt1CantidadLong.TabIndex = 7;
            // 
            // txt2Resultado
            // 
            this.txt2Resultado.Location = new System.Drawing.Point(307, 250);
            this.txt2Resultado.Name = "txt2Resultado";
            this.txt2Resultado.Size = new System.Drawing.Size(100, 20);
            this.txt2Resultado.TabIndex = 8;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(266, 333);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(82, 31);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(441, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 31);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txt2Resultado);
            this.Controls.Add(this.txt1CantidadLong);
            this.Controls.Add(this.cbo2ConvertidoLong);
            this.Controls.Add(this.cbo1ConvertidoLong);
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
        private System.Windows.Forms.ComboBox cbo1ConvertidoLong;
        private System.Windows.Forms.ComboBox cbo2ConvertidoLong;
        private System.Windows.Forms.TextBox txt1CantidadLong;
        private System.Windows.Forms.TextBox txt2Resultado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
    }
}

