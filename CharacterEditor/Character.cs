using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Character
    {
        int Str;
        int Dex;
        int Con;
        int Int;
        int Wis;
        int Cha;

        string mFirstName;
        string mLastName;
        int mAge;
        string mRace;
        string mKlass;

        Random RNG = new Random();


        public Character()
        {

        }

        public Character(string first, string last, int age, string race, string klass, int str, int dex, int con, int intell, int wis, int cha)
        {
            mFirstName = first;
            mLastName = last;
            mAge = age;
            mRace = race;
            mKlass = klass;
            Str = str;
            Dex = dex;
            Con = con;
            Int = intell;
            Wis = wis;
            Cha = cha;
        }


        public void SetStats()
        {
            Str = RNG.Next(1, 25);
            Dex = RNG.Next(1, 25);
            Con = RNG.Next(1, 25);
            Int = RNG.Next(1, 25);
            Wis = RNG.Next(1, 25);
            Cha = RNG.Next(1, 25);
        }

        public string GetFirstName()
        {
            return mFirstName;
        }

        public string GetLastName()
        {
            return mLastName;
        }

        public int GetAge()
        {
            return mAge;
        }

        public string GetRace()
        {
            return mRace;
        }

        public string GetKlass()
        {
            return mKlass;
        }
        public int GetStrength()
        {
            return Str; 
        }
        public int GetDexterity()
        {
            return Dex;
        }
        public int GetConstitution()
        {
            return Con;
        }
        public int GetIntelligence()
        {
            return Int;
        }
        public int GetWisdom()
        {
            return Wis;
        }
        public int GetCharisma()
        {
            return Cha;
        }
    }
}
