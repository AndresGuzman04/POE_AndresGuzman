namespace practica1.Forms
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
            this.lanzarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lanzarButton
            // 
            this.lanzarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lanzarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanzarButton.Location = new System.Drawing.Point(0, 0);
            this.lanzarButton.Name = "lanzarButton";
            this.lanzarButton.Size = new System.Drawing.Size(218, 266);
            this.lanzarButton.TabIndex = 0;
            this.lanzarButton.Text = "Lanzar";
            this.lanzarButton.UseVisualStyleBackColor = false;
            this.lanzarButton.Click += new System.EventHandler(this.lanzarButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 264);
            this.Controls.Add(this.lanzarButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lanzarButton;
    }
}