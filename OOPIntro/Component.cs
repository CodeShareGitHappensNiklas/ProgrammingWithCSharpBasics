// ReSharper disable ConvertToPrimaryConstructor
namespace OOPIntro;

public abstract class Component
{
    protected string Name { get; set; }
    protected string Type { get; set; }
    
    protected Component(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public void MoboCompatability(Motherboard mobo, Component[] components)
    {
        Console.WriteLine($"\nYou are trying to pair a {mobo.Name} with the following components:\n");
        foreach (Component component in components)
        {
            Console.WriteLine("");
            switch (component)
            {
                case Cpu cpu:
                    if (cpu.Socket != mobo.Socket) cpu.IncompatibleMessage(mobo);
                    else CompatibleMessage(mobo);
                    break;
                case Ram ram:
                    if (ram.MemoryType != mobo.MemoryType) ram.IncompatibleMessage(mobo);
                    else CompatibleMessage(mobo);
                    break;
            }
        }
    }

    protected virtual void IncompatibleMessage(Motherboard mobo)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine
        ($"Type: {this.Type}. Name {this.Name}" +
         $"\nThe {this.Type} does not match the mobo {mobo.Name}!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    protected virtual void CompatibleMessage(Motherboard mobo)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{this.Name} is compatible with {mobo.Name}.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
public class Motherboard : Component
{
    public string Socket { get; set; }
    public string MemoryType { get; set; }

    public Motherboard(string name, string socket, string memory) : base(name, "Motherboard")
    {
        Name = name;
        Socket = socket;
        MemoryType = memory;
    }
}
public class Cpu : Component
{
    public string Socket { get; set; }

    public Cpu(string name = "", string socket="", string type = "Cpu") : base(name, type)
    {
        Name = name;
        Type = type;
        Socket = socket;
        
    }

    protected override void IncompatibleMessage(Motherboard mobo)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine
        ($"Type: {this.Type}. Name {this.Name}" +
         $"\nThe socket {this.Socket} does not match the mobo socket {mobo.Socket}!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
public class Ram : Component
{
    public string MemoryType { get; set; }

    public Ram(string name, string memory) : base(name, "Ram")
    {
        MemoryType = memory;
    }
    // protected override void IncompatibleMessage(Motherboard mobo, Component component)
    // {
    //     Ram ram = component as Ram;
    //     Console.ForegroundColor = ConsoleColor.DarkRed;
    //     Console.WriteLine
    //     ($"Type: {ram.Type}. Name {ram.Name}" +
    //      $"\nThe memory type {ram.MemoryType} does not match the mobo memory type {mobo.MemoryType}!");
    //     Console.ForegroundColor = ConsoleColor.White;
    // }
}