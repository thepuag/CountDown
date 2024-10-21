namespace CuentaAtras
{
    partial class Form1
    {
        
        // Variable necesaria para diseñar la interfaz.
        
        private System.ComponentModel.IContainer components = null;

        
        // Limpia los recursos que se están utilizando.
        
        // <param name="disposing">true si los recursos administrados deben ser eliminados; de lo contrario, false.</param>
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
        /// Método necesario para admitir el Diseñador. No modifiques
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTimeInput = new System.Windows.Forms.TextBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTimeInput
            // 
            this.txtTimeInput.Location = new System.Drawing.Point(12, 12);
            this.txtTimeInput.Name = "txtTimeInput";
            this.txtTimeInput.Size = new System.Drawing.Size(100, 20);
            this.txtTimeInput.TabIndex = 0;
            this.txtTimeInput.Text = "Ingresa tiempo (s)";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCountdown.Location = new System.Drawing.Point(12, 48);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(60, 24);
            this.lblCountdown.TabIndex = 1;
            this.lblCountdown.Text = "00:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(118, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.txtTimeInput);
            this.Name = "Form1";
            this.Text = "Cuenta atrás";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTimeInput;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Button btnStart;
    }
}
