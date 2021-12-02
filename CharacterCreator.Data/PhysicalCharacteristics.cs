using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data
{
    public enum HairColor
    {
        Brown = 0,
        Red = 1,
        White,
        Black,
        Blonde
    }
    public enum EyeColor
    {
        Hazel = 0,
        Green,
        Blue,
        Silver,
        Amber
    }
    public class PhysicalCharacteristics
    {
        public EyeColor Eyes { get; set; }
        public HairColor Hair { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string SkinColor { get; set; }
        public int Age { get; set; }
    }

}
