namespace PeliDemo
{
    partial class Language
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
            this.EnglishBtn = new System.Windows.Forms.Button();
            this.FinnishBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnglishBtn
            // 
            this.EnglishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishBtn.Location = new System.Drawing.Point(394, 183);
            this.EnglishBtn.Name = "EnglishBtn";
            this.EnglishBtn.Size = new System.Drawing.Size(156, 52);
            this.EnglishBtn.TabIndex = 2;
            this.EnglishBtn.Text = "English";
            this.EnglishBtn.UseVisualStyleBackColor = true;
            this.EnglishBtn.Click += new System.EventHandler(this.EnglishBtn_Click);
            // 
            // FinnishBtn
            // 
            this.FinnishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinnishBtn.Location = new System.Drawing.Point(394, 260);
            this.FinnishBtn.Name = "FinnishBtn";
            this.FinnishBtn.Size = new System.Drawing.Size(156, 52);
            this.FinnishBtn.TabIndex = 3;
            this.FinnishBtn.Text = "Finnish";
            this.FinnishBtn.UseVisualStyleBackColor = true;
            this.FinnishBtn.Click += new System.EventHandler(this.FinnishBtn_Click);
            // 
            // Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 555);
            this.Controls.Add(this.FinnishBtn);
            this.Controls.Add(this.EnglishBtn);
            this.Name = "Language";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnglishBtn;
        private System.Windows.Forms.Button FinnishBtn;
    }
}