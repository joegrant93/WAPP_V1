using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPP_V1.Unit.Profile
{
    /// <summary>
    /// The characteristics values can be:
    /// 0-10, - representing a null, * representing a unique value, or a dice formula e.g., 2d6 [2 x 6-sided-die] or 1d4 [1 x 4-sided-die]
    /// 
    /// I was considering having a class just for accepted values for a characteristic. Eg Attacks attacks = new Attacks(CharacteristicValue.One);
    /// </summary>
    public class Charateristic {
        public Charateristic(string value) => Value = value;
        public readonly string Value;
        public string Name = "";
        public string Abbreviation = "";
    }
    public class Attacks : Charateristic
    {
        public Attacks(string value) : base(value)
        {
            Name = "Attacks";
            Abbreviation = "A";
        }
    }
    public class Ballisticskill : Charateristic
    {
        public Ballisticskill(string value) : base(value)
        {
            Name = "Ballisticskill";
            Abbreviation = "BS";
        }
    }
    public class Initiative : Charateristic
    {
        public Initiative(string value) : base(value)
        {
            Name = "Initiative";
            Abbreviation = "I";
        }
    }
    public class Leadership : Charateristic
    {
        public Leadership(string value) : base(value)
        {
            Name = "Leadership";
            Abbreviation = "Ld";
        }
    }
    public class Movement : Charateristic
    {
        public Movement(string value) : base(value)
        {
            Name = "Movement";
            Abbreviation = "M";
        }
    }
    public class Strength : Charateristic
    {
        public Strength(string value) : base(value)
        {
            Name = "Strength";
            Abbreviation = "S";
        }
    }
    public class Toughness : Charateristic
    {
        public Toughness(string value) : base(value)
        {
            Name = "Toughness";
            Abbreviation = "T";
        }
    }
    public class Weaponskill : Charateristic
    {
        public Weaponskill(string value) : base(value)
        {
            Name = "Weaponskill";
            Abbreviation = "WS";
        }
    }
    public class Wounds : Charateristic
    {
        public Wounds(string value) : base(value)
        {
            Name = "Wounds";
            Abbreviation = "W";
        }
    }
}
