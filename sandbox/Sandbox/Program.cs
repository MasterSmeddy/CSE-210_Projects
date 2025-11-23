using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");

        Animal someAnimal = new Dog();
        Animal anotherAnimal = new Cat();
        Animal animal3 = new Ostrich();

        List<Animal> animals = new List<Animal>();
        animals.Add(someAnimal);
        animals.Add(anotherAnimal);
        animals.Add(animal3);

        foreach (Animal a in animals)
        {
            Console.WriteLine(a.GetSound());
        }
    }
}