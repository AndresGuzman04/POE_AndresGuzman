namespace ejercicio1UI.Forms
{
    partial class InteresSimpleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.capitalIncialTextBox = new System.Windows.Forms.TextBox();
            this.tasaInteresTexBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.periodoTiempoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.capitalFinalLabel = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el interés simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "C0  capital inicial prestado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejercicio1UI.Properties.Resources.Interés_simple_1_300x108;
            this.pictureBox1.Location = new System.Drawing.Point(318, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // capitalIncialTextBox
            // 
            this.capitalIncialTextBox.Location = new System.Drawing.Point(13, 111);
            this.capitalIncialTextBox.Name = "capitalIncialTextBox";
            this.capitalIncialTextBox.Size = new System.Drawing.Size(287, 34);
            this.capitalIncialTextBox.TabIndex = 3;
            // 
            // tasaInteresTexBox
            // 
            this.tasaInteresTexBox.Location = new System.Drawing.Point(18, 215);
            this.tasaInteresTexBox.Name = "tasaInteresTexBox";
            this.tasaInteresTexBox.Size = new System.Drawing.Size(287, 34);
            this.tasaInteresTexBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "i tasa de interés:";
            // 
            // periodoTiempoTextBox
            // 
            this.periodoTiempoTextBox.Location = new System.Drawing.Point(23, 326);
            this.periodoTiempoTextBox.Name = "periodoTiempoTextBox";
            this.periodoTiempoTextBox.Size = new System.Drawing.Size(287, 34);
            this.periodoTiempoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "n periodo de tiempo:";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(318, 111);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(299, 34);
            this.calcularButton.TabIndex = 8;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // capitalFinalLabel
            // 
            this.capitalFinalLabel.AutoSize = true;
            this.capitalFinalLabel.Location = new System.Drawing.Point(318, 168);
            this.capitalFinalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capitalFinalLabel.Name = "capitalFinalLabel";
            this.capitalFinalLabel.Size = new System.Drawing.Size(291, 28);
            this.capitalFinalLabel.TabIndex = 9;
            this.capitalFinalLabel.Text = "Cn  el capital final resultante:";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(318, 218);
            this.resultadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(0, 28);
            this.resultadoLabel.TabIndex = 10;
            // 
            // InteresSimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 392);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.capitalFinalLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.periodoTiempoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tasaInteresTexBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capitalIncialTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InteresSimpleForm";
            this.Text = "InteresSimpleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox capitalIncialTextBox;
        private TextBox tasaInteresTexBox;
        private Label label3;
        private TextBox periodoTiempoTextBox;
        private Label label4;
        private Button calcularButton;
        private Label capitalFinalLabel;
        private Label resultadoLabel;
    }
}