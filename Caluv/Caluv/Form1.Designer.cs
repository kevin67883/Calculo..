namespace Caluv
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
            this.lblc = new System.Windows.Forms.Button();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblc
            // 
            this.lblc.Location = new System.Drawing.Point(295, 261);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(75, 23);
            this.lblc.TabIndex = 0;
            this.lblc.Text = "Calcular";
            this.lblc.UseVisualStyleBackColor = true;
            this.lblc.Click += new System.EventHandler(this.tbncalcular_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(251, 160);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(33, 13);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "num1";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(395, 202);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(251, 189);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(33, 13);
            this.lblrespuesta.TabIndex = 1;
            this.lblrespuesta.Text = "num2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(395, 153);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.lblc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblc;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtnum1;
    }
}

