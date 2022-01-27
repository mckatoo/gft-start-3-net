using Dio.RPG.Entities;
using RPG.Entities;

namespace Dio.RPG;

public class Program
{
    public static void Main(string[] args)
    {
      Warrior arus = new Warrior("Arus", 20);
      System.Console.WriteLine($"{arus.Name} is online");

      Wizard kobold = new Wizard("Kobold", 40);
      System.Console.WriteLine($"{kobold.Name} is online");

      System.Console.WriteLine(arus.Attack(kobold, 10));
      System.Console.WriteLine(kobold.Attack(arus));
    }
}