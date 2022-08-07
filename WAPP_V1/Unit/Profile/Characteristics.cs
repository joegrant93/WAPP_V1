namespace WAPP_V1.Unit.Profile;
public abstract class Charateristic
{
    public Charateristic(string value) {
        Value = value;
        Name = GetType().Name;
        Abbreviation = Name[..1];
    }
    public readonly string Value;
    public string Name;
    public string Abbreviation;
}

public sealed class Attacks : Charateristic
{
    public Attacks(string value) : base(value) { }
}

public sealed class Ballisticskill : Charateristic
{
    public Ballisticskill(string value) : base(value)
    {
        Abbreviation = "BS";
    }
}

public sealed class Initiative : Charateristic
{
    public Initiative(string value) : base(value) { }
}

public sealed class Leadership : Charateristic
{
    public Leadership(string value) : base(value)
    {
        Abbreviation = "Ld";
    }
}

public sealed class Movement : Charateristic
{
    public Movement(string value) : base(value) { }
}

public class Strength : Charateristic
{
    public Strength(string value) : base(value) { }
}

public class Toughness : Charateristic
{
    public Toughness(string value) : base(value) { }
}

public class Weaponskill : Charateristic
{
    public Weaponskill(string value) : base(value)
    {
        Abbreviation = "WS";
    }
}

public class Wounds : Charateristic
{
    public Wounds(string value) : base(value) { }
}