namespace GenshinImpactDatabase
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
            this.HomeHeaderLB = new System.Windows.Forms.Label();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.CharactersBtn = new System.Windows.Forms.Button();
            this.StatsBtn = new System.Windows.Forms.Button();
            this.AddNewPL = new System.Windows.Forms.Panel();
            this.AddNewHeaderLB = new System.Windows.Forms.Label();
            this.HomePL = new System.Windows.Forms.Panel();
            this.CharactersPL = new System.Windows.Forms.Panel();
            this.MyCharactersLB = new System.Windows.Forms.Label();
            this.StatsPL = new System.Windows.Forms.Panel();
            this.StatsLB = new System.Windows.Forms.Label();
            this.CloseLB = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.AddNewPL.SuspendLayout();
            this.HomePL.SuspendLayout();
            this.CharactersPL.SuspendLayout();
            this.StatsPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeHeaderLB
            // 
            this.HomeHeaderLB.AutoSize = true;
            this.HomeHeaderLB.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeHeaderLB.Location = new System.Drawing.Point(343, 15);
            this.HomeHeaderLB.Name = "HomeHeaderLB";
            this.HomeHeaderLB.Size = new System.Drawing.Size(291, 126);
            this.HomeHeaderLB.TabIndex = 0;
            this.HomeHeaderLB.Text = "Genshin Impact\r\nCharacter Database\r\n";
            this.HomeHeaderLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBtn.Location = new System.Drawing.Point(368, 191);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(239, 51);
            this.AddNewBtn.TabIndex = 1;
            this.AddNewBtn.Text = "+ Add new character";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // CharactersBtn
            // 
            this.CharactersBtn.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharactersBtn.Location = new System.Drawing.Point(368, 284);
            this.CharactersBtn.Name = "CharactersBtn";
            this.CharactersBtn.Size = new System.Drawing.Size(239, 51);
            this.CharactersBtn.TabIndex = 2;
            this.CharactersBtn.Text = "My characters";
            this.CharactersBtn.UseVisualStyleBackColor = true;
            this.CharactersBtn.Click += new System.EventHandler(this.CharactersBtn_Click);
            // 
            // StatsBtn
            // 
            this.StatsBtn.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsBtn.Location = new System.Drawing.Point(368, 377);
            this.StatsBtn.Name = "StatsBtn";
            this.StatsBtn.Size = new System.Drawing.Size(239, 51);
            this.StatsBtn.TabIndex = 3;
            this.StatsBtn.Text = "Stats for nerds";
            this.StatsBtn.UseVisualStyleBackColor = true;
            this.StatsBtn.Click += new System.EventHandler(this.StatsBtn_Click);
            // 
            // AddNewPL
            // 
            this.AddNewPL.Controls.Add(this.AddNewHeaderLB);
            this.AddNewPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewPL.Location = new System.Drawing.Point(0, 0);
            this.AddNewPL.Name = "AddNewPL";
            this.AddNewPL.Size = new System.Drawing.Size(968, 605);
            this.AddNewPL.TabIndex = 4;
            this.AddNewPL.Visible = false;
            // 
            // AddNewHeaderLB
            // 
            this.AddNewHeaderLB.AutoSize = true;
            this.AddNewHeaderLB.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewHeaderLB.Location = new System.Drawing.Point(357, 15);
            this.AddNewHeaderLB.Name = "AddNewHeaderLB";
            this.AddNewHeaderLB.Size = new System.Drawing.Size(277, 63);
            this.AddNewHeaderLB.TabIndex = 0;
            this.AddNewHeaderLB.Text = "Add new character";
            // 
            // HomePL
            // 
            this.HomePL.Controls.Add(this.HomeHeaderLB);
            this.HomePL.Controls.Add(this.AddNewBtn);
            this.HomePL.Controls.Add(this.CharactersBtn);
            this.HomePL.Controls.Add(this.StatsBtn);
            this.HomePL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePL.Location = new System.Drawing.Point(0, 0);
            this.HomePL.Name = "HomePL";
            this.HomePL.Size = new System.Drawing.Size(968, 605);
            this.HomePL.TabIndex = 1;
            // 
            // CharactersPL
            // 
            this.CharactersPL.Controls.Add(this.MyCharactersLB);
            this.CharactersPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharactersPL.Location = new System.Drawing.Point(0, 0);
            this.CharactersPL.Name = "CharactersPL";
            this.CharactersPL.Size = new System.Drawing.Size(968, 605);
            this.CharactersPL.TabIndex = 4;
            this.CharactersPL.Visible = false;
            // 
            // MyCharactersLB
            // 
            this.MyCharactersLB.AutoSize = true;
            this.MyCharactersLB.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCharactersLB.Location = new System.Drawing.Point(391, 9);
            this.MyCharactersLB.Name = "MyCharactersLB";
            this.MyCharactersLB.Size = new System.Drawing.Size(216, 63);
            this.MyCharactersLB.TabIndex = 0;
            this.MyCharactersLB.Text = "My characters";
            // 
            // StatsPL
            // 
            this.StatsPL.Controls.Add(this.StatsLB);
            this.StatsPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsPL.Location = new System.Drawing.Point(0, 0);
            this.StatsPL.Name = "StatsPL";
            this.StatsPL.Size = new System.Drawing.Size(968, 605);
            this.StatsPL.TabIndex = 1;
            this.StatsPL.Visible = false;
            // 
            // StatsLB
            // 
            this.StatsLB.AutoSize = true;
            this.StatsLB.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsLB.Location = new System.Drawing.Point(390, 15);
            this.StatsLB.Name = "StatsLB";
            this.StatsLB.Size = new System.Drawing.Size(217, 63);
            this.StatsLB.TabIndex = 0;
            this.StatsLB.Text = "Stats for nerds";
            // 
            // CloseLB
            // 
            this.CloseLB.AutoSize = true;
            this.CloseLB.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLB.Location = new System.Drawing.Point(925, 10);
            this.CloseLB.Name = "CloseLB";
            this.CloseLB.Size = new System.Drawing.Size(33, 42);
            this.CloseLB.TabIndex = 4;
            this.CloseLB.Text = "X";
            this.CloseLB.Click += new System.EventHandler(this.CloseLB_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(84, 41);
            this.HomeBtn.TabIndex = 4;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Visible = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.CloseLB);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.HomePL);
            this.Controls.Add(this.AddNewPL);
            this.Controls.Add(this.CharactersPL);
            this.Controls.Add(this.StatsPL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.AddNewPL.ResumeLayout(false);
            this.AddNewPL.PerformLayout();
            this.HomePL.ResumeLayout(false);
            this.HomePL.PerformLayout();
            this.CharactersPL.ResumeLayout(false);
            this.CharactersPL.PerformLayout();
            this.StatsPL.ResumeLayout(false);
            this.StatsPL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeHeaderLB;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Button CharactersBtn;
        private System.Windows.Forms.Button StatsBtn;
        private System.Windows.Forms.Panel AddNewPL;
        private System.Windows.Forms.Label AddNewHeaderLB;
        private System.Windows.Forms.Panel HomePL;
        private System.Windows.Forms.Panel CharactersPL;
        private System.Windows.Forms.Label MyCharactersLB;
        private System.Windows.Forms.Panel StatsPL;
        private System.Windows.Forms.Label StatsLB;
        private System.Windows.Forms.Label CloseLB;
        private System.Windows.Forms.Button HomeBtn;
    }
}

