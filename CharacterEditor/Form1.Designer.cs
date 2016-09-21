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
            this.nudSorSpellSlots = new System.Windows.Forms.NumericUpDown();
            this.lblSorSpellSlots = new System.Windows.Forms.Label();
            this.nudRogSneakAttack = new System.Windows.Forms.NumericUpDown();
            this.lblRogSneakAttack = new System.Windows.Forms.Label();
            this.cmbRanSize = new System.Windows.Forms.ComboBox();
            this.cmbRanRace = new System.Windows.Forms.ComboBox();
            this.lblRanSize = new System.Windows.Forms.Label();
            this.lblRanRace = new System.Windows.Forms.Label();
            this.nudPalLayHands = new System.Windows.Forms.NumericUpDown();
            this.lblPalLayHands = new System.Windows.Forms.Label();
            this.nudMonExtraAttacks = new System.Windows.Forms.NumericUpDown();
            this.lblMonExtraAttacks = new System.Windows.Forms.Label();
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
            this.lblWizSpellsKnown = new System.Windows.Forms.Label();
            this.nudWizSpellsKnown = new System.Windows.Forms.NumericUpDown();
            this.lblWizFamiliar = new System.Windows.Forms.Label();
            this.cmbWizFamiliar = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudSorSpellSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRogSneakAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalLayHands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonExtraAttacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFigExtraFeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCleUndead)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWizSpellsKnown)).BeginInit();
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
            this.gbxInfo.Location = new System.Drawing.Point(31, 30);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInfo.Size = new System.Drawing.Size(253, 180);
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
            this.cmbClass.Location = new System.Drawing.Point(109, 140);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(137, 24);
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
            this.cmbRace.Location = new System.Drawing.Point(109, 110);
            this.cmbRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(137, 24);
            this.cmbRace.TabIndex = 4;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(109, 81);
            this.nudAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAge.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(139, 22);
            this.nudAge.TabIndex = 3;
            // 
            // txtL_Name
            // 
            this.txtL_Name.Location = new System.Drawing.Point(109, 53);
            this.txtL_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtL_Name.Name = "txtL_Name";
            this.txtL_Name.Size = new System.Drawing.Size(137, 22);
            this.txtL_Name.TabIndex = 2;
            // 
            // txtF_Name
            // 
            this.txtF_Name.Location = new System.Drawing.Point(109, 27);
            this.txtF_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtF_Name.Name = "txtF_Name";
            this.txtF_Name.Size = new System.Drawing.Size(137, 22);
            this.txtF_Name.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(49, 140);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 17);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(51, 110);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(41, 17);
            this.lblRace.TabIndex = 3;
            this.lblRace.Text = "Race";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(59, 81);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblL_Name
            // 
            this.lblL_Name.AutoSize = true;
            this.lblL_Name.Location = new System.Drawing.Point(15, 53);
            this.lblL_Name.Name = "lblL_Name";
            this.lblL_Name.Size = new System.Drawing.Size(76, 17);
            this.lblL_Name.TabIndex = 1;
            this.lblL_Name.Text = "Last Name";
            // 
            // lblF_Name
            // 
            this.lblF_Name.AutoSize = true;
            this.lblF_Name.Location = new System.Drawing.Point(15, 27);
            this.lblF_Name.Name = "lblF_Name";
            this.lblF_Name.Size = new System.Drawing.Size(76, 17);
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
            this.gbxStats.Location = new System.Drawing.Point(31, 217);
            this.gbxStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxStats.Name = "gbxStats";
            this.gbxStats.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxStats.Size = new System.Drawing.Size(252, 256);
            this.gbxStats.TabIndex = 1;
            this.gbxStats.TabStop = false;
            this.gbxStats.Text = "Stats";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(109, 194);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(101, 39);
            this.btnRoll.TabIndex = 12;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // nudCHA
            // 
            this.nudCHA.Location = new System.Drawing.Point(109, 166);
            this.nudCHA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCHA.Name = "nudCHA";
            this.nudCHA.Size = new System.Drawing.Size(137, 22);
            this.nudCHA.TabIndex = 11;
            // 
            // nudWIS
            // 
            this.nudWIS.Location = new System.Drawing.Point(109, 138);
            this.nudWIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudWIS.Name = "nudWIS";
            this.nudWIS.Size = new System.Drawing.Size(137, 22);
            this.nudWIS.TabIndex = 10;
            // 
            // nudINT
            // 
            this.nudINT.Location = new System.Drawing.Point(109, 110);
            this.nudINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudINT.Name = "nudINT";
            this.nudINT.Size = new System.Drawing.Size(137, 22);
            this.nudINT.TabIndex = 9;
            // 
            // nudCON
            // 
            this.nudCON.Location = new System.Drawing.Point(109, 82);
            this.nudCON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCON.Name = "nudCON";
            this.nudCON.Size = new System.Drawing.Size(137, 22);
            this.nudCON.TabIndex = 8;
            // 
            // nudDEX
            // 
            this.nudDEX.Location = new System.Drawing.Point(109, 54);
            this.nudDEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudDEX.Name = "nudDEX";
            this.nudDEX.Size = new System.Drawing.Size(137, 22);
            this.nudDEX.TabIndex = 7;
            // 
            // nudSTR
            // 
            this.nudSTR.Location = new System.Drawing.Point(109, 26);
            this.nudSTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSTR.Name = "nudSTR";
            this.nudSTR.Size = new System.Drawing.Size(137, 22);
            this.nudSTR.TabIndex = 6;
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(24, 166);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(67, 17);
            this.lblCha.TabIndex = 5;
            this.lblCha.Text = "Charisma";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(33, 138);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(58, 17);
            this.lblWis.TabIndex = 4;
            this.lblWis.Text = "Wisdom";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(12, 110);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(79, 17);
            this.lblInt.TabIndex = 3;
            this.lblInt.Text = "Intelligence";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(9, 82);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(82, 17);
            this.lblCon.TabIndex = 2;
            this.lblCon.Text = "Constitution";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(28, 54);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(63, 17);
            this.lblDex.TabIndex = 1;
            this.lblDex.Text = "Dexterity";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(29, 26);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(62, 17);
            this.lblStr.TabIndex = 0;
            this.lblStr.Text = "Strength";
            // 
            // gbxSpcifics
            // 
            this.gbxSpcifics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxSpcifics.Controls.Add(this.cmbWizFamiliar);
            this.gbxSpcifics.Controls.Add(this.lblWizFamiliar);
            this.gbxSpcifics.Controls.Add(this.nudWizSpellsKnown);
            this.gbxSpcifics.Controls.Add(this.lblWizSpellsKnown);
            this.gbxSpcifics.Controls.Add(this.nudSorSpellSlots);
            this.gbxSpcifics.Controls.Add(this.lblSorSpellSlots);
            this.gbxSpcifics.Controls.Add(this.nudRogSneakAttack);
            this.gbxSpcifics.Controls.Add(this.lblRogSneakAttack);
            this.gbxSpcifics.Controls.Add(this.cmbRanSize);
            this.gbxSpcifics.Controls.Add(this.cmbRanRace);
            this.gbxSpcifics.Controls.Add(this.lblRanSize);
            this.gbxSpcifics.Controls.Add(this.lblRanRace);
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
            this.gbxSpcifics.Location = new System.Drawing.Point(31, 478);
            this.gbxSpcifics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSpcifics.Name = "gbxSpcifics";
            this.gbxSpcifics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSpcifics.Size = new System.Drawing.Size(253, 142);
            this.gbxSpcifics.TabIndex = 2;
            this.gbxSpcifics.TabStop = false;
            this.gbxSpcifics.Text = "Class Specifics";
            // 
            // nudSorSpellSlots
            // 
            this.nudSorSpellSlots.Location = new System.Drawing.Point(109, 75);
            this.nudSorSpellSlots.Name = "nudSorSpellSlots";
            this.nudSorSpellSlots.Size = new System.Drawing.Size(137, 22);
            this.nudSorSpellSlots.TabIndex = 18;
            this.nudSorSpellSlots.Visible = false;
            // 
            // lblSorSpellSlots
            // 
            this.lblSorSpellSlots.AutoSize = true;
            this.lblSorSpellSlots.Location = new System.Drawing.Point(9, 39);
            this.lblSorSpellSlots.Name = "lblSorSpellSlots";
            this.lblSorSpellSlots.Size = new System.Drawing.Size(74, 17);
            this.lblSorSpellSlots.TabIndex = 17;
            this.lblSorSpellSlots.Text = "Spell Slots";
            this.lblSorSpellSlots.Visible = false;
            // 
            // nudRogSneakAttack
            // 
            this.nudRogSneakAttack.Location = new System.Drawing.Point(109, 75);
            this.nudRogSneakAttack.Name = "nudRogSneakAttack";
            this.nudRogSneakAttack.Size = new System.Drawing.Size(137, 22);
            this.nudRogSneakAttack.TabIndex = 16;
            this.nudRogSneakAttack.Visible = false;
            // 
            // lblRogSneakAttack
            // 
            this.lblRogSneakAttack.AutoSize = true;
            this.lblRogSneakAttack.Location = new System.Drawing.Point(9, 39);
            this.lblRogSneakAttack.Name = "lblRogSneakAttack";
            this.lblRogSneakAttack.Size = new System.Drawing.Size(123, 17);
            this.lblRogSneakAttack.TabIndex = 15;
            this.lblRogSneakAttack.Text = "Sneak Attack Dice";
            this.lblRogSneakAttack.Visible = false;
            // 
            // cmbRanSize
            // 
            this.cmbRanSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRanSize.FormattingEnabled = true;
            this.cmbRanSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbRanSize.Location = new System.Drawing.Point(109, 73);
            this.cmbRanSize.Name = "cmbRanSize";
            this.cmbRanSize.Size = new System.Drawing.Size(137, 24);
            this.cmbRanSize.TabIndex = 14;
            this.cmbRanSize.Visible = false;
            // 
            // cmbRanRace
            // 
            this.cmbRanRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRanRace.FormattingEnabled = true;
            this.cmbRanRace.Items.AddRange(new object[] {
            "Bear",
            "Cat",
            "Hawk",
            "Wolf"});
            this.cmbRanRace.Location = new System.Drawing.Point(109, 36);
            this.cmbRanRace.Name = "cmbRanRace";
            this.cmbRanRace.Size = new System.Drawing.Size(139, 24);
            this.cmbRanRace.TabIndex = 13;
            this.cmbRanRace.Visible = false;
            // 
            // lblRanSize
            // 
            this.lblRanSize.AutoSize = true;
            this.lblRanSize.Location = new System.Drawing.Point(9, 73);
            this.lblRanSize.Name = "lblRanSize";
            this.lblRanSize.Size = new System.Drawing.Size(60, 17);
            this.lblRanSize.TabIndex = 12;
            this.lblRanSize.Text = "Pet Size";
            this.lblRanSize.Visible = false;
            // 
            // lblRanRace
            // 
            this.lblRanRace.AutoSize = true;
            this.lblRanRace.Location = new System.Drawing.Point(9, 36);
            this.lblRanRace.Name = "lblRanRace";
            this.lblRanRace.Size = new System.Drawing.Size(66, 17);
            this.lblRanRace.TabIndex = 10;
            this.lblRanRace.Text = "Pet Race";
            this.lblRanRace.Visible = false;
            // 
            // nudPalLayHands
            // 
            this.nudPalLayHands.Location = new System.Drawing.Point(109, 73);
            this.nudPalLayHands.Margin = new System.Windows.Forms.Padding(4);
            this.nudPalLayHands.Name = "nudPalLayHands";
            this.nudPalLayHands.Size = new System.Drawing.Size(137, 22);
            this.nudPalLayHands.TabIndex = 9;
            this.nudPalLayHands.Visible = false;
            // 
            // lblPalLayHands
            // 
            this.lblPalLayHands.AutoSize = true;
            this.lblPalLayHands.Location = new System.Drawing.Point(9, 36);
            this.lblPalLayHands.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalLayHands.Name = "lblPalLayHands";
            this.lblPalLayHands.Size = new System.Drawing.Size(135, 17);
            this.lblPalLayHands.TabIndex = 8;
            this.lblPalLayHands.Text = "Lay On Hands Uses";
            this.lblPalLayHands.Visible = false;
            // 
            // nudMonExtraAttacks
            // 
            this.nudMonExtraAttacks.Location = new System.Drawing.Point(109, 73);
            this.nudMonExtraAttacks.Margin = new System.Windows.Forms.Padding(4);
            this.nudMonExtraAttacks.Name = "nudMonExtraAttacks";
            this.nudMonExtraAttacks.Size = new System.Drawing.Size(137, 22);
            this.nudMonExtraAttacks.TabIndex = 7;
            this.nudMonExtraAttacks.Visible = false;
            // 
            // lblMonExtraAttacks
            // 
            this.lblMonExtraAttacks.AutoSize = true;
            this.lblMonExtraAttacks.Location = new System.Drawing.Point(9, 36);
            this.lblMonExtraAttacks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonExtraAttacks.Name = "lblMonExtraAttacks";
            this.lblMonExtraAttacks.Size = new System.Drawing.Size(90, 17);
            this.lblMonExtraAttacks.TabIndex = 6;
            this.lblMonExtraAttacks.Text = "Extra Attacks";
            this.lblMonExtraAttacks.Visible = false;
            // 
            // nudFigExtraFeats
            // 
            this.nudFigExtraFeats.Location = new System.Drawing.Point(109, 73);
            this.nudFigExtraFeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudFigExtraFeats.Name = "nudFigExtraFeats";
            this.nudFigExtraFeats.Size = new System.Drawing.Size(137, 22);
            this.nudFigExtraFeats.TabIndex = 5;
            this.nudFigExtraFeats.Visible = false;
            // 
            // lblFigExtraFeats
            // 
            this.lblFigExtraFeats.AutoSize = true;
            this.lblFigExtraFeats.Location = new System.Drawing.Point(9, 36);
            this.lblFigExtraFeats.Name = "lblFigExtraFeats";
            this.lblFigExtraFeats.Size = new System.Drawing.Size(79, 17);
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
            this.cmbDruPetRace.Location = new System.Drawing.Point(109, 73);
            this.cmbDruPetRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDruPetRace.Name = "cmbDruPetRace";
            this.cmbDruPetRace.Size = new System.Drawing.Size(137, 24);
            this.cmbDruPetRace.TabIndex = 3;
            this.cmbDruPetRace.Visible = false;
            // 
            // lblDruPetRace
            // 
            this.lblDruPetRace.AutoSize = true;
            this.lblDruPetRace.Location = new System.Drawing.Point(9, 36);
            this.lblDruPetRace.Name = "lblDruPetRace";
            this.lblDruPetRace.Size = new System.Drawing.Size(66, 17);
            this.lblDruPetRace.TabIndex = 2;
            this.lblDruPetRace.Text = "Pet Race";
            this.lblDruPetRace.Visible = false;
            // 
            // nudCleUndead
            // 
            this.nudCleUndead.Location = new System.Drawing.Point(109, 73);
            this.nudCleUndead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCleUndead.Name = "nudCleUndead";
            this.nudCleUndead.Size = new System.Drawing.Size(137, 22);
            this.nudCleUndead.TabIndex = 1;
            this.nudCleUndead.Visible = false;
            // 
            // lblCleUndead
            // 
            this.lblCleUndead.AutoSize = true;
            this.lblCleUndead.Location = new System.Drawing.Point(5, 36);
            this.lblCleUndead.Name = "lblCleUndead";
            this.lblCleUndead.Size = new System.Drawing.Size(120, 17);
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
            this.lbxCharacters.ItemHeight = 16;
            this.lbxCharacters.Location = new System.Drawing.Point(315, 30);
            this.lbxCharacters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxCharacters.Name = "lbxCharacters";
            this.lbxCharacters.Size = new System.Drawing.Size(368, 596);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(693, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(114, 26);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(114, 26);
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
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // actAdd
            // 
            this.actAdd.Name = "actAdd";
            this.actAdd.Size = new System.Drawing.Size(133, 26);
            this.actAdd.Text = "Add";
            this.actAdd.Click += new System.EventHandler(this.actAdd_Click);
            // 
            // actUpdate
            // 
            this.actUpdate.Name = "actUpdate";
            this.actUpdate.Size = new System.Drawing.Size(133, 26);
            this.actUpdate.Text = "Update";
            this.actUpdate.Click += new System.EventHandler(this.actUpdate_Click);
            // 
            // actDelete
            // 
            this.actDelete.Name = "actDelete";
            this.actDelete.Size = new System.Drawing.Size(133, 26);
            this.actDelete.Text = "Delete";
            this.actDelete.Click += new System.EventHandler(this.actDelete_Click);
            // 
            // lblWizSpellsKnown
            // 
            this.lblWizSpellsKnown.AutoSize = true;
            this.lblWizSpellsKnown.Location = new System.Drawing.Point(9, 39);
            this.lblWizSpellsKnown.Name = "lblWizSpellsKnown";
            this.lblWizSpellsKnown.Size = new System.Drawing.Size(92, 17);
            this.lblWizSpellsKnown.TabIndex = 19;
            this.lblWizSpellsKnown.Text = "Spells Known";
            this.lblWizSpellsKnown.Visible = false;
            // 
            // nudWizSpellsKnown
            // 
            this.nudWizSpellsKnown.Location = new System.Drawing.Point(109, 37);
            this.nudWizSpellsKnown.Name = "nudWizSpellsKnown";
            this.nudWizSpellsKnown.Size = new System.Drawing.Size(137, 22);
            this.nudWizSpellsKnown.TabIndex = 20;
            this.nudWizSpellsKnown.Visible = false;
            // 
            // lblWizFamiliar
            // 
            this.lblWizFamiliar.AutoSize = true;
            this.lblWizFamiliar.Location = new System.Drawing.Point(9, 73);
            this.lblWizFamiliar.Name = "lblWizFamiliar";
            this.lblWizFamiliar.Size = new System.Drawing.Size(57, 17);
            this.lblWizFamiliar.TabIndex = 21;
            this.lblWizFamiliar.Text = "Familiar";
            this.lblWizFamiliar.Visible = false;
            // 
            // cmbWizFamiliar
            // 
            this.cmbWizFamiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWizFamiliar.FormattingEnabled = true;
            this.cmbWizFamiliar.Items.AddRange(new object[] {
            "Bat",
            "Owl",
            "Toad"});
            this.cmbWizFamiliar.Location = new System.Drawing.Point(109, 74);
            this.cmbWizFamiliar.Name = "cmbWizFamiliar";
            this.cmbWizFamiliar.Size = new System.Drawing.Size(139, 24);
            this.cmbWizFamiliar.TabIndex = 22;
            this.cmbWizFamiliar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(693, 649);
            this.Controls.Add(this.lbxCharacters);
            this.Controls.Add(this.gbxSpcifics);
            this.Controls.Add(this.gbxStats);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudSorSpellSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRogSneakAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalLayHands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonExtraAttacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFigExtraFeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCleUndead)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWizSpellsKnown)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbRanSize;
        private System.Windows.Forms.ComboBox cmbRanRace;
        private System.Windows.Forms.Label lblRanSize;
        private System.Windows.Forms.Label lblRanRace;
        private System.Windows.Forms.NumericUpDown nudRogSneakAttack;
        private System.Windows.Forms.Label lblRogSneakAttack;
        private System.Windows.Forms.NumericUpDown nudSorSpellSlots;
        private System.Windows.Forms.Label lblSorSpellSlots;
        private System.Windows.Forms.ComboBox cmbWizFamiliar;
        private System.Windows.Forms.Label lblWizFamiliar;
        private System.Windows.Forms.NumericUpDown nudWizSpellsKnown;
        private System.Windows.Forms.Label lblWizSpellsKnown;
    }
}

