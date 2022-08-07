namespace WAPP_V1.Unit.Profile;
public class Profile
{
    public readonly Attacks Attacks;
    public readonly Ballisticskill Ballisticskill;
    public readonly Initiative Initiative;
    public readonly Leadership Leadership;
    public readonly Movement Movement;
    public readonly Strength Strength;
    public readonly Toughness Toughness;
    public readonly Weaponskill Weaponskill;
    public readonly Wounds Wounds;
    public readonly string Name;
    
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
            string name)
    {
        this.Attacks = attacks;
        this.Ballisticskill = ballisticskill;
        this.Initiative = initiative;
        this.Leadership = leadership;
        this.Movement = movement;
        this.Strength = strength;
        this.Toughness = toughness;
        this.Weaponskill = weaponskill;
        this.Wounds = wounds;
        this.Name = name;
    }
    
    public override string ToString() =>
        $"{Name}\r\n" +
        $"{Movement.Abbreviation}\t{Weaponskill.Abbreviation}\t{Ballisticskill.Abbreviation}\t{Strength.Abbreviation}\t{Toughness.Abbreviation}\t{Wounds.Abbreviation}\t{Initiative.Abbreviation}\t{Attacks.Abbreviation}\t{Leadership.Abbreviation}\r\n" +
        $"{Movement.Value}\t{Weaponskill.Value}\t{Ballisticskill.Value}\t{Strength.Value}\t{Toughness.Value}\t{Wounds.Value}\t{Initiative.Value}\t{Attacks.Value}\t{Leadership.Value}";
}