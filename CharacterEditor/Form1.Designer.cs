namespace CharacterEditor
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
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.txtL_Name = new System.Windows.Forms.TextBox();
            this.txtF_Name = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblL_Name = new System.Windows.Forms.Label();
            this.lblF_Name = new System.Windows.Forms.Label();
            this.gbxStats = new System.Windows.Forms.GroupBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.nudCHA = new System.Windows.Forms.NumericUpDown();
            this.nudWIS = new System.Windows.Forms.NumericUpDown();
            this.nudINT = new System.Windows.Forms.NumericUpDown();
            this.nudCON = new System.Windows.Forms.NumericUpDown();
            this.nudDEX = new System.Windows.Forms.NumericUpDown();
            this.nudSTR = new System.Windows.Forms.NumericUpDown();
            this.lblCha = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.gbxSpcifics = new System.Windows.Forms.GroupBox();
            this.nudFigExtraFeats = new System.Windows.Forms.NumericUpDown();
            this.lblFigExtraFeats = new System.Windows.Forms.Label();
            this.cmbDruPetRace = new System.Windows.Forms.ComboBox();
            this.lblDruPetRace = new System.Windows.Forms.Label();
            this.nudCleUndead = new System.Windows.Forms.NumericUpDown();
            this.lblCleUndead = new System.Windows.Forms.Label();
            this.lbxCharacters = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.actUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.actDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMonExtraAttacks = new System.Windows.Forms.Label();
            this.nudMonExtraAttacks = new System.Windows.Forms.NumericUpDown();
            this.lblPalLayHands = new System.Windows.Forms.Label();
            this.nudPalLayHands = new System.Windows.Forms.NumericUpDown();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.gbxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudINT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSTR)).BeginInit();
            this.gbxSpcifics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFigExtraFeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCleUndead)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonExtraAttacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalLayHands)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.cmbClass);
            this.gbxInfo.Controls.Add(this.cmbRace);
            this.gbxInfo.Controls.Add(this.nudAge);
            this.gbxInfo.Controls.Add(this.txtL_Name);
            this.gbxInfo.Controls.Add(this.txtF_Name);
            this.gbxInfo.Controls.Add(this.lblClass);
            this.gbxInfo.Controls.Add(this.lblRace);
            this.gbxInfo.Controls.Add(this.lblAge);
            this.gbxInfo.Controls.Add(this.lblL_Name);
            this.gbxInfo.Controls.Add(this.lblF_Name);
            this.gbxInfo.Location = new System.Drawing.Point(23, 24);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInfo.Size = new System.Drawing.Size(190, 146);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Personal Info";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Wizard"});
            this.cmbClass.Location = new System.Drawing.Point(82, 114);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(104, 21);
            this.cmbClass.TabIndex = 5;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // cmbRace
            // 
            this.cmbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Halfling",
            "Human"});
            this.cmbRace.Location = new System.Drawing.Point(82, 89);
            this.cmbRace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(104, 21);
            this.cmbRace.TabIndex = 4;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(82, 66);
            this.nudAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAge.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(104, 20);
            this.nudAge.TabIndex = 3;
            // 
            // txtL_Name
            // 
            this.txtL_Name.Location = new System.Drawing.Point(82, 43);
            this.txtL_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtL_Name.Name = "txtL_Name";
            this.txtL_Name.Size = new System.Drawing.Size(104, 20);
            this.txtL_Name.TabIndex = 2;
            // 
            // txtF_Name
            // 
            this.txtF_Name.Location = new System.Drawing.Point(82, 22);
            this.txtF_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtF_Name.Name = "txtF_Name";
            this.txtF_Name.Size = new System.Drawing.Size(104, 20);
            this.txtF_Name.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(37, 114);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(38, 89);
            this.lblRace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 3;
            this.lblRace.Text = "Race";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(44, 66);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblL_Name
            // 
            this.lblL_Name.AutoSize = true;
            this.lblL_Name.Location = new System.Drawing.Point(11, 43);
            this.lblL_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblL_Name.Name = "lblL_Name";
            this.lblL_Name.Size = new System.Drawing.Size(58, 13);
            this.lblL_Name.TabIndex = 1;
            this.lblL_Name.Text = "Last Name";
            // 
            // lblF_Name
            // 
            this.lblF_Name.AutoSize = true;
            this.lblF_Name.Location = new System.Drawing.Point(11, 22);
            this.lblF_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF_Name.Name = "lblF_Name";
            this.lblF_Name.Size = new System.Drawing.Size(57, 13);
            this.lblF_Name.TabIndex = 0;
            this.lblF_Name.Text = "First Name";
            // 
            // gbxStats
            // 
            this.gbxStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxStats.Controls.Add(this.btnRoll);
            this.gbxStats.Controls.Add(this.nudCHA);
            this.gbxStats.Controls.Add(this.nudWIS);
            this.gbxStats.Controls.Add(this.nudINT);
            this.gbxStats.Controls.Add(this.nudCON);
            this.gbxStats.Controls.Add(this.nudDEX);
            this.gbxStats.Controls.Add(this.nudSTR);
            this.gbxStats.Controls.Add(this.lblCha);
            this.gbxStats.Controls.Add(this.lblWis);
            this.gbxStats.Controls.Add(this.lblInt);
            this.gbxStats.Controls.Add(this.lblCon);
            this.gbxStats.Controls.Add(this.lblDex);
            this.gbxStats.Controls.Add(this.lblStr);
            this.gbxStats.Location = new System.Drawing.Point(23, 176);
            this.gbxStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxStats.Name = "gbxStats";
            this.gbxStats.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxStats.Size = new System.Drawing.Size(189, 208);
            this.gbxStats.TabIndex = 1;
            this.gbxStats.TabStop = false;
            this.gbxStats.Text = "Stats";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(82, 158);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(76, 32);
            this.btnRoll.TabIndex = 12;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // nudCHA
            // 
            this.nudCHA.Location = new System.Drawing.Point(82, 135);
            this.nudCHA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCHA.Name = "nudCHA";
            this.nudCHA.Size = new System.Drawing.Size(103, 20);
            this.nudCHA.TabIndex = 11;
            // 
            // nudWIS
            // 
            this.nudWIS.Location = new System.Drawing.Point(82, 112);
            this.nudWIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudWIS.Name = "nudWIS";
            this.nudWIS.Size = new System.Drawing.Size(103, 20);
            this.nudWIS.TabIndex = 10;
            // 
            // nudINT
            // 
            this.nudINT.Location = new System.Drawing.Point(82, 89);
            this.nudINT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudINT.Name = "nudINT";
            this.nudINT.Size = new System.Drawing.Size(103, 20);
            this.nudINT.TabIndex = 9;
            // 
            // nudCON
            // 
            this.nudCON.Location = new System.Drawing.Point(82, 67);
            this.nudCON.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCON.Name = "nudCON";
            this.nudCON.Size = new System.Drawing.Size(103, 20);
            this.nudCON.TabIndex = 8;
            // 
            // nudDEX
            // 
            this.nudDEX.Location = new System.Drawing.Point(82, 44);
            this.nudDEX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudDEX.Name = "nudDEX";
            this.nudDEX.Size = new System.Drawing.Size(103, 20);
            this.nudDEX.TabIndex = 7;
            // 
            // nudSTR
            // 
            this.nudSTR.Location = new System.Drawing.Point(82, 21);
            this.nudSTR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSTR.Name = "nudSTR";
            this.nudSTR.Size = new System.Drawing.Size(103, 20);
            this.nudSTR.TabIndex = 6;
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(18, 135);
            this.lblCha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(50, 13);
            this.lblCha.TabIndex = 5;
            this.lblCha.Text = "Charisma";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(25, 112);
            this.lblWis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(45, 13);
            this.lblWis.TabIndex = 4;
            this.lblWis.Text = "Wisdom";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(9, 89);
            this.lblInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(61, 13);
            this.lblInt.TabIndex = 3;
            this.lblInt.Text = "Intelligence";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(7, 67);
            this.lblCon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(62, 13);
            this.lblCon.TabIndex = 2;
            this.lblCon.Text = "Constitution";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(21, 44);
            this.lblDex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(48, 13);
            this.lblDex.TabIndex = 1;
            this.lblDex.Text = "Dexterity";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(22, 21);
            this.lblStr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(47, 13);
            this.lblStr.TabIndex = 0;
            this.lblStr.Text = "Strength";
            // 
            // gbxSpcifics
            // 
            this.gbxSpcifics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxSpcifics.Controls.Add(this.nudPalLayHands);
            this.gbxSpcifics.Controls.Add(this.lblPalLayHands);
            this.gbxSpcifics.Controls.Add(this.nudMonExtraAttacks);
            this.gbxSpcifics.Controls.Add(this.lblMonExtraAttacks);
            this.gbxSpcifics.Controls.Add(this.nudFigExtraFeats);
            this.gbxSpcifics.Controls.Add(this.lblFigExtraFeats);
            this.gbxSpcifics.Controls.Add(this.cmbDruPetRace);
            this.gbxSpcifics.Controls.Add(this.lblDruPetRace);
            this.gbxSpcifics.Controls.Add(this.nudCleUndead);
            this.gbxSpcifics.Controls.Add(this.lblCleUndead);
            this.gbxSpcifics.Location = new System.Drawing.Point(23, 388);
            this.gbxSpcifics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSpcifics.Name = "gbxSpcifics";
            this.gbxSpcifics.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSpcifics.Size = new System.Drawing.Size(190, 115);
            this.gbxSpcifics.TabIndex = 2;
            this.gbxSpcifics.TabStop = false;
            this.gbxSpcifics.Text = "Class Specifics";
            // 
            // nudFigExtraFeats
            // 
            this.nudFigExtraFeats.Location = new System.Drawing.Point(82, 59);
            this.nudFigExtraFeats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudFigExtraFeats.Name = "nudFigExtraFeats";
            this.nudFigExtraFeats.Size = new System.Drawing.Size(103, 20);
            this.nudFigExtraFeats.TabIndex = 5;
            this.nudFigExtraFeats.Visible = false;
            // 
            // lblFigExtraFeats
            // 
            this.lblFigExtraFeats.AutoSize = true;
            this.lblFigExtraFeats.Location = new System.Drawing.Point(7, 29);
            this.lblFigExtraFeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFigExtraFeats.Name = "lblFigExtraFeats";
            this.lblFigExtraFeats.Size = new System.Drawing.Size(60, 13);
            this.lblFigExtraFeats.TabIndex = 4;
            this.lblFigExtraFeats.Text = "Extra Feats";
            this.lblFigExtraFeats.Visible = false;
            // 
            // cmbDruPetRace
            // 
            this.cmbDruPetRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDruPetRace.FormattingEnabled = true;
            this.cmbDruPetRace.Items.AddRange(new object[] {
            "Bear",
            "Cat",
            "Hawk",
            "Wolf"});
            this.cmbDruPetRace.Location = new System.Drawing.Point(82, 59);
            this.cmbDruPetRace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDruPetRace.Name = "cmbDruPetRace";
            this.cmbDruPetRace.Size = new System.Drawing.Size(104, 21);
            this.cmbDruPetRace.TabIndex = 3;
            this.cmbDruPetRace.Visible = false;
            // 
            // lblDruPetRace
            // 
            this.lblDruPetRace.AutoSize = true;
            this.lblDruPetRace.Location = new System.Drawing.Point(7, 29);
            this.lblDruPetRace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDruPetRace.Name = "lblDruPetRace";
            this.lblDruPetRace.Size = new System.Drawing.Size(52, 13);
            this.lblDruPetRace.TabIndex = 2;
            this.lblDruPetRace.Text = "Pet Race";
            this.lblDruPetRace.Visible = false;
            // 
            // nudCleUndead
            // 
            this.nudCleUndead.Location = new System.Drawing.Point(82, 59);
            this.nudCleUndead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCleUndead.Name = "nudCleUndead";
            this.nudCleUndead.Size = new System.Drawing.Size(103, 20);
            this.nudCleUndead.TabIndex = 1;
            this.nudCleUndead.Visible = false;
            // 
            // lblCleUndead
            // 
            this.lblCleUndead.AutoSize = true;
            this.lblCleUndead.Location = new System.Drawing.Point(4, 29);
            this.lblCleUndead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCleUndead.Name = "lblCleUndead";
            this.lblCleUndead.Size = new System.Drawing.Size(91, 13);
            this.lblCleUndead.TabIndex = 0;
            this.lblCleUndead.Text = "Turn Unded Uses";
            this.lblCleUndead.Visible = false;
            // 
            // lbxCharacters
            // 
            this.lbxCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxCharacters.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbxCharacters.FormattingEnabled = true;
            this.lbxCharacters.Location = new System.Drawing.Point(236, 24);
            this.lbxCharacters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxCharacters.Name = "lbxCharacters";
            this.lbxCharacters.Size = new System.Drawing.Size(277, 485);
            this.lbxCharacters.TabIndex = 3;
            this.lbxCharacters.SelectedIndexChanged += new System.EventHandler(this.lbxCharacters_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(98, 22);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(98, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actAdd,
            this.actUpdate,
            this.actDelete});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // actAdd
            // 
            this.actAdd.Name = "actAdd";
            this.actAdd.Size = new System.Drawing.Size(112, 22);
            this.actAdd.Text = "Add";
            this.actAdd.Click += new System.EventHandler(this.actAdd_Click);
            // 
            // actUpdate
            // 
            this.actUpdate.Name = "actUpdate";
            this.actUpdate.Size = new System.Drawing.Size(112, 22);
            this.actUpdate.Text = "Update";
            this.actUpdate.Click += new System.EventHandler(this.actUpdate_Click);
            // 
            // actDelete
            // 
            this.actDelete.Name = "actDelete";
            this.actDelete.Size = new System.Drawing.Size(112, 22);
            this.actDelete.Text = "Delete";
            this.actDelete.Click += new System.EventHandler(this.actDelete_Click);
            // 
            // lblMonExtraAttacks
            // 
            this.lblMonExtraAttacks.AutoSize = true;
            this.lblMonExtraAttacks.Location = new System.Drawing.Point(7, 29);
            this.lblMonExtraAttacks.Name = "lblMonExtraAttacks";
            this.lblMonExtraAttacks.Size = new System.Drawing.Size(70, 13);
            this.lblMonExtraAttacks.TabIndex = 6;
            this.lblMonExtraAttacks.Text = "Extra Attacks";
            this.lblMonExtraAttacks.Visible = false;
            // 
            // nudMonExtraAttacks
            // 
            this.nudMonExtraAttacks.Location = new System.Drawing.Point(82, 59);
            this.nudMonExtraAttacks.Name = "nudMonExtraAttacks";
            this.nudMonExtraAttacks.Size = new System.Drawing.Size(103, 20);
            this.nudMonExtraAttacks.TabIndex = 7;
            this.nudMonExtraAttacks.Visible = false;
            // 
            // lblPalLayHands
            // 
            this.lblPalLayHands.AutoSize = true;
            this.lblPalLayHands.Location = new System.Drawing.Point(7, 29);
            this.lblPalLayHands.Name = "lblPalLayHands";
            this.lblPalLayHands.Size = new System.Drawing.Size(102, 13);
            this.lblPalLayHands.TabIndex = 8;
            this.lblPalLayHands.Text = "Lay On Hands Uses";
            this.lblPalLayHands.Visible = false;
            // 
            // nudPalLayHands
            // 
            this.nudPalLayHands.Location = new System.Drawing.Point(82, 59);
            this.nudPalLayHands.Name = "nudPalLayHands";
            this.nudPalLayHands.Size = new System.Drawing.Size(103, 20);
            this.nudPalLayHands.TabIndex = 9;
            this.nudPalLayHands.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(520, 527);
            this.Controls.Add(this.lbxCharacters);
            this.Controls.Add(this.gbxSpcifics);
            this.Controls.Add(this.gbxStats);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Character Creator";
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.gbxStats.ResumeLayout(false);
            this.gbxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudINT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSTR)).EndInit();
            this.gbxSpcifics.ResumeLayout(false);
            this.gbxSpcifics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFigExtraFeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCleUndead)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonExtraAttacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalLayHands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.GroupBox gbxStats;
        private System.Windows.Forms.GroupBox gbxSpcifics;
        private System.Windows.Forms.ListBox lbxCharacters;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.TextBox txtL_Name;
        private System.Windows.Forms.TextBox txtF_Name;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblL_Name;
        private System.Windows.Forms.Label lblF_Name;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.NumericUpDown nudCHA;
        private System.Windows.Forms.NumericUpDown nudWIS;
        private System.Windows.Forms.NumericUpDown nudINT;
        private System.Windows.Forms.NumericUpDown nudCON;
        private System.Windows.Forms.NumericUpDown nudDEX;
        private System.Windows.Forms.NumericUpDown nudSTR;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actAdd;
        private System.Windows.Forms.ToolStripMenuItem actUpdate;
        private System.Windows.Forms.ToolStripMenuItem actDelete;
        private System.Windows.Forms.NumericUpDown nudCleUndead;
        private System.Windows.Forms.Label lblCleUndead;
        private System.Windows.Forms.ComboBox cmbDruPetRace;
        private System.Windows.Forms.Label lblDruPetRace;
        private System.Windows.Forms.NumericUpDown nudFigExtraFeats;
        private System.Windows.Forms.Label lblFigExtraFeats;
        private System.Windows.Forms.NumericUpDown nudMonExtraAttacks;
        private System.Windows.Forms.Label lblMonExtraAttacks;
        private System.Windows.Forms.NumericUpDown nudPalLayHands;
        private System.Windows.Forms.Label lblPalLayHands;
    }
}

