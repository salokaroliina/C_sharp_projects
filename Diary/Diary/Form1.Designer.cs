namespace Diary
{
    partial class MyDiary
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
            this.NewEntryPL = new System.Windows.Forms.Panel();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.SaveEntryBtn = new System.Windows.Forms.Button();
            this.EntryTB = new System.Windows.Forms.RichTextBox();
            this.NewEntryHomeBtn = new System.Windows.Forms.Button();
            this.HomePL = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.OldEntriesBtn = new System.Windows.Forms.Button();
            this.NewEntryBtn = new System.Windows.Forms.Button();
            this.OldEntriesPL = new System.Windows.Forms.Panel();
            this.MakeButtonBtn = new System.Windows.Forms.Button();
            this.OldEntriesHomeBtn = new System.Windows.Forms.Button();
            this.EntriesDTG = new System.Windows.Forms.DataGridView();
            this.FrontPL = new System.Windows.Forms.Panel();
            this.RegisterPL = new System.Windows.Forms.Panel();
            this.NewUserLB = new System.Windows.Forms.Label();
            this.NewOkBtn = new System.Windows.Forms.Button();
            this.NewPasswordTB = new System.Windows.Forms.TextBox();
            this.NewUsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.UsernameLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.NewUserBtn = new System.Windows.Forms.Button();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.NewEntryPL.SuspendLayout();
            this.HomePL.SuspendLayout();
            this.OldEntriesPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntriesDTG)).BeginInit();
            this.FrontPL.SuspendLayout();
            this.RegisterPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewEntryPL
            // 
            this.NewEntryPL.BackgroundImage = global::Diary.Properties.Resources.pinkbg;
            this.NewEntryPL.Controls.Add(this.DateTB);
            this.NewEntryPL.Controls.Add(this.SaveEntryBtn);
            this.NewEntryPL.Controls.Add(this.EntryTB);
            this.NewEntryPL.Controls.Add(this.NewEntryHomeBtn);
            this.NewEntryPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewEntryPL.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEntryPL.Location = new System.Drawing.Point(0, 0);
            this.NewEntryPL.Name = "NewEntryPL";
            this.NewEntryPL.Size = new System.Drawing.Size(854, 536);
            this.NewEntryPL.TabIndex = 0;
            // 
            // DateTB
            // 
            this.DateTB.Location = new System.Drawing.Point(3, 52);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(139, 29);
            this.DateTB.TabIndex = 4;
            // 
            // SaveEntryBtn
            // 
            this.SaveEntryBtn.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEntryBtn.Location = new System.Drawing.Point(382, 483);
            this.SaveEntryBtn.Name = "SaveEntryBtn";
            this.SaveEntryBtn.Size = new System.Drawing.Size(100, 41);
            this.SaveEntryBtn.TabIndex = 3;
            this.SaveEntryBtn.Text = "Save";
            this.SaveEntryBtn.UseVisualStyleBackColor = true;
            this.SaveEntryBtn.Click += new System.EventHandler(this.SaveEntryBtn_Click);
            // 
            // EntryTB
            // 
            this.EntryTB.Location = new System.Drawing.Point(3, 87);
            this.EntryTB.Name = "EntryTB";
            this.EntryTB.Size = new System.Drawing.Size(848, 390);
            this.EntryTB.TabIndex = 1;
            this.EntryTB.Text = "";
            // 
            // NewEntryHomeBtn
            // 
            this.NewEntryHomeBtn.Location = new System.Drawing.Point(3, 3);
            this.NewEntryHomeBtn.Name = "NewEntryHomeBtn";
            this.NewEntryHomeBtn.Size = new System.Drawing.Size(75, 28);
            this.NewEntryHomeBtn.TabIndex = 0;
            this.NewEntryHomeBtn.Text = "Home";
            this.NewEntryHomeBtn.UseVisualStyleBackColor = true;
            this.NewEntryHomeBtn.Click += new System.EventHandler(this.NewEntryHomeBtn_Click);
            // 
            // HomePL
            // 
            this.HomePL.BackgroundImage = global::Diary.Properties.Resources.pinkbg;
            this.HomePL.Controls.Add(this.LogoutBtn);
            this.HomePL.Controls.Add(this.OldEntriesBtn);
            this.HomePL.Controls.Add(this.NewEntryBtn);
            this.HomePL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePL.Location = new System.Drawing.Point(0, 0);
            this.HomePL.Name = "HomePL";
            this.HomePL.Size = new System.Drawing.Size(854, 536);
            this.HomePL.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(367, 319);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(140, 50);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // OldEntriesBtn
            // 
            this.OldEntriesBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldEntriesBtn.Location = new System.Drawing.Point(367, 250);
            this.OldEntriesBtn.Name = "OldEntriesBtn";
            this.OldEntriesBtn.Size = new System.Drawing.Size(140, 50);
            this.OldEntriesBtn.TabIndex = 1;
            this.OldEntriesBtn.Text = "Older entries";
            this.OldEntriesBtn.UseVisualStyleBackColor = true;
            this.OldEntriesBtn.Click += new System.EventHandler(this.OldEntriesBtn_Click);
            // 
            // NewEntryBtn
            // 
            this.NewEntryBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEntryBtn.Location = new System.Drawing.Point(367, 181);
            this.NewEntryBtn.Name = "NewEntryBtn";
            this.NewEntryBtn.Size = new System.Drawing.Size(140, 50);
            this.NewEntryBtn.TabIndex = 0;
            this.NewEntryBtn.Text = "New entry";
            this.NewEntryBtn.UseVisualStyleBackColor = true;
            this.NewEntryBtn.Click += new System.EventHandler(this.NewEntryBtn_Click);
            // 
            // OldEntriesPL
            // 
            this.OldEntriesPL.BackgroundImage = global::Diary.Properties.Resources.pinkbg;
            this.OldEntriesPL.Controls.Add(this.MakeButtonBtn);
            this.OldEntriesPL.Controls.Add(this.OldEntriesHomeBtn);
            this.OldEntriesPL.Controls.Add(this.EntriesDTG);
            this.OldEntriesPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OldEntriesPL.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldEntriesPL.Location = new System.Drawing.Point(0, 0);
            this.OldEntriesPL.Name = "OldEntriesPL";
            this.OldEntriesPL.Size = new System.Drawing.Size(854, 536);
            this.OldEntriesPL.TabIndex = 2;
            // 
            // MakeButtonBtn
            // 
            this.MakeButtonBtn.Location = new System.Drawing.Point(695, 12);
            this.MakeButtonBtn.Name = "MakeButtonBtn";
            this.MakeButtonBtn.Size = new System.Drawing.Size(147, 57);
            this.MakeButtonBtn.TabIndex = 2;
            this.MakeButtonBtn.Text = "Create label";
            this.MakeButtonBtn.UseVisualStyleBackColor = true;
            this.MakeButtonBtn.Click += new System.EventHandler(this.MakeButtonBtn_Click);
            // 
            // OldEntriesHomeBtn
            // 
            this.OldEntriesHomeBtn.Location = new System.Drawing.Point(3, 3);
            this.OldEntriesHomeBtn.Name = "OldEntriesHomeBtn";
            this.OldEntriesHomeBtn.Size = new System.Drawing.Size(75, 28);
            this.OldEntriesHomeBtn.TabIndex = 1;
            this.OldEntriesHomeBtn.Text = "Home";
            this.OldEntriesHomeBtn.UseVisualStyleBackColor = true;
            this.OldEntriesHomeBtn.Click += new System.EventHandler(this.OldEntriesHomeBtn_Click);
            // 
            // EntriesDTG
            // 
            this.EntriesDTG.AllowUserToAddRows = false;
            this.EntriesDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntriesDTG.Location = new System.Drawing.Point(471, 363);
            this.EntriesDTG.Name = "EntriesDTG";
            this.EntriesDTG.Size = new System.Drawing.Size(379, 170);
            this.EntriesDTG.TabIndex = 0;
            // 
            // FrontPL
            // 
            this.FrontPL.BackgroundImage = global::Diary.Properties.Resources.pinkbg;
            this.FrontPL.Controls.Add(this.RegisterPL);
            this.FrontPL.Controls.Add(this.label3);
            this.FrontPL.Controls.Add(this.label2);
            this.FrontPL.Controls.Add(this.label1);
            this.FrontPL.Controls.Add(this.PasswordTB);
            this.FrontPL.Controls.Add(this.UserNameTB);
            this.FrontPL.Controls.Add(this.NewUserBtn);
            this.FrontPL.Controls.Add(this.LogInBtn);
            this.FrontPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrontPL.Location = new System.Drawing.Point(0, 0);
            this.FrontPL.Name = "FrontPL";
            this.FrontPL.Size = new System.Drawing.Size(854, 536);
            this.FrontPL.TabIndex = 3;
            // 
            // RegisterPL
            // 
            this.RegisterPL.BackgroundImage = global::Diary.Properties.Resources.pinkbg;
            this.RegisterPL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterPL.Controls.Add(this.NewUserLB);
            this.RegisterPL.Controls.Add(this.NewOkBtn);
            this.RegisterPL.Controls.Add(this.NewPasswordTB);
            this.RegisterPL.Controls.Add(this.NewUsernameTB);
            this.RegisterPL.Controls.Add(this.PasswordLB);
            this.RegisterPL.Controls.Add(this.UsernameLB);
            this.RegisterPL.Location = new System.Drawing.Point(449, 43);
            this.RegisterPL.Name = "RegisterPL";
            this.RegisterPL.Size = new System.Drawing.Size(405, 481);
            this.RegisterPL.TabIndex = 2;
            // 
            // NewUserLB
            // 
            this.NewUserLB.AutoSize = true;
            this.NewUserLB.BackColor = System.Drawing.Color.Transparent;
            this.NewUserLB.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserLB.Location = new System.Drawing.Point(146, 24);
            this.NewUserLB.Name = "NewUserLB";
            this.NewUserLB.Size = new System.Drawing.Size(103, 25);
            this.NewUserLB.TabIndex = 5;
            this.NewUserLB.Text = "New user";
            // 
            // NewOkBtn
            // 
            this.NewOkBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOkBtn.Location = new System.Drawing.Point(141, 306);
            this.NewOkBtn.Name = "NewOkBtn";
            this.NewOkBtn.Size = new System.Drawing.Size(108, 37);
            this.NewOkBtn.TabIndex = 4;
            this.NewOkBtn.Text = "OK";
            this.NewOkBtn.UseVisualStyleBackColor = true;
            // 
            // NewPasswordTB
            // 
            this.NewPasswordTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTB.Location = new System.Drawing.Point(84, 237);
            this.NewPasswordTB.Name = "NewPasswordTB";
            this.NewPasswordTB.Size = new System.Drawing.Size(226, 29);
            this.NewPasswordTB.TabIndex = 3;
            // 
            // NewUsernameTB
            // 
            this.NewUsernameTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUsernameTB.Location = new System.Drawing.Point(84, 146);
            this.NewUsernameTB.Name = "NewUsernameTB";
            this.NewUsernameTB.Size = new System.Drawing.Size(226, 29);
            this.NewUsernameTB.TabIndex = 2;
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLB.Location = new System.Drawing.Point(154, 214);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(87, 20);
            this.PasswordLB.TabIndex = 1;
            this.PasswordLB.Text = "Password:";
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLB.Location = new System.Drawing.Point(152, 123);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(90, 20);
            this.UsernameLB.TabIndex = 0;
            this.UsernameLB.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "My Diary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(328, 215);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(218, 29);
            this.PasswordTB.TabIndex = 4;
            // 
            // UserNameTB
            // 
            this.UserNameTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTB.Location = new System.Drawing.Point(328, 146);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(218, 29);
            this.UserNameTB.TabIndex = 3;
            // 
            // NewUserBtn
            // 
            this.NewUserBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserBtn.Location = new System.Drawing.Point(367, 375);
            this.NewUserBtn.Name = "NewUserBtn";
            this.NewUserBtn.Size = new System.Drawing.Size(140, 50);
            this.NewUserBtn.TabIndex = 1;
            this.NewUserBtn.Text = "New user?";
            this.NewUserBtn.UseVisualStyleBackColor = true;
            this.NewUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.Location = new System.Drawing.Point(367, 281);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(140, 50);
            this.LogInBtn.TabIndex = 0;
            this.LogInBtn.Text = "Log in";
            this.LogInBtn.UseVisualStyleBackColor = true;
            // 
            // MyDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 536);
            this.Controls.Add(this.OldEntriesPL);
            this.Controls.Add(this.NewEntryPL);
            this.Controls.Add(this.FrontPL);
            this.Controls.Add(this.HomePL);
            this.Name = "MyDiary";
            this.Text = "My Diary";
            this.Load += new System.EventHandler(this.MyDiary_Load);
            this.NewEntryPL.ResumeLayout(false);
            this.NewEntryPL.PerformLayout();
            this.HomePL.ResumeLayout(false);
            this.OldEntriesPL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EntriesDTG)).EndInit();
            this.FrontPL.ResumeLayout(false);
            this.FrontPL.PerformLayout();
            this.RegisterPL.ResumeLayout(false);
            this.RegisterPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NewEntryPL;
        private System.Windows.Forms.Panel HomePL;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button OldEntriesBtn;
        private System.Windows.Forms.Button NewEntryBtn;
        private System.Windows.Forms.Panel OldEntriesPL;
        private System.Windows.Forms.Panel FrontPL;
        private System.Windows.Forms.Panel RegisterPL;
        private System.Windows.Forms.Label NewUserLB;
        private System.Windows.Forms.Button NewOkBtn;
        private System.Windows.Forms.TextBox NewPasswordTB;
        private System.Windows.Forms.TextBox NewUsernameTB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.Label UsernameLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Button NewUserBtn;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.Button SaveEntryBtn;
        private System.Windows.Forms.RichTextBox EntryTB;
        private System.Windows.Forms.Button NewEntryHomeBtn;
        private System.Windows.Forms.DataGridView EntriesDTG;
        private System.Windows.Forms.Button OldEntriesHomeBtn;
        private System.Windows.Forms.Button MakeButtonBtn;
    }
}

