using System;
using System.Collections.Generic;

namespace OOP_Excercise_03_003;

// 1. Skapar abstrakt klass Animal
public abstract class Animal
{
    // 2. Fyll Animal med djurens egenskaper
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }

    // 4. Lägg till konstruktor
    protected Animal(string name, double weight, int age)
    {
        Name = name;
        Weight = weight;
        Age = age;
    }

    // 3. Skapa abstrakt metod
    public abstract void DoSound();
}

// 5. Subklasser, ärver från Animal:
public class Horse : Animal
{
    public double Height { get; set; } // Exempel, unik egenskap

    public Horse(string name, double weight, int age, double height)
        : base(name, weight, age)
    {
        Height = height;
    }

    public override void DoSound()
    {
        Console.WriteLine("Yiaaaahhhhaaa!");
    }
}

public class Dog : Animal
{
    public string Breed { get; set; } // Exempel, unik egenskap

    public Dog(string name, double weight, int age, string breed)
        : base(name, weight, age)
    {
        Breed = breed;
    }

    public override void DoSound()
    {
        Console.WriteLine("Skall!");
    }
}

public class Hedgehog : Animal
{
    public int NrOfSpikes { get; set; } // Exempel, unik egenskap

    public Hedgehog(string name, double weight, int age, int nrOfSpikes)
        : base(name, weight, age)
    {
        NrOfSpikes = nrOfSpikes;
    }

    public override void DoSound()
    {
        Console.WriteLine("Oumpfa!");
    }
}

public class Worm : Animal
{
    public bool IsPoisonous { get; set; } // Exempel, unik egenskap

    public Worm(string name, double weight, int age, bool isPoisonous)
        : base(name, weight, age)
    {
        IsPoisonous = isPoisonous;
    }

    public override void DoSound()
    {
        Console.WriteLine("...");
    }
}

public class Bird : Animal
{
    public double WingSpan { get; set; } // Exempel, unik egenskap

    public Bird(string name, double weight, int age, double wingSpan)
        : base(name, weight, age)
    {
        WingSpan = wingSpan;
    }

    public override void DoSound()
    {
        Console.WriteLine("Kvitter, kvitter!");
    }
}

public class Wolf : Animal
{
    public bool IsAlpha { get; set; } // Exempel, unik egenskap

    public Wolf(string name, double weight, int age, bool isAlpha)
        : base(name, weight, age)
    {
        IsAlpha = isAlpha;
    }

    public override void DoSound()
    {
        Console.WriteLine("Yyyyl!");
    }
}

// 8. Klasser som ärver från Bird
public class Pelican : Bird
{
    public double BeakLength { get; set; } // Exmpel, unik egenskap

    public Pelican(string name, double weight, int age, double wingSpan, double beakLength)
        : base(name, weight, age, wingSpan)
    {
        BeakLength = beakLength;
    }

    public override void DoSound()
    {
        Console.WriteLine("Kruuaaah!");
    }
}

public class Flamingo : Bird
{
    public string Color { get; set; } // Exempel, unik egenskap

    public Flamingo(string name, double weight, int age, double wingSpan, string color)
        : base(name, weight, age, wingSpan)
    {
        Color = color;
    }

    public override void DoSound()
    {
        Console.WriteLine("Kruuaaah!");
    }
}

public class Swan : Bird
{
    public string Habitat { get; set; } // Exempel, unik egenskap

    public Swan(string name, double weight, int age, double wingSpan, string habitat)
        : base(name, weight, age, wingSpan)
    {
        Habitat = habitat;
    }

    public override void DoSound()
    {
        Console.WriteLine("Kruuaaah!");
    }
}

// 10. Interface IPerson, declare Talk();
public interface IPerson
{
    void Talk();
}

// 11. Wolfman ärver från Wolf, implementerar IPersoninterface
public class Wolfman : Wolf, IPerson
{
    public Wolfman(string name, double weight, int age, bool isAlpha)
        : base(name, weight, age, isAlpha) { }

    // 12. Talk() skriver ut Wolfmans ord
    public void Talk()
    {
        Console.WriteLine("Hej, jag är Wolfman!");
    }
}

// Main
class Program
{
    static void Main(string[] args)
    {
        // Instances av djur
        List<Animal> animals = new List<Animal>
        {
            new Horse("Blixten", 500, 5, 1.6),
            new Dog("Fido", 30, 4, "Tax"),
            new Hedgehog("Milo", 1, 2, 100),
            new Worm("Slajm", 0.1, 1, false),
            new Pelican("Peter", 15, 3, 2.5, 0.6),
            new Flamingo("Johan", 5, 2, 1.8, "Pink"),
            new Swan("Odile", 12, 4, 2.0, "Lake"),
            new Wolfman("Wolfie", 70, 6, true)
        };

        // Anropar DoSound() för resp. djur
        foreach (var animal in animals)
        {
            animal.DoSound();

            // Om  Wolfman, aropa Talk()
            if (animal is Wolfman wolfman)
            {
                wolfman.Talk();
            }
        }
    }
}




