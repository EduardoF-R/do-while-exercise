/*
Made this code for the microsoft learn "Learn C#" Series
exercise "Add looping logic to your code using the do-while and while statements in C#"
the exercise asks for a simulation of a RPG battle between a hero and a monster.
*/
Random dice = new Random();
int damage = dice.Next(1, 11);
int heroHP =  10;
int monsterHP = 10;

do
{
    monsterHP -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health, monster now has {monsterHP} health.");

    if (monsterHP >= 1)
    {
        heroHP -=damage;
        Console.WriteLine($"hero was damaged and lost {damage} health, hero now has {heroHP} health.");
    }
    else if (monsterHP <= 0)
    {
        Console.WriteLine("The Monster was slain.");
    }
    else
        Console.WriteLine("The hero was slain");
} while (monsterHP > 0 && heroHP > 0);

