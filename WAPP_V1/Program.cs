using System;
using static System.Console;
using WAPP_V1;
using WAPP_V1.Unit;
using WAPP_V1.Unit.Profile;

namespace WAPP_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profile Goblin = new(
                movement: new Movement("4"),
                weaponskill: new Weaponskill("2"),
                ballisticskill: new Ballisticskill("3"),
                strength: new Strength("3"),
                toughness: new Toughness("3"),
                wounds: new Wounds("1"),
                initiative: new Initiative("2"),
                attacks: new Attacks("1"),
                leadership: new Leadership("6"),
                name: "Goblin"
                );
            WriteLine(Goblin);
        }
    }
}