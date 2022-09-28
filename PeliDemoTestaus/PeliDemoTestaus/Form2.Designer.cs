namespace PeliDemoTestaus
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
            this.VaderPB = new System.Windows.Forms.PictureBox();
            this.LegolasPB = new System.Windows.Forms.PictureBox();
            this.TakaisinBtn = new System.Windows.Forms.Button();
            this.KlikattuLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VaderPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegolasPB)).BeginInit();
            this.SuspendLayout();
            // 
            // VaderPB
            // 
            this.VaderPB.Image = global::PeliDemoTestaus.Properties.Resources.FB_IMG_1536041548187;
            this.VaderPB.Location = new System.Drawing.Point(416, 12);
            this.VaderPB.Name = "VaderPB";
            this.VaderPB.Size = new System.Drawing.Size(350, 358);
            this.VaderPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VaderPB.TabIndex = 1;
            this.VaderPB.TabStop = false;
            this.VaderPB.Click += new System.EventHandler(this.Meemi_Click);
            // 
            // LegolasPB
            // 
            this.LegolasPB.Image = global::PeliDemoTestaus.Properties.Resources.FB_IMG_1534074283717;
            this.LegolasPB.Location = new System.Drawing.Point(12, 12);
            this.LegolasPB.Name = "LegolasPB";
            this.LegolasPB.Size = new System.Drawing.Size(366, 358);
            this.LegolasPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LegolasPB.TabIndex = 0;
            this.LegolasPB.TabStop = false;
            this.LegolasPB.Click += new System.EventHandler(this.Meemi_Click);
            // 
            // TakaisinBtn
            // 
            this.TakaisinBtn.Location = new System.Drawing.Point(691, 415);
            this.TakaisinBtn.Name = "TakaisinBtn";
            this.TakaisinBtn.Size = new System.Drawing.Size(75, 23);
            this.TakaisinBtn.TabIndex = 2;
            this.TakaisinBtn.Text = "Takaisin";
            this.TakaisinBtn.UseVisualStyleBackColor = true;
            this.TakaisinBtn.Click += new System.EventHandler(this.TakaisinBtn_Click);
            // 
            // KlikattuLB
            // 
            this.KlikattuLB.AutoSize = true;
            this.KlikattuLB.Location = new System.Drawing.Point(12, 405);
            this.KlikattuLB.Name = "KlikattuLB";
            this.KlikattuLB.Size = new System.Drawing.Size(35, 13);
            this.KlikattuLB.TabIndex = 3;
            this.KlikattuLB.Text = "label1";
            this.KlikattuLB.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KlikattuLB);
            this.Controls.Add(this.TakaisinBtn);
            this.Controls.Add(this.VaderPB);
            this.Controls.Add(this.LegolasPB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VaderPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegolasPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LegolasPB;
        private System.Windows.Forms.PictureBox VaderPB;
        private System.Windows.Forms.Button TakaisinBtn;
        private System.Windows.Forms.Label KlikattuLB;
    }
}