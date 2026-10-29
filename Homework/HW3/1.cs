using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

class Character
{
    private string name;
    private int hp;
    private int power;
    private static int count;

    public string Name => name;
    public int Hp => hp;
    public int Power => power;

    public Character(string name, int hp, int power)
    {
        this.name = name;
        this.hp = hp;
        this.power = power;
        count += 1;
    }

    public void Attack(Character target)
    {
        target.hp = target.hp - power;
        Console.WriteLine($"{this.name} аттакует {target.name} нанося {this.power} и отставляет ему {target.hp} здоровья");
    }

    public void GetStatus()
    {
        Console.WriteLine($"Имя: {Name} /n Здровье: {Hp}");
    }

    public static int HowMany()
    {
        return count;
    }

    public static bool IsValidStats(int hp, int power)
    {
        return hp > 0 && power > 0;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp<0) hp = 0;
    }

    public bool IsAllive(int hp)
    {
        return hp > 0;
    }

}

class Player : Character
{
    public Player(string name, int hp, int power) : base(name, hp, power)
    {
    }
}
class Enemy : Character
{
    public Enemy(string name, int hp, int power) : base(name, hp, power)
    {
    }
}
