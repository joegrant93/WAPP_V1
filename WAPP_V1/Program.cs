using WAPP_V1.Unit.Profile;
using static System.Console;
namespace WAPP_V1;
internal class Program
{
    static void Main(string[] args)
    {
        var goblin = new Profile(
            movement: new Movement("4"),
            weaponskill: new Weaponskill("2"),
            ballisticskill: new Ballisticskill("3"),
            strength: new Strength("3"),
            toughness: new Toughness("3"),
            wounds: new Wounds("1"),
            initiative: new Initiative("2"),
            attacks: new Attacks("1"),
            leadership: new Leadership("6"),
            name: "Goblin");

        WriteLine(goblin);
    }
}