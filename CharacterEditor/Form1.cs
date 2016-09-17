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
            visibleList.Add(nudCleUndead);
            visibleList.Add(lblCleUndead);
            visibleList.Add(lblDruPetRace);
            visibleList.Add(cmbDruPetRace);
            visibleList.Add(lblFigExtraFeats);
            visibleList.Add(nudFigExtraFeats);
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
            klass = cmbClass.Text;
            //adding a new character to the character lists
            switch (klass)
            {
                case "Cleric":
                    mList.Add(new Cleric(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value, 
                        (int) nudCleUndead.Value));
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
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value));
                    break;
                case "Paldin":
                    mList.Add(new Paladin(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value));
                    break;
                case "Ranger":
                    mList.Add(new Ranger(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value));
                    break;
                case "Rogue":
                    mList.Add(new Rogue(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value));
                    break;
                case "Sorcerer":
                    mList.Add(new Sorcerer(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value));
                    break;
                case "Wizard":
                    mList.Add(new Wizard(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, klass, (int)nudSTR.Value,
                        (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value));
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
            cmbRace.ResetText();
            cmbClass.Text = "";
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
                        break;
                    case "Paldin":
                        break;
                    case "Ranger":
                        break;
                    case "Rogue":
                        break;
                    case "Sorcerer":
                        break;
                    case "Wizard":
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
                            (int)nudWIS.Value, (int)nudCHA.Value));
                        break;
                    case "Paldin":
                        mList[lbxCharacters.SelectedIndex] = (new Paladin(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value));
                        break;
                    case "Ranger":
                        mList[lbxCharacters.SelectedIndex] = (new Ranger(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value));
                        break;
                    case "Rogue":
                        mList[lbxCharacters.SelectedIndex] = (new Rogue(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value));
                        break;
                    case "Sorcerer":
                        mList[lbxCharacters.SelectedIndex] = (new Sorcerer(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value));
                        break;
                    case "Wizard":
                        mList[lbxCharacters.SelectedIndex] = (new Wizard(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value,
                            cmbRace.Text, klass, (int)nudSTR.Value, (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value,
                            (int)nudWIS.Value, (int)nudCHA.Value));
                        break;
                    default:
                        break;
                }
            }
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
                default:
                    break;
            }

        }
    }
}