using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterEditor
{
    public partial class Form1 : Form
    {
        Character player = new Character();
        List<Character> mList = new List<Character>();
        List<Control> visibleList = new List<Control>();

        string klass;

        public Form1()
        {
            InitializeComponent();

            //adding options to turn visibility on or off
            //Cleric
            visibleList.Add(nudCleUndead);
            visibleList.Add(lblCleUndead);
            //Druid
            visibleList.Add(lblDruPetRace);
            visibleList.Add(cmbDruPetRace);
            //Fighter
            visibleList.Add(lblFigExtraFeats);
            visibleList.Add(nudFigExtraFeats);
            //Monk
            visibleList.Add(lblMonExtraAttacks);
            visibleList.Add(nudMonExtraAttacks);
            //Paladin
            visibleList.Add(lblPalLayHands);
            visibleList.Add(nudPalLayHands);
            //Ranger
            visibleList.Add(lblRanRace);
            visibleList.Add(cmbRanRace);
            visibleList.Add(lblRanSize);
            visibleList.Add(cmbRanSize);
            //Rogue
            visibleList.Add(lblRogSneakAttack);
            visibleList.Add(nudRogSneakAttack);
            //Sorcerer
            visibleList.Add(lblSorSpellSlots);
            visibleList.Add(nudSorSpellSlots);
            //Wizard
            visibleList.Add(lblWizSpellsKnown);
            visibleList.Add(nudWizSpellsKnown);
            visibleList.Add(lblWizFamiliar);
            visibleList.Add(cmbWizFamiliar);
        }                   

        private void menuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //randomizing player stats
            player.SetStats();
            nudSTR.Value = player.GetStrength();
            nudDEX.Value = player.GetDexterity();
            nudCON.Value = player.GetConstitution();
            nudINT.Value = player.GetIntelligence();
            nudWIS.Value = player.GetWisdom();
            nudCHA.Value = player.GetCharisma();

        }

        //Clicking the add button
        private void actAdd_Click(object sender, EventArgs e)
        {
            if (txtF_Name.Text == "" || txtL_Name.Text == "")
            {
                MessageBox.Show("Make sure your character has a first and last name", "Error!");
                return;
            }
            else if (cmbRace.SelectedIndex == -1 || cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Your character must have a class and a race", "Error!");
                return;
            }
            klass = cmbClass.Text;
            //adding a new character to the character lists
            switch (klass)
            {
                case "Cleric":
                    mList.Add(new Cleric(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, 
                        (int) nudCleUndead.Value));
                    nudCleUndead.Value = 0;
                    break;
                case "Druid":
                    mList.Add(new Druid(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, 
                        cmbDruPetRace.Text));
                    cmbDruPetRace.SelectedIndex = -1;
                    break;
                case "Fighter":
                    mList.Add(new Fighter(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, 
                        (int) nudFigExtraFeats.Value));
                    nudFigExtraFeats.Value = 0;
                    break;
                case "Monk":
                    mList.Add(new Monk(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, (int) nudMonExtraAttacks.Value));
                    nudMonExtraAttacks.Value = 0;
                    break;
                case "Paladin":
                    mList.Add(new Paladin(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, (int) nudPalLayHands.Value));
                    nudPalLayHands.Value = 0;
                    break;
                case "Ranger":
                    mList.Add(new Ranger(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, cmbRanRace.Text,
                        cmbRanSize.Text));
                    cmbRanRace.SelectedIndex = -1;
                    cmbRanSize.SelectedIndex = -1;
                    break;
                case "Rogue":
                    mList.Add(new Rogue(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, 
                        (int)nudRogSneakAttack.Value));
                    nudRogSneakAttack.Value = 0;
                    break;
                case "Sorcerer":
                    mList.Add(new Sorcerer(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, 
                        (int)nudSorSpellSlots.Value));
                    nudSorSpellSlots.Value = 0;
                    break;
                case "Wizard":
                    mList.Add(new Wizard(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, 
                        (int)nudWizSpellsKnown.Value, cmbWizFamiliar.Text));
                    nudWizSpellsKnown.Value = 0;
                    cmbWizFamiliar.SelectedIndex = -1;
                    break;
                default:
                    break;
            }
            //showing character name in the lbx
            lbxCharacters.Items.Add(txtF_Name.Text + " " + txtL_Name.Text);

            //resetting all of the boxes to empty
            txtF_Name.Text = "";
            txtL_Name.Text = "";
            nudAge.Value = 0;
            cmbRace.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            nudSTR.Value = 0;
            nudDEX.Value = 0;
            nudCON.Value = 0;
            nudINT.Value = 0;
            nudWIS.Value = 0;
            nudCHA.Value = 0;
        }

        private void actDelete_Click(object sender, EventArgs e)
        {
            txtF_Name.Text = "";
            txtL_Name.Text = "";
            nudAge.Value = 0;
            cmbRace.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            nudSTR.Value = 0;
            nudDEX.Value = 0;
            nudCON.Value = 0;
            nudINT.Value = 0;
            nudWIS.Value = 0;
            nudCHA.Value = 0;

            //Checking if the index is in the main list
            if (lbxCharacters.SelectedIndex < mList.Count && lbxCharacters.SelectedIndex >= 0)
            {
                //removing character from the list and the lbx
                mList.RemoveAt(lbxCharacters.SelectedIndex);
                lbxCharacters.Items.RemoveAt(lbxCharacters.SelectedIndex);
            }

            for (int i = 0; i < visibleList.Count; i++)
                visibleList[i].Visible = false;

        }
        
        //clicking on a character in the lbx
        private void lbxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            //setting all of the text boxes to have the character's values
            if (lbxCharacters.SelectedIndex >= 0 && lbxCharacters.SelectedIndex < mList.Count)
            {
                txtF_Name.Text = mList[lbxCharacters.SelectedIndex].GetFirstName();
                txtL_Name.Text = mList[lbxCharacters.SelectedIndex].GetLastName();
                nudAge.Value = mList[lbxCharacters.SelectedIndex].GetAge();
                cmbRace.Text = mList[lbxCharacters.SelectedIndex].GetRace();
                cmbClass.Text = mList[lbxCharacters.SelectedIndex].GetKlass();
                nudSTR.Value = mList[lbxCharacters.SelectedIndex].GetStrength();
                nudDEX.Value = mList[lbxCharacters.SelectedIndex].GetDexterity();
                nudCON.Value = mList[lbxCharacters.SelectedIndex].GetConstitution();
                nudINT.Value = mList[lbxCharacters.SelectedIndex].GetIntelligence();
                nudWIS.Value = mList[lbxCharacters.SelectedIndex].GetWisdom();
                nudCHA.Value = mList[lbxCharacters.SelectedIndex].GetCharisma();

                switch (klass)
                {
                    case "Cleric":
                        nudCleUndead.Value = ((Cleric)mList[lbxCharacters.SelectedIndex]).GetUses();
                        break;
                    case "Druid":
                        cmbDruPetRace.Text = ((Druid)mList[lbxCharacters.SelectedIndex]).GetPet();
                        break;
                    case "Fighter":
                        nudFigExtraFeats.Value = ((Fighter)mList[lbxCharacters.SelectedIndex]).GetFeats();
                        break;
                    case "Monk":
                        nudMonExtraAttacks.Value = ((Monk)mList[lbxCharacters.SelectedIndex]).GetAttacks();
                        break;
                    case "Paladin":
                        nudPalLayHands.Value = ((Paladin)mList[lbxCharacters.SelectedIndex]).GetHands();
                        break;
                    case "Ranger":
                        cmbRanRace.Text = ((Ranger)mList[lbxCharacters.SelectedIndex]).GetPetRace();
                        cmbRanSize.Text = ((Ranger)mList[lbxCharacters.SelectedIndex]).GetPetSize();
                        break;
                    case "Rogue":
                        nudRogSneakAttack.Value = ((Rogue)mList[lbxCharacters.SelectedIndex]).GetSneak();
                        break;
                    case "Sorcerer":
                        nudSorSpellSlots.Value = ((Sorcerer)mList[lbxCharacters.SelectedIndex]).GetSlots();
                        break;
                    case "Wizard":
                        nudWizSpellsKnown.Value = ((Wizard)mList[lbxCharacters.SelectedIndex]).GetSpells();
                        cmbWizFamiliar.Text = ((Wizard)mList[lbxCharacters.SelectedIndex]).GetFamiliar();
                        break;
                    default:
                        break;
                }
            }
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            for (int i = mList.Count - 1; i >= 0; i--)
                lbxCharacters.Items.RemoveAt(i);
            for (int i = mList.Count - 1; i >= 0; i--)
                mList.RemoveAt(i);
            ResetValues();
        }

        private void ResetValues()
        {
            txtF_Name.Text = "";
            txtL_Name.Text = "";
            nudAge.Value = 0;
            cmbRace.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            nudSTR.Value = 0;
            nudDEX.Value = 0;
            nudCON.Value = 0;
            nudINT.Value = 0;
            nudWIS.Value = 0;
            nudCHA.Value = 0;
            nudCleUndead.Value = 0;
            cmbDruPetRace.SelectedIndex = -1;
            nudFigExtraFeats.Value = 0;
            nudMonExtraAttacks.Value = 0;
            nudPalLayHands.Value = 0;
            cmbRanRace.SelectedIndex = -1;
            cmbRanSize.SelectedIndex = -1;
            nudRogSneakAttack.Value = 0;
            nudSorSpellSlots.Value = 0;
            nudWizSpellsKnown.Value = 0;
            cmbWizFamiliar.SelectedIndex = -1;
        }

        private void actUpdate_Click(object sender, EventArgs e)
        {
            if (lbxCharacters.SelectedIndex >= 0 && lbxCharacters.SelectedIndex < mList.Count)
            {
                klass = cmbClass.Text;                

                switch (klass)
                {
                    case "Cleric":
                        mList[lbxCharacters.SelectedIndex] = (new Cleric(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, (int)nudCleUndead.Value));
                        break;
                    case "Druid":
                        mList[lbxCharacters.SelectedIndex] = (new Druid(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, cmbDruPetRace.Text));
                        break;
                    case "Fighter":
                        mList[lbxCharacters.SelectedIndex] = (new Fighter(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, (int) nudFigExtraFeats.Value));
                        break;
                    case "Monk":
                        mList[lbxCharacters.SelectedIndex] = (new Monk(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, (int)nudMonExtraAttacks.Value));
                        break;
                    case "Paladin":
                        mList[lbxCharacters.SelectedIndex] = (new Paladin(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, (int)nudPalLayHands.Value));
                        break;
                    case "Ranger":
                        mList[lbxCharacters.SelectedIndex] = (new Ranger(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, cmbRanRace.Text, cmbRanSize.Text));
                        break;
                    case "Rogue":
                        mList[lbxCharacters.SelectedIndex] = (new Rogue(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, (int)nudRogSneakAttack.Value));
                        break;
                    case "Sorcerer":
                        mList[lbxCharacters.SelectedIndex] = (new Sorcerer(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, (int)nudSorSpellSlots.Value));
                        break;
                    case "Wizard":
                        mList[lbxCharacters.SelectedIndex] = (new Wizard(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value, (int)nudWizSpellsKnown.Value, cmbWizFamiliar.Text));
                        break;
                    default:
                        break;
                }
                lbxCharacters.Items[lbxCharacters.SelectedIndex] = txtF_Name.Text + " " + txtL_Name.Text;
            }
            ResetValues();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            klass = cmbClass.Text;

            for (int i = 0; i < visibleList.Count; i++)
                visibleList[i].Visible = false;

            switch (cmbClass.Text)
            {
                case "Cleric":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Cle"))
                            visibleList[i].Visible = true;
                    }                     
                    break;
                case "Druid":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Dru"))
                            visibleList[i].Visible = true;
                    }
                    break;
                case "Fighter":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Fig"))
                            visibleList[i].Visible = true;
                    }
                    break;
                case "Monk":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Mon"))
                            visibleList[i].Visible = true;
                    }
                    break;
                case "Paladin":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Pal"))
                            visibleList[i].Visible = true;
                    }
                    break;
                case "Ranger":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Ran"))
                            visibleList[i].Visible = true;
                    }
                    break;
                case "Rogue":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Rog"))
                            visibleList[i].Visible = true;
                    }
                    break;
                case "Sorcerer":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Sor"))
                            visibleList[i].Visible = true;
                    }
                    break;
                case "Wizard":
                    for (int i = 0; i < visibleList.Count; i++)
                    {
                        if (visibleList[i].Name.Contains("Wiz"))
                            visibleList[i].Visible = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}