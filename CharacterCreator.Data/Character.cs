using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data
{
    public enum AdventurerClass
    {
        Barbarian = 0,
        Bard = 1,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard
    }
    public enum Race
    {
        Dwarf = 0,
        Elf = 1,
        Halfling,
        Human,
        Dragonborn,
        Gnome,
        HalfElf,
        HalfOrc,
        Tiefling
    }
    public class Character
    {

        public Race ARace { get; set; }
        public AdventurerClass AClass { get; set; }
        public string Name { get; set; }
        public string Background { get; set; }
        public int StrScore { get; set; }
        public int DexScore { get; set; }
        public int ConScore { get; set; }
        public int IntScore { get; set; }
        public int WisScore { get; set; }
        public int ChaScore { get; set; }
        public string SavingThrow1 { get; set; }
        public string SavingThrow2 { get; set; }
        public int Level { get; }

    }
}
