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
            this.NameLB = new System.Windows.Forms.Label();
            this.VisionLB = new System.Windows.Forms.Label();
            this.RegionLB = new System.Windows.Forms.Label();
            this.WeaponLB = new System.Windows.Forms.Label();
            this.GenderLB = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.VisionCB = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.AddCharacterBtn = new System.Windows.Forms.Button();
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
            this.AddNewPL.Controls.Add(this.AddCharacterBtn);
            this.AddNewPL.Controls.Add(this.comboBox3);
            this.AddNewPL.Controls.Add(this.comboBox2);
            this.AddNewPL.Controls.Add(this.comboBox1);
            this.AddNewPL.Controls.Add(this.VisionCB);
            this.AddNewPL.Controls.Add(this.NameTB);
            this.AddNewPL.Controls.Add(this.GenderLB);
            this.AddNewPL.Controls.Add(this.WeaponLB);
            this.AddNewPL.Controls.Add(this.RegionLB);
            this.AddNewPL.Controls.Add(this.VisionLB);
            this.AddNewPL.Controls.Add(this.NameLB);
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
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLB.Location = new System.Drawing.Point(178, 138);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(91, 49);
            this.NameLB.TabIndex = 1;
            this.NameLB.Text = "Name:";
            // 
            // VisionLB
            // 
            this.VisionLB.AutoSize = true;
            this.VisionLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisionLB.Location = new System.Drawing.Point(174, 214);
            this.VisionLB.Name = "VisionLB";
            this.VisionLB.Size = new System.Drawing.Size(95, 49);
            this.VisionLB.TabIndex = 2;
            this.VisionLB.Text = "Vision:";
            // 
            // RegionLB
            // 
            this.RegionLB.AutoSize = true;
            this.RegionLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionLB.Location = new System.Drawing.Point(174, 290);
            this.RegionLB.Name = "RegionLB";
            this.RegionLB.Size = new System.Drawing.Size(102, 49);
            this.RegionLB.TabIndex = 3;
            this.RegionLB.Text = "Region:";
            // 
            // WeaponLB
            // 
            this.WeaponLB.AutoSize = true;
            this.WeaponLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponLB.Location = new System.Drawing.Point(174, 366);
            this.WeaponLB.Name = "WeaponLB";
            this.WeaponLB.Size = new System.Drawing.Size(115, 49);
            this.WeaponLB.TabIndex = 4;
            this.WeaponLB.Text = "Weapon:";
            // 
            // GenderLB
            // 
            this.GenderLB.AutoSize = true;
            this.GenderLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLB.Location = new System.Drawing.Point(178, 442);
            this.GenderLB.Name = "GenderLB";
            this.GenderLB.Size = new System.Drawing.Size(105, 49);
            this.GenderLB.TabIndex = 5;
            this.GenderLB.Text = "Gender:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(310, 138);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(420, 47);
            this.NameTB.TabIndex = 6;
            // 
            // VisionCB
            // 
            this.VisionCB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisionCB.FormattingEnabled = true;
            this.VisionCB.Items.AddRange(new object[] {
            "Anemo",
            "Cryo",
            "Hydro",
            "Pyro",
            "Geo",
            "Electro",
            "Dendro"});
            this.VisionCB.Location = new System.Drawing.Point(310, 206);
            this.VisionCB.Name = "VisionCB";
            this.VisionCB.Size = new System.Drawing.Size(420, 57);
            this.VisionCB.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mondstadt",
            "Liyue",
            "Inazuma",
            "Sumeru",
            "Snezhnaya"});
            this.comboBox1.Location = new System.Drawing.Point(310, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(420, 57);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sword",
            "Bow",
            "Claymore",
            "Polearm",
            "Catalyst"});
            this.comboBox2.Location = new System.Drawing.Point(310, 362);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(420, 57);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.comboBox3.Location = new System.Drawing.Point(310, 440);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(420, 57);
            this.comboBox3.TabIndex = 10;
            // 
            // AddCharacterBtn
            // 
            this.AddCharacterBtn.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCharacterBtn.Location = new System.Drawing.Point(401, 529);
            this.AddCharacterBtn.Name = "AddCharacterBtn";
            this.AddCharacterBtn.Size = new System.Drawing.Size(235, 49);
            this.AddCharacterBtn.TabIndex = 11;
            this.AddCharacterBtn.Text = "Add character";
            this.AddCharacterBtn.UseVisualStyleBackColor = true;
            this.AddCharacterBtn.Click += new System.EventHandler(this.AddCharacterBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.CloseLB);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.AddNewPL);
            this.Controls.Add(this.HomePL);
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
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox VisionCB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label GenderLB;
        private System.Windows.Forms.Label WeaponLB;
        private System.Windows.Forms.Label RegionLB;
        private System.Windows.Forms.Label VisionLB;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Button AddCharacterBtn;
    }
}

