namespace RPG.Entities
{
    public abstract class Player : Character
    {
        protected Player(string name, int age = 0, int level = 1) : base(name, age)
        {
            Level = level;
        }

        public int Level { get; set; }
    }
}
