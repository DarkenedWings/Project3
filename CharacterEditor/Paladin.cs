using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Paladin : Character
    {
        int mLayHands;
        public Paladin(string first, string last, int age, string race, string klass, int str, int dex, int con, int intell, int wis, int cha, int hands) :
            base(first, last, age, race, klass, str, dex, con, intell, wis, cha)
        {
            mLayHands = hands;
        }

        public int GetHands()
        {
            return mLayHands;
        }
    }
}
