namespace PeliDemo
{
    partial class MyNewMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkBtn = new System.Windows.Forms.Button();
            this.MessageLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 20);
            this.panel1.TabIndex = 0;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.FlatAppearance.BorderSize = 0;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkBtn.Location = new System.Drawing.Point(111, 132);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(157, 41);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // MessageLB
            // 
            this.MessageLB.AutoSize = true;
            this.MessageLB.Location = new System.Drawing.Point(150, 72);
            this.MessageLB.Name = "MessageLB";
            this.MessageLB.Size = new System.Drawing.Size(74, 13);
            this.MessageLB.TabIndex = 2;
            this.MessageLB.Text = "Message here";
            // 
            // MyNewMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 199);
            this.Controls.Add(this.MessageLB);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyNewMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNewMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label MessageLB;
    }
}