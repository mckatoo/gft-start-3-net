namespace RPG.Entities
{
    public abstract class Character
    {
        protected Character(string name, int? age)
        {
            Name = name;
            Age = age == null ? 0 : age.Value;
        }

        public Guid ID { get; protected set; } = Guid.NewGuid();
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
