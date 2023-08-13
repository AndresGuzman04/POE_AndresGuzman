namespace MultiplicaOperacion.Forms
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
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.firstNumberText = new System.Windows.Forms.TextBox();
            this.secondNumberText = new System.Windows.Forms.TextBox();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNumberLabel.Location = new System.Drawing.Point(96, 40);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(180, 31);
            this.firstNumberLabel.TabIndex = 0;
            this.firstNumberLabel.Text = "Primer Numero";
            // 
            // firstNumberText
            // 
            this.firstNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNumberText.Location = new System.Drawing.Point(96, 96);
            this.firstNumberText.Name = "firstNumberText";
            this.firstNumberText.Size = new System.Drawing.Size(154, 34);
            this.firstNumberText.TabIndex = 1;
            // 
            // secondNumberText
            // 
            this.secondNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondNumberText.Location = new System.Drawing.Point(320, 96);
            this.secondNumberText.Name = "secondNumberText";
            this.secondNumberText.Size = new System.Drawing.Size(160, 34);
            this.secondNumberText.TabIndex = 3;
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secondNumberLabel.Location = new System.Drawing.Point(320, 49);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(203, 31);
            this.secondNumberLabel.TabIndex = 2;
            this.secondNumberLabel.Text = "Segundo Numero";
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiplicarButton.Location = new System.Drawing.Point(195, 164);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(173, 49);
            this.MultiplicarButton.TabIndex = 4;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MultiplicarButton_MouseClick);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(29, 323);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(174, 31);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "El resultado es:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.secondNumberText);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.firstNumberText);
            this.Controls.Add(this.firstNumberLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNumberLabel;
        private TextBox firstNumberText;
        private TextBox secondNumberText;
        private Label secondNumberLabel;
        private Button MultiplicarButton;
        private Label resultLabel;
    }
}