namespace PruebaForm1
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
            this.btnValidarTarjeta = new System.Windows.Forms.Button();
            this.txtNtarjeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidarTarjeta
            // 
            this.btnValidarTarjeta.Location = new System.Drawing.Point(501, 218);
            this.btnValidarTarjeta.Name = "btnValidarTarjeta";
            this.btnValidarTarjeta.Size = new System.Drawing.Size(114, 75);
            this.btnValidarTarjeta.TabIndex = 0;
            this.btnValidarTarjeta.Text = "Validar";
            this.btnValidarTarjeta.UseVisualStyleBackColor = true;
            this.btnValidarTarjeta.Click += new System.EventHandler(this.btnValidarTarjeta_Click);
            // 
            // txtNtarjeta
            // 
            this.txtNtarjeta.Location = new System.Drawing.Point(196, 107);
            this.txtNtarjeta.Name = "txtNtarjeta";
            this.txtNtarjeta.Size = new System.Drawing.Size(419, 22);
            this.txtNtarjeta.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNtarjeta);
            this.Controls.Add(this.btnValidarTarjeta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidarTarjeta;
        private System.Windows.Forms.TextBox txtNtarjeta;
    }
}

