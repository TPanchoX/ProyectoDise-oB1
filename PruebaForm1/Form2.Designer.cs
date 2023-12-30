namespace PruebaForm1
{
    partial class Form2
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
            this.lblNombreCuenta = new System.Windows.Forms.Label();
            this.txtClaveCuenta = new System.Windows.Forms.TextBox();
            this.btnValidarClave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreCuenta
            // 
            this.lblNombreCuenta.AutoSize = true;
            this.lblNombreCuenta.Location = new System.Drawing.Point(274, 107);
            this.lblNombreCuenta.Name = "lblNombreCuenta";
            this.lblNombreCuenta.Size = new System.Drawing.Size(96, 16);
            this.lblNombreCuenta.TabIndex = 0;
            this.lblNombreCuenta.Text = "nombre cuenta";
            this.lblNombreCuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtClaveCuenta
            // 
            this.txtClaveCuenta.Location = new System.Drawing.Point(277, 219);
            this.txtClaveCuenta.Name = "txtClaveCuenta";
            this.txtClaveCuenta.Size = new System.Drawing.Size(304, 22);
            this.txtClaveCuenta.TabIndex = 1;
            // 
            // btnValidarClave
            // 
            this.btnValidarClave.Location = new System.Drawing.Point(529, 336);
            this.btnValidarClave.Name = "btnValidarClave";
            this.btnValidarClave.Size = new System.Drawing.Size(75, 23);
            this.btnValidarClave.TabIndex = 2;
            this.btnValidarClave.Text = "validar";
            this.btnValidarClave.UseVisualStyleBackColor = true;
            this.btnValidarClave.Click += new System.EventHandler(this.btnValidarClave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidarClave);
            this.Controls.Add(this.txtClaveCuenta);
            this.Controls.Add(this.lblNombreCuenta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCuenta;
        private System.Windows.Forms.TextBox txtClaveCuenta;
        private System.Windows.Forms.Button btnValidarClave;
    }
}