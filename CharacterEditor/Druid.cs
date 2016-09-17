using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class Druid : Character
    {
        string PetRace;

        public Druid(string first, string last, int age, string race, string klass, int str, int dex, int con, 
            int intell, int wis, int cha, string pet) : base (first, last, age, race, klass, str, dex, con, intell, wis, cha)
        {
            PetRace = pet;
        }

        public string GetPet()
        {
            return PetRace;
        }
    }

}
