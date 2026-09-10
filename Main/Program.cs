namespace Main;
using OOPIntro;

class Program
{
    static void Main(string[] args)
    {
        Dog otherDog = new Dog
        {
            Name = "Odd Dog.",
            Sound = "Weff Weff!",
            Sleep = "Sleeps in somersaults.",
            FourLeggedRun = "Runs on two legs."
        };
        Animal[] animals = [new Dog(), new Cat(), otherDog];
        foreach (Animal animal in animals)
        {
            string[] properties = animal.GetProperties();
            animal.DisplayProperties(properties);
        }
    }
}