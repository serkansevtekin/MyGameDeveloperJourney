using System;

namespace Programlama.Tekrars1
{
    enum CharacterClassEnum
    {
        Warrior = 0,
        Mage = 1,
        Archer = 2,
    }

    struct Character
    {
        public string Name;
        public CharacterClassEnum classType;
        public int Level;
        public float AttaclPower;

        public Character(string name, CharacterClassEnum characterClass, int level, float AttaclPower)
        {
            this.Name = name;
            this.classType = characterClass;
            this.Level = level;
            this.AttaclPower = AttaclPower;
        }
        public void levelUp(int AttackValue, int levelValue)
        {
            Level += levelValue;
            AttaclPower += AttackValue;

        }
        public void levelUp(int AttackValue)
        {
            Level++;
            AttaclPower += AttackValue;

        }

        public override string ToString() => $"Karakter: {Name} | Sınıf: {classType} | Seviye: {Level} | Güç: {AttaclPower}";
        
    }
}