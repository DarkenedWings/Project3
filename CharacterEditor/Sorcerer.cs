﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Sorcerer : Character
    {
        int mSpellSlots;
        public Sorcerer(string first, string last, int age, string race, string klass, int str, int dex, int con, int intell, int wis, int cha, int slots) :
            base(first, last, age, race, klass, str, dex, con, intell, wis, cha)
        {
            mSpellSlots = slots;
        }

        public int GetSlots()
        {
            return mSpellSlots;
        }
    }
}
