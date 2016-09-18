using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Cleric : Character
    {
        int mUndeadUses;
        public Cleric(string first, string last, int age, string race, string klass, int str, int dex, int con, int intell, 
            int wis, int cha, int tuu) : base(first, last, age, race, klass, str, dex, con, intell, wis, cha)
        {
            mUndeadUses = tuu;
        }

        public int GetUses()
        {
            return mUndeadUses;
        }
    }
}