﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Rogue : Character
    {
        int mSneakAttack;
        public Rogue(string first, string last, int age, string race, string klass, int str, int dex, int con, int intell, int wis, int cha, int sneak) :
            base(first, last, age, race, klass, str, dex, con, intell, wis, cha)
        {
            mSneakAttack = sneak;
        }

        public int GetSneak()
        {
            return mSneakAttack;
        }
    }
}
