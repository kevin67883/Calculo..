namespace Almacenamient
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
            this.txt1CantidadAlma = new System.Windows.Forms.TextBox();
            this.txt2ResulatoAlma = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cbo2ConvertiAlma = new System.Windows.Forms.ComboBox();
            this.cbo1ConvertirAlm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Almacenamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertir de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Equivalencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese cantidad:";
            // 
            // txt1CantidadAlma
            // 
            this.txt1CantidadAlma.Location = new System.Drawing.Point(295, 120);
            this.txt1CantidadAlma.Name = "txt1CantidadAlma";
            this.txt1CantidadAlma.Size = new System.Drawing.Size(163, 20);
            this.txt1CantidadAlma.TabIndex = 5;
            this.txt1CantidadAlma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2ResulatoAlma
            // 
            this.txt2ResulatoAlma.Location = new System.Drawing.Point(269, 250);
            this.txt2ResulatoAlma.Name = "txt2ResulatoAlma";
            this.txt2ResulatoAlma.Size = new System.Drawing.Size(232, 20);
            this.txt2ResulatoAlma.TabIndex = 6;
            this.txt2ResulatoAlma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(451, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(260, 342);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(110, 43);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cbo2ConvertiAlma
            // 
            this.cbo2ConvertiAlma.FormattingEnabled = true;
            this.cbo2ConvertiAlma.Items.AddRange(new object[] {
            "Byte",
            "Kilobyte",
            "Megabyte",
            "Gigabyte",
            "Terabyte",
            "Petabyte",
            "Bit",
            "Kilobit",
            "Kilobit",
            "Megabit"});
            this.cbo2ConvertiAlma.Location = new System.Drawing.Point(249, 189);
            this.cbo2ConvertiAlma.Name = "cbo2ConvertiAlma";
            this.cbo2ConvertiAlma.Size = new System.Drawing.Size(121, 21);
            this.cbo2ConvertiAlma.TabIndex = 9;
            // 
            // cbo1ConvertirAlm
            // 
            this.cbo1ConvertirAlm.FormattingEnabled = true;
            this.cbo1ConvertirAlm.Items.AddRange(new object[] {
            "Byte",
            "Kilobyte",
            "Megabyte",
            "Gigabyte",
            "Terabyte",
            "Petabyte",
            "Bit",
            "Kilobit",
            "Kilobit",
            "Megabit"});
            this.cbo1ConvertirAlm.Location = new System.Drawing.Point(451, 189);
            this.cbo1ConvertirAlm.Name = "cbo1ConvertirAlm";
            this.cbo1ConvertirAlm.Size = new System.Drawing.Size(121, 21);
            this.cbo1ConvertirAlm.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo1ConvertirAlm);
            this.Controls.Add(this.cbo2ConvertiAlma);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txt2ResulatoAlma);
            this.Controls.Add(this.txt1CantidadAlma);
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
        private System.Windows.Forms.TextBox txt1CantidadAlma;
        private System.Windows.Forms.TextBox txt2ResulatoAlma;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cbo2ConvertiAlma;
        private System.Windows.Forms.ComboBox cbo1ConvertirAlm;
    }
}

