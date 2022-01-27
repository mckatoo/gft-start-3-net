namespace RPG.Entities
{
    public abstract class Hero : Player
    {
        public Hero(string name, int age = 0, int level = 1) : base(name, age, level) { }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nLevel: {Level}";
        }

        public virtual string Attack(Character character, int bonusDamage=1)
        {
            return $"{Name} attacks {character.Name}";
        }
    }
}
