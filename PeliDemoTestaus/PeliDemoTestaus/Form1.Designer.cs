namespace PeliDemoTestaus
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SiiliPB = new System.Windows.Forms.PictureBox();
            this.KekPB = new System.Windows.Forms.PictureBox();
            this.KlikattuLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SiiliPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KekPB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Vaihto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SiiliPB
            // 
            this.SiiliPB.Image = global::PeliDemoTestaus.Properties.Resources.FB_IMG_1532896574857;
            this.SiiliPB.Location = new System.Drawing.Point(411, 53);
            this.SiiliPB.Name = "SiiliPB";
            this.SiiliPB.Size = new System.Drawing.Size(305, 244);
            this.SiiliPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SiiliPB.TabIndex = 1;
            this.SiiliPB.TabStop = false;
            this.SiiliPB.Click += new System.EventHandler(this.Meemi_Click);
            // 
            // KekPB
            // 
            this.KekPB.Image = global::PeliDemoTestaus.Properties.Resources.IMG_20180717_WA0140;
            this.KekPB.Location = new System.Drawing.Point(70, 24);
            this.KekPB.Name = "KekPB";
            this.KekPB.Size = new System.Drawing.Size(270, 321);
            this.KekPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KekPB.TabIndex = 0;
            this.KekPB.TabStop = false;
            this.KekPB.Click += new System.EventHandler(this.Meemi_Click);
            // 
            // KlikattuLB
            // 
            this.KlikattuLB.AutoSize = true;
            this.KlikattuLB.Location = new System.Drawing.Point(10, 10);
            this.KlikattuLB.Name = "KlikattuLB";
            this.KlikattuLB.Size = new System.Drawing.Size(35, 13);
            this.KlikattuLB.TabIndex = 5;
            this.KlikattuLB.Text = "label1";
            this.KlikattuLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KlikattuLB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SiiliPB);
            this.Controls.Add(this.KekPB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SiiliPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KekPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KekPB;
        private System.Windows.Forms.PictureBox SiiliPB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label KlikattuLB;
    }
}

