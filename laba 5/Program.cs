using System;
public interface ISound
{
    void MakeSound();
}
public interface IFlight
{
    void MaximumFlightAltitude();
}
public interface IMove
{
    void MoveSpeed();
}
public abstract class Animal
{
    public int Age { get; set; }

    public Animal(int age)
    {
        Age = age;
    }
}

public class Bird : Animal, ISound, IFlight, IMove
{
    public string Species { get; set; }
    public double MaxFlightHeight { get; set; }
    public double MaxSpeed { get; set; }

    public Bird(int age, string species, double maxFlightHeight, double maxSpeed) : base(age)
    {
        Species = species;
        MaxFlightHeight = maxFlightHeight;
        MaxSpeed = maxSpeed;
    }

    public void MakeSound()
    {
        Console.WriteLine("Chirp chirp!");
    }
    public void MaximumFlightAltitude()
    {
        Console.WriteLine($"Maximum flight altitude: {MaxFlightHeight} km");
    }
    public void MoveSpeed()
    {
        Console.WriteLine($"Maximum flight speed: {MaxSpeed} km/h");
    }
}

public class Sparrow : Bird
{
    public Sparrow(int age, string species, double maxFlightHeight, double maxSpeed) : base(age, species, maxFlightHeight, maxSpeed)
    {
    }
    public void MakeSound()
    {
        Console.WriteLine("Tweet tweet!");
    }
}

public class Pigeon : Bird
{
    public Pigeon(int age, string species, double maxFlightHeight, double maxSpeed) : base(age, species, maxFlightHeight, maxSpeed)
    {
    }
    public void MakeSound()
    {
        Console.WriteLine("Coo coo!");
    }
}

public class Owl : Bird
{
    public Owl(int age, string species, double maxFlightHeight, double maxSpeed) : base(age, species, maxFlightHeight, maxSpeed)
    {
    }
    public void MakeSound()
    {
        Console.WriteLine("Hoot hoot!");
    }
}

public class Ostrich : Bird
{
    public Ostrich(int age, string species, double maxFlightHeight, double maxSpeed) : base(age, species, maxFlightHeight, maxSpeed)
    {
    }
    public void MoveSpeed()
    {
        Console.WriteLine("Running at a speed of 70 km/h");
    }
}
public class Dog : Animal, ISound
{
    public string Breed { get; set; }
    public Dog(int age, string breed) : base(age)
    {
        Breed = breed;
    }
    public void MakeSound()
    {
        Console.WriteLine("Woof woof!");
    }
    public void MoveSpeed()
    {
        Console.WriteLine("Running at a speed of 25 km/h");
    }
}
public class Cat : Animal, ISound
{
    public string Color { get; set; }
    public Cat(int age, string color) : base(age)
    {
        Color = color;
    }
    public void MakeSound()
    {
        Console.WriteLine("Meow meow!");
    }
    public void MoveSpeed()
    {
        Console.WriteLine("Running at a speed of 20 km/h");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Sparrow sparrow = new Sparrow(2, "Domestic", 10, 15);
        Dog labrador = new Dog(3, "Labrador");
        Cat persianCat = new Cat(4, "White");
        Pigeon pigeon = new Pigeon(3, "Street", 20, 30);
        Owl owl = new Owl(4, "Predator", 15, 5);
        Ostrich ostrich = new Ostrich(5, "Demon", 0, 0);

        Console.WriteLine("Sparrow:");
        sparrow.MakeSound();
        sparrow.MoveSpeed();
        sparrow.MaximumFlightAltitude();
        Console.WriteLine();

        Console.WriteLine("Pigeon:");
        pigeon.MakeSound();
        pigeon.MoveSpeed();
        pigeon.MaximumFlightAltitude();
        Console.WriteLine();

        Console.WriteLine("Owl:");
        owl.MakeSound();
        owl.MoveSpeed();
        owl.MaximumFlightAltitude();
        Console.WriteLine();

        Console.WriteLine("Ostrich:");
        ostrich.MakeSound();
        ostrich.MoveSpeed();
        ostrich.MaximumFlightAltitude();
        Console.WriteLine();

        Console.WriteLine("Dog:");
        labrador.MakeSound();
        labrador.MoveSpeed();
        Console.WriteLine();

        Console.WriteLine("Cat:");
        persianCat.MakeSound();
        persianCat.MoveSpeed();
    }
}