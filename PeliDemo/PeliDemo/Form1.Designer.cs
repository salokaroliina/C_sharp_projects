namespace PeliDemo
{
    partial class StartForm
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
            this.GameNameLB = new System.Windows.Forms.Label();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.CreditsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameNameLB
            // 
            this.GameNameLB.AutoSize = true;
            this.GameNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameLB.Location = new System.Drawing.Point(360, 91);
            this.GameNameLB.Name = "GameNameLB";
            this.GameNameLB.Size = new System.Drawing.Size(239, 33);
            this.GameNameLB.TabIndex = 0;
            this.GameNameLB.Text = "Learning Finnish!";
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameBtn.Location = new System.Drawing.Point(406, 206);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(156, 52);
            this.StartGameBtn.TabIndex = 1;
            this.StartGameBtn.Text = "Start the game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // CreditsBtn
            // 
            this.CreditsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsBtn.Location = new System.Drawing.Point(406, 298);
            this.CreditsBtn.Name = "CreditsBtn";
            this.CreditsBtn.Size = new System.Drawing.Size(156, 52);
            this.CreditsBtn.TabIndex = 2;
            this.CreditsBtn.Text = "Credits";
            this.CreditsBtn.UseVisualStyleBackColor = true;
            this.CreditsBtn.Click += new System.EventHandler(this.CreditsBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 555);
            this.Controls.Add(this.CreditsBtn);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.GameNameLB);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameNameLB;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button CreditsBtn;
    }
}

