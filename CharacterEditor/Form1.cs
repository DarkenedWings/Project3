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

        public Form1()
        {
            InitializeComponent();
            //switch (cmbClass.Text)
            //{
            //    case "Cleric":
            //        nudTurnUndead = Enabled;
            //        break;
            //    default:
            //        break;
            //}
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
            //adding a new character to the character lits
            mList.Add(new Character(txtF_Name.Text, txtL_Name.Text, (int)nudAge.Value, cmbRace.Text, (int)nudSTR.Value,
                (int)nudDEX.Value, (int)nudCON.Value, (int)nudINT.Value, (int)nudWIS.Value, (int)nudCHA.Value));
            //showing character name in the lbx
            lbxCharacters.Items.Add(txtF_Name.Text + " " + txtL_Name.Text);

            //resetting all of the boxes to empty
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
                nudSTR.Value = mList[lbxCharacters.SelectedIndex].GetStrength();
                nudDEX.Value = mList[lbxCharacters.SelectedIndex].GetDexterity();
                nudCON.Value = mList[lbxCharacters.SelectedIndex].GetConstitution();
                nudINT.Value = mList[lbxCharacters.SelectedIndex].GetIntelligence();
                nudWIS.Value = mList[lbxCharacters.SelectedIndex].GetWisdom();
                nudCHA.Value = mList[lbxCharacters.SelectedIndex].GetCharisma();
                //I made changes
            }
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            for (int i = mList.Count - 1; i >= 0; i--)
                lbxCharacters.Items.RemoveAt(i);
            for (int i = mList.Count - 1; i >= 0; i--)
                mList.RemoveAt(i);
        }
    }
}
