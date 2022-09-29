namespace PeliDemo
{
    partial class Game
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
            this.PicturePB = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePB)).BeginInit();
            this.SuspendLayout();
            // 
            // PicturePB
            // 
            this.PicturePB.Image = global::PeliDemo.Properties.Resources.FB_IMG_1538398071945;
            this.PicturePB.Location = new System.Drawing.Point(230, 42);
            this.PicturePB.Name = "PicturePB";
            this.PicturePB.Size = new System.Drawing.Size(535, 391);
            this.PicturePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePB.TabIndex = 0;
            this.PicturePB.TabStop = false;
            this.PicturePB.Click += new System.EventHandler(this.Picture_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(410, 520);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(173, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Okay I have seen enough";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 555);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.PicturePB);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicturePB;
        private System.Windows.Forms.Button CloseBtn;
    }
}