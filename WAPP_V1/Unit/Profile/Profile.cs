using WAPP_V1.Unit.Profile;

namespace WAPP_V1.Unit.Profile
{
    public class Profile
    {
        /// <summary>
        /// A Profile is a collection of characteristics
        /// </summary>
        public Profile(
                Attacks attacks,
                Ballisticskill ballisticskill,
                Initiative initiative,
                Leadership leadership,
                Movement movement,
                Strength strength,
                Toughness toughness,
                Weaponskill weaponskill,
                Wounds wounds,
                string name
            ) {
            this.attacks = attacks;
            this.ballisticskill = ballisticskill;
            this.initiative = initiative;
            this.leadership = leadership;
            this.movement = movement;
            this.strength = strength;
            this.toughness = toughness;
            this.weaponskill = weaponskill;
            this.wounds = wounds;
            this.name = name;
        }
        public readonly Attacks attacks;
        public readonly Ballisticskill ballisticskill;
        public readonly Initiative initiative;
        public readonly Leadership leadership;
        public readonly Movement movement;
        public readonly Strength strength;
        public readonly Toughness toughness;
        public readonly Weaponskill weaponskill;
        public readonly Wounds wounds;

        public readonly string name;
        /// <summary>
        /// ToString() override just here to print to console that everything is working.
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            $"{name}\r\n" +
            $"{movement.Abbreviation}\t{weaponskill.Abbreviation}\t{ballisticskill.Abbreviation}\t{strength.Abbreviation}\t{toughness.Abbreviation}\t{wounds.Abbreviation}\t{initiative.Abbreviation}\t{attacks.Abbreviation}\t{leadership.Abbreviation}\r\n" +
            $"{movement.Value}\t{weaponskill.Value}\t{ballisticskill.Value}\t{strength.Value}\t{toughness.Value}\t{wounds.Value}\t{initiative.Value}\t{attacks.Value}\t{leadership.Value}";
    }
}
