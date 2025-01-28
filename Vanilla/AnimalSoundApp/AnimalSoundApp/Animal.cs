using System;

public abstract class Animal
{
    public abstract string Type { get; } // Rule: each animal must define its Type
    public void Eat()
    {
        Console.WriteLine("This animal is eating.");    // Shared behavior for all animals
    }
}