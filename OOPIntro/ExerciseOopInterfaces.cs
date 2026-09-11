namespace OOPIntro;
#region info
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

// Breakdown of interfaces, abstracts, and inheriting classes:
// An interface: A contract which describes requirements for any class which implements it.
// class:interface -> The class must implement the contract defined in the interface.

// An abstract class: Holds the abstract logic for handling data.
// class:abstract -> The inheriting class has access to the logic of the abstract parent. 
// The data in the class constructor gets passed to the abstract parent constructor. 
// The data is then operated on according to the instructions in the abstract class.

#endregion

#region Interfaces
public interface IAnimal
{
    string Name { get; set; }
    string Sound { get; set; }
    string Sleep { get; set; }
    string[] GetProperties();
    void DisplayProperties(string[] properties);
}
public interface IFourLegs
{
    string FourLeggedRun { get; set; }
}
public interface IFlyer
{
    string Nesting { get; set; }
}
#endregion

#region Abstract classes
public abstract class Animal : IAnimal
{
    public string Name { get; set; }
    public string Sound { get; set; }
    public string Sleep { get; set; }
    protected Animal(string name, string sound, string sleep)
    {
        Name = name;
        Sound = sound;
        Sleep = sleep;
    }
    public virtual string[] GetProperties()
    {
        return [Name,Sound,Sleep];
    }
    public void DisplayProperties(string[] properties)
    {
        Console.WriteLine("");
        foreach (string property in properties)
        {
            Console.WriteLine(property);
        }
    }
}
#endregion

#region Inheriting classes
public class Dog : Animal, IFourLegs
{
    public string FourLeggedRun { get; set; }
    
    public Dog() : base("Dog.", "Woof woof!", "Sleeps on back.")
    {
        FourLeggedRun = "Runs on four legs.";
    }

    public override string[] GetProperties()
    {
        return [Name,Sound,Sleep,FourLeggedRun];
    }
}
public class Cat : Animal, IFourLegs
{
    public string FourLeggedRun { get; set; }
    
    public Cat() : base("Cat.", "Mjau.", "Sleeps in bed.")
    {
        FourLeggedRun = "Runs (gracefully) on four legs.";
    }

    public override string[] GetProperties()
    {
        return [Name,Sound,Sleep,FourLeggedRun];
    }

}
#endregion

