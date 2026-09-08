using System;

namespace GamePrototype
{
    internal class Character
    {
        public string Name { get; }
        public int Health { get; private set; }
        public int MaxHealth { get; }
        public int BaseDamage { get; }

        public Character(string name, int maxHealth, int baseDamage)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя персонажа не может быть пустым", nameof(name));
            }

            if (maxHealth <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxHealth), "Максимальное здоровье должно быть больше нуля");
            }

            if (baseDamage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(baseDamage), "базовый урон не может быть отрицательным");
            }

            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            BaseDamage = baseDamage;
        }
    }
}
