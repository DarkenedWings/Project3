using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Ranger : Character
    {
        string mPetRace;
        string mPetSize;

        public Ranger(string first, string last, int age, string race, string klass, int str, int dex, int con, int intell, int wis, int cha, string petrace, string size) :
            base(first, last, age, race, klass, str, dex, con, intell, wis, cha)
        {
            mPetRace = petrace;
            mPetSize = size;
        }

        public string GetPetRace()
        {
            return mPetRace;
        }

        public string GetPetSize()
        {
            return mPetSize;
        }
    }
}
