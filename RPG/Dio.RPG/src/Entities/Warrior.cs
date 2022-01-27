using Dio.RPG.Entities.Enum;
using RPG.Entities;

namespace Dio.RPG.Entities
{
  public class Warrior : Hero
  {
    public Warrior(string name, int age = 0, int level = 1, WarriorTypes type = default) : base(name, age, level)
    {
      Type = type;
    }

    public WarriorTypes Type { get; set; }
    
    public override string Attack(Character character, int bonusDamage=1)
    {
        int damage = Level * bonusDamage;
      return $"{Name} atacou {character.Name} com sua espada. {character.Name} sofreu {damage} de dano.";
    }

  }
}