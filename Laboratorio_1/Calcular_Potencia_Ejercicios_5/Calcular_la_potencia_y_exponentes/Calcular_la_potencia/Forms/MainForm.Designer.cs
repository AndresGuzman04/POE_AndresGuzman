namespace Calcular_la_potencia.Forms
{
    partial class MainForm
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.ExponenteText = new System.Windows.Forms.TextBox();
            this.NumeroText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalcularButton.Location = new System.Drawing.Point(108, 127);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(183, 44);
            this.CalcularButton.TabIndex = 5;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // ExponenteText
            // 
            this.ExponenteText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExponenteText.Location = new System.Drawing.Point(219, 40);
            this.ExponenteText.Name = "ExponenteText";
            this.ExponenteText.Size = new System.Drawing.Size(125, 38);
            this.ExponenteText.TabIndex = 4;
            // 
            // NumeroText
            // 
            this.NumeroText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumeroText.Location = new System.Drawing.Point(26, 40);
            this.NumeroText.Name = "NumeroText";
            this.NumeroText.Size = new System.Drawing.Size(125, 38);
            this.NumeroText.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.ExponenteText);
            this.Controls.Add(this.NumeroText);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CalcularButton;
        private TextBox ExponenteText;
        private TextBox NumeroText;
    }
}