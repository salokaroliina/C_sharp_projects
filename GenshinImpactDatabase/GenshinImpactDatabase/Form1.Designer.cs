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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HomeHeaderLB = new System.Windows.Forms.Label();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.CharactersBtn = new System.Windows.Forms.Button();
            this.StatsBtn = new System.Windows.Forms.Button();
            this.AddNewPL = new System.Windows.Forms.Panel();
            this.AddCharacterBtn = new System.Windows.Forms.Button();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.WeaponCB = new System.Windows.Forms.ComboBox();
            this.RegionCB = new System.Windows.Forms.ComboBox();
            this.VisionCB = new System.Windows.Forms.ComboBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.GenderLB = new System.Windows.Forms.Label();
            this.WeaponLB = new System.Windows.Forms.Label();
            this.RegionLB = new System.Windows.Forms.Label();
            this.VisionLB = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.AddNewHeaderLB = new System.Windows.Forms.Label();
            this.HomePL = new System.Windows.Forms.Panel();
            this.CharactersPL = new System.Windows.Forms.Panel();
            this.CharactersDTG = new System.Windows.Forms.DataGridView();
            this.MyCharactersLB = new System.Windows.Forms.Label();
            this.StatsPL = new System.Windows.Forms.Panel();
            this.StatsLB = new System.Windows.Forms.Label();
            this.CloseLB = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.StarsLB = new System.Windows.Forms.Label();
            this.StarsCB = new System.Windows.Forms.ComboBox();
            this.AddNewPL.SuspendLayout();
            this.HomePL.SuspendLayout();
            this.CharactersPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharactersDTG)).BeginInit();
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
            this.AddNewPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddNewPL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNewPL.Controls.Add(this.StarsCB);
            this.AddNewPL.Controls.Add(this.StarsLB);
            this.AddNewPL.Controls.Add(this.AddCharacterBtn);
            this.AddNewPL.Controls.Add(this.GenderCB);
            this.AddNewPL.Controls.Add(this.WeaponCB);
            this.AddNewPL.Controls.Add(this.RegionCB);
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
            // GenderCB
            // 
            this.GenderCB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.GenderCB.Location = new System.Drawing.Point(310, 437);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(420, 57);
            this.GenderCB.TabIndex = 10;
            // 
            // WeaponCB
            // 
            this.WeaponCB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponCB.FormattingEnabled = true;
            this.WeaponCB.Items.AddRange(new object[] {
            "Sword",
            "Bow",
            "Claymore",
            "Polearm",
            "Catalyst"});
            this.WeaponCB.Location = new System.Drawing.Point(310, 366);
            this.WeaponCB.Name = "WeaponCB";
            this.WeaponCB.Size = new System.Drawing.Size(420, 57);
            this.WeaponCB.TabIndex = 9;
            // 
            // RegionCB
            // 
            this.RegionCB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionCB.FormattingEnabled = true;
            this.RegionCB.Items.AddRange(new object[] {
            "Mondstadt",
            "Liyue",
            "Inazuma",
            "Sumeru",
            "Snezhnaya"});
            this.RegionCB.Location = new System.Drawing.Point(310, 295);
            this.RegionCB.Name = "RegionCB";
            this.RegionCB.Size = new System.Drawing.Size(420, 57);
            this.RegionCB.TabIndex = 8;
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
            this.VisionCB.Location = new System.Drawing.Point(310, 224);
            this.VisionCB.Name = "VisionCB";
            this.VisionCB.Size = new System.Drawing.Size(420, 57);
            this.VisionCB.TabIndex = 7;
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(310, 92);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(420, 47);
            this.NameTB.TabIndex = 6;
            // 
            // GenderLB
            // 
            this.GenderLB.AutoSize = true;
            this.GenderLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLB.Location = new System.Drawing.Point(178, 441);
            this.GenderLB.Name = "GenderLB";
            this.GenderLB.Size = new System.Drawing.Size(105, 49);
            this.GenderLB.TabIndex = 5;
            this.GenderLB.Text = "Gender:";
            // 
            // WeaponLB
            // 
            this.WeaponLB.AutoSize = true;
            this.WeaponLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponLB.Location = new System.Drawing.Point(174, 370);
            this.WeaponLB.Name = "WeaponLB";
            this.WeaponLB.Size = new System.Drawing.Size(115, 49);
            this.WeaponLB.TabIndex = 4;
            this.WeaponLB.Text = "Weapon:";
            // 
            // RegionLB
            // 
            this.RegionLB.AutoSize = true;
            this.RegionLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionLB.Location = new System.Drawing.Point(174, 299);
            this.RegionLB.Name = "RegionLB";
            this.RegionLB.Size = new System.Drawing.Size(102, 49);
            this.RegionLB.TabIndex = 3;
            this.RegionLB.Text = "Region:";
            // 
            // VisionLB
            // 
            this.VisionLB.AutoSize = true;
            this.VisionLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisionLB.Location = new System.Drawing.Point(174, 228);
            this.VisionLB.Name = "VisionLB";
            this.VisionLB.Size = new System.Drawing.Size(95, 49);
            this.VisionLB.TabIndex = 2;
            this.VisionLB.Text = "Vision:";
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLB.Location = new System.Drawing.Point(178, 91);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(91, 49);
            this.NameLB.TabIndex = 1;
            this.NameLB.Text = "Name:";
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
            this.HomePL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
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
            this.CharactersPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CharactersPL.Controls.Add(this.CharactersDTG);
            this.CharactersPL.Controls.Add(this.MyCharactersLB);
            this.CharactersPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharactersPL.Location = new System.Drawing.Point(0, 0);
            this.CharactersPL.Name = "CharactersPL";
            this.CharactersPL.Size = new System.Drawing.Size(968, 605);
            this.CharactersPL.TabIndex = 4;
            this.CharactersPL.Visible = false;
            // 
            // CharactersDTG
            // 
            this.CharactersDTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CharactersDTG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CharactersDTG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CharactersDTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.CharactersDTG.ColumnHeadersHeight = 26;
            this.CharactersDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CharactersDTG.DefaultCellStyle = dataGridViewCellStyle14;
            this.CharactersDTG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CharactersDTG.GridColor = System.Drawing.SystemColors.Control;
            this.CharactersDTG.Location = new System.Drawing.Point(3, 75);
            this.CharactersDTG.MultiSelect = false;
            this.CharactersDTG.Name = "CharactersDTG";
            this.CharactersDTG.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CharactersDTG.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.CharactersDTG.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.CharactersDTG.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.CharactersDTG.RowTemplate.Height = 24;
            this.CharactersDTG.RowTemplate.ReadOnly = true;
            this.CharactersDTG.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CharactersDTG.Size = new System.Drawing.Size(961, 526);
            this.CharactersDTG.TabIndex = 1;
            // 
            // MyCharactersLB
            // 
            this.MyCharactersLB.AutoSize = true;
            this.MyCharactersLB.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCharactersLB.Location = new System.Drawing.Point(363, 9);
            this.MyCharactersLB.Name = "MyCharactersLB";
            this.MyCharactersLB.Size = new System.Drawing.Size(216, 63);
            this.MyCharactersLB.TabIndex = 0;
            this.MyCharactersLB.Text = "My characters";
            // 
            // StatsPL
            // 
            this.StatsPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
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
            this.CloseLB.BackColor = System.Drawing.Color.Transparent;
            this.CloseLB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // StarsLB
            // 
            this.StarsLB.AutoSize = true;
            this.StarsLB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarsLB.Location = new System.Drawing.Point(178, 157);
            this.StarsLB.Name = "StarsLB";
            this.StarsLB.Size = new System.Drawing.Size(78, 49);
            this.StarsLB.TabIndex = 12;
            this.StarsLB.Text = "Stars:";
            // 
            // StarsCB
            // 
            this.StarsCB.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarsCB.FormattingEnabled = true;
            this.StarsCB.Items.AddRange(new object[] {
            "★★★★",
            "★★★★★"});
            this.StarsCB.Location = new System.Drawing.Point(310, 153);
            this.StarsCB.Name = "StarsCB";
            this.StarsCB.Size = new System.Drawing.Size(420, 57);
            this.StarsCB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.CloseLB);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.HomePL);
            this.Controls.Add(this.CharactersPL);
            this.Controls.Add(this.AddNewPL);
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
            ((System.ComponentModel.ISupportInitialize)(this.CharactersDTG)).EndInit();
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
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.ComboBox WeaponCB;
        private System.Windows.Forms.ComboBox RegionCB;
        private System.Windows.Forms.ComboBox VisionCB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label GenderLB;
        private System.Windows.Forms.Label WeaponLB;
        private System.Windows.Forms.Label RegionLB;
        private System.Windows.Forms.Label VisionLB;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Button AddCharacterBtn;
        private System.Windows.Forms.DataGridView CharactersDTG;
        private System.Windows.Forms.ComboBox StarsCB;
        private System.Windows.Forms.Label StarsLB;
    }
}

