using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Wizard : Character
    {
        int mSpellsKnown;
        string mFamiliar;

        public Wizard(string first, string last, int age, string race, string klass, int str, int dex, int con, int intell, int wis, int cha, int spells, string familiar) :
            base(first, last, age, race, klass, str, dex, con, intell, wis, cha)
        {
            mSpellsKnown = spells;
            mFamiliar = familiar;
        }

        public int GetSpells()
        {
            return mSpellsKnown;
        }

        public string GetFamiliar()
        {
            return mFamiliar;
        }
    }
}
