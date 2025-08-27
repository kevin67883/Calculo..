namespace Tarea
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
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtSCantidadDeConversor = new System.Windows.Forms.TextBox();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(345, 14);
            this.lblTipoConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(46, 18);
            this.lblTipoConversor.TabIndex = 0;
            this.lblTipoConversor.Text = "TIPO:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(335, 317);
            this.lblSuma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSuma.Size = new System.Drawing.Size(59, 18);
            this.lblSuma.TabIndex = 0;
            this.lblSuma.Text = "SUMA: ";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(761, 195);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(129, 87);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtSCantidadDeConversor
            // 
            this.txtSCantidadDeConversor.Location = new System.Drawing.Point(498, 237);
            this.txtSCantidadDeConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSCantidadDeConversor.Name = "txtSCantidadDeConversor";
            this.txtSCantidadDeConversor.Size = new System.Drawing.Size(148, 26);
            this.txtSCantidadDeConversor.TabIndex = 2;
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Monedas",
            "Longitud",
            "Masa",
            "Volumen",
            "Almacenamiento",
            "Tiempo"});
            this.cboTipoConversor.Location = new System.Drawing.Point(486, 4);
            this.cboTipoConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(180, 28);
            this.cboTipoConversor.TabIndex = 3;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Location = new System.Drawing.Point(324, 243);
            this.lblCantidadConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(95, 20);
            this.lblCantidadConversor.TabIndex = 0;
            this.lblCantidadConversor.Text = "CANTIDAD:";
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(486, 72);
            this.cboDeConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(180, 28);
            this.cboDeConversor.TabIndex = 3;
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(335, 82);
            this.lblDeConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(33, 18);
            this.lblDeConversor.TabIndex = 0;
            this.lblDeConversor.Text = "DE:";
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(498, 237);
            this.txtCantidadConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(148, 26);
            this.txtCantidadConversor.TabIndex = 2;
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(345, 145);
            this.lblAConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(21, 18);
            this.lblAConversor.TabIndex = 0;
            this.lblAConversor.Text = "A:";
            // 
            // cboAConversor
            // 
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Location = new System.Drawing.Point(486, 141);
            this.cboAConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(180, 28);
            this.cboAConversor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.txtSCantidadDeConversor);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtSCantidadDeConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
    }
}

