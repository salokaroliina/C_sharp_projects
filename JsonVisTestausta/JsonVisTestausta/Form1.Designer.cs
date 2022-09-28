namespace JsonVisTestausta
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
            this.TiedotBtn = new System.Windows.Forms.Button();
            this.TiedotLB = new System.Windows.Forms.Label();
            this.TranslationsLB = new System.Windows.Forms.Label();
            this.TranslateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TiedotBtn
            // 
            this.TiedotBtn.Location = new System.Drawing.Point(437, 391);
            this.TiedotBtn.Name = "TiedotBtn";
            this.TiedotBtn.Size = new System.Drawing.Size(126, 47);
            this.TiedotBtn.TabIndex = 0;
            this.TiedotBtn.Text = "Näytä tiedot (UNI)";
            this.TiedotBtn.UseVisualStyleBackColor = true;
            this.TiedotBtn.Click += new System.EventHandler(this.TiedotBtn_Click);
            // 
            // TiedotLB
            // 
            this.TiedotLB.AutoSize = true;
            this.TiedotLB.Location = new System.Drawing.Point(57, 37);
            this.TiedotLB.Name = "TiedotLB";
            this.TiedotLB.Size = new System.Drawing.Size(61, 13);
            this.TiedotLB.TabIndex = 1;
            this.TiedotLB.Text = "Universities";
            // 
            // TranslationsLB
            // 
            this.TranslationsLB.AutoSize = true;
            this.TranslationsLB.Location = new System.Drawing.Point(57, 94);
            this.TranslationsLB.Name = "TranslationsLB";
            this.TranslationsLB.Size = new System.Drawing.Size(64, 13);
            this.TranslationsLB.TabIndex = 2;
            this.TranslationsLB.Text = "Translations";
            // 
            // TranslateBtn
            // 
            this.TranslateBtn.Location = new System.Drawing.Point(607, 391);
            this.TranslateBtn.Name = "TranslateBtn";
            this.TranslateBtn.Size = new System.Drawing.Size(126, 47);
            this.TranslateBtn.TabIndex = 3;
            this.TranslateBtn.Text = "Näytä tiedot (Käännös)";
            this.TranslateBtn.UseVisualStyleBackColor = true;
            this.TranslateBtn.Click += new System.EventHandler(this.TranslateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TranslateBtn);
            this.Controls.Add(this.TranslationsLB);
            this.Controls.Add(this.TiedotLB);
            this.Controls.Add(this.TiedotBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TiedotBtn;
        private System.Windows.Forms.Label TiedotLB;
        private System.Windows.Forms.Label TranslationsLB;
        private System.Windows.Forms.Button TranslateBtn;
    }
}

