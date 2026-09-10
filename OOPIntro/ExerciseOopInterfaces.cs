namespace OOPIntro;
// Exercise - Interface IAnimal
// Recreate the following abstraction with an interface
//https://www.w3schools.com/cs/cs_abstract.php
//https://www.codecademy.com/resources/docs/c-sharp/interfaces
// Create the interface IAnimal, and a couple of implenmentations such as Cat,Dog,Bird.
// Create another interface and let one of the classes implement that one.
//      For example ICanFly, IHasFourLegs

// abstract class Animal
// {
//     public abstract void animalSound();
//
//     public void sleep()
//     {
//         Console.WriteLine("Zzz");
//     }
// }


// Interfaces
public interface IAnimal
{
    string Name { get; set; }
    string Sound { get; set; }
    string Sleep { get; set; }
    string Move { get; set; }
    string[] Properties { get; set; }
    void DisplayProperties();
}

public interface IFlyer
{
    string Nesting { get; set; }
}
//Abstract class
public abstract class Animal : IAnimal
{
    public string Name { get; set; }
    public string Sound { get; set; }
    public string Sleep { get; set; }
    public string Move { get; set; }
    public string[] Properties { get; set; }

    public Animal()
    {
        Name = "Animal";
        Sound = "Makes sounds.";
        Sleep = "Sleeps.";
        Move = "Moves.";
        Properties = [Name,Sound,Sleep,Move];
    }

    public virtual void DisplayProperties()
    {
        foreach (var property in Properties)
        {
            Console.WriteLine(property);
        }
    }
}
//Inherited class
public class Dog : Animal
{
    public Dog()
    {
        Name = "Dog";
        Sound = "Woof Woof.";
        Sleep = "Sleeps on back.";
        Move = "Runs on all fours";
        Properties = [Name,Sound,Sleep,Move];
    }
}

public class Bird : Animal, IFlyer
{
    public string Nesting { get; set; }
    
    public Bird()
    {
        Name = "Bird.";
        Sound = "Chirp Chirp.";
        Sleep = "Sleeps curled up.";
        Move = "Flies in the air.";
        Nesting = "Builds nests..";
        Properties = [Name,Sound,Sleep,Move,Nesting];
    }
}