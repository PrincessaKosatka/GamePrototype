using System;

namespace GamePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character("Arthur", 30, 6);

            Character goblin = new Character("Goblin", 18, 2);

            Console.WriteLine($"{player.Name}: {player.Health}/{player.MaxHealth} HP, урон: {player.BaseDamage}");

            Console.WriteLine($"{goblin.Name}: {goblin.Health}/{goblin.MaxHealth} HP, урон {goblin.BaseDamage}");
        }
    }

}