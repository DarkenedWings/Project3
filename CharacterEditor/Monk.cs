using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Monk : Character
    {
        int mExtraAttacks;
        public Monk(string first, string last, int age, string race, string klass, int str, int dex, int con, int intell, int wis, int cha, int attacks) :
            base(first, last, age, race, klass, str, dex, con, intell, wis, cha)
        {
            mExtraAttacks = attacks;
        }

        public int GetAttacks()
        {
            return mExtraAttacks;
        }
    }
}
