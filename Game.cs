using System;

public class Character
{
    public String name;
    public int lifePoint;
    public int attackStrength;
    public int defenseStrength;

    public Character(String name, int lifePoint, int attackStrength, int defenseStrength)
    {
        this.name = name;
        this.lifePoint = lifePoint;
        this.attackStrength = attackStrength;
        this.defenseStrength = defenseStrength;
    }
    public bool isAlive()
    {
        if (this.lifePoint <= 0)
        {
            return false;
        }
        return true;
    }

    public void Attack(Character characterAttacked)
    {
        characterAttacked.lifePoint = characterAttacked.lifePoint - (this.attackStrength - characterAttacked.defenseStrength);
    }
}

public class Game
{
    public static void Main(String[] args)
    {
        Character batman = new Character("Batman", 100, 40, 30);
        Character joker = new Character("Joker", 100, 50, 30);
        Random rnd = new Random();

        while (batman.isAlive() && joker.isAlive())
        {
            if (rnd.Next(0, 2) == 1)
            {
                batman.Attack(joker);
            }
            else
            {
                joker.Attack(batman);

            }
            Console.WriteLine("batman a " + batman.lifePoint + " vies");
            Console.WriteLine("joker a " + joker.lifePoint + " vies");
        }

    }

}
