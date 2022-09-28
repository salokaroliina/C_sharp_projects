namespace Array_testausta
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
            this.TekstiLB = new System.Windows.Forms.Label();
            this.NaytaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TekstiLB
            // 
            this.TekstiLB.AutoSize = true;
            this.TekstiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekstiLB.Location = new System.Drawing.Point(89, 74);
            this.TekstiLB.Name = "TekstiLB";
            this.TekstiLB.Size = new System.Drawing.Size(51, 20);
            this.TekstiLB.TabIndex = 0;
            this.TekstiLB.Text = "label1";
            // 
            // NaytaBtn
            // 
            this.NaytaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaytaBtn.Location = new System.Drawing.Point(92, 195);
            this.NaytaBtn.Name = "NaytaBtn";
            this.NaytaBtn.Size = new System.Drawing.Size(135, 36);
            this.NaytaBtn.TabIndex = 1;
            this.NaytaBtn.Text = "Näytä teksti";
            this.NaytaBtn.UseVisualStyleBackColor = true;
            this.NaytaBtn.Click += new System.EventHandler(this.NaytaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NaytaBtn);
            this.Controls.Add(this.TekstiLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TekstiLB;
        private System.Windows.Forms.Button NaytaBtn;
    }
}

