namespace OOPIntro;

public class Component
{
    public string Name { get; set; }
    public string Type { get; set; }

    public Component(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public void MoboCompatability(Motherboard motherboard, Component[] components)
    {
        Console.WriteLine($"You are trying to pair a {motherboard.Name} with the following components:");
        foreach (Component component in components)
        {
            Console.WriteLine($"");
            switch (component)
            {
                case Cpu cpu:
                    if (cpu.Socket != motherboard.Socket) IncompatibleMessage(motherboard, cpu);
                    else CompatibleMessage(motherboard, cpu);
                    break;
                case Ram ram:
                    if (ram.MemoryType != motherboard.MemoryType) IncompatibleMessage(motherboard, ram);
                    else CompatibleMessage(motherboard, ram);
                    break;
            }
        }
    }

    private void IncompatibleMessage(Motherboard mobo, Component component)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine
        ($"Type: {component.Type}. Name {component.Name}" +
         $"\nThe {component.Type} does not match the mobo {mobo.Name}!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private void CompatibleMessage(Motherboard mobo, Component component)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{component.Name} is compatible with {mobo.Name}.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

public class Cpu : Component
{
    public string Socket { get; set; }

    public Cpu(string name, string socket) : base(name, "Cpu")
    {
        Socket = socket;
    }
}

public class Motherboard : Component
{
    public string Socket { get; set; }
    public string MemoryType { get; set; }

    public Motherboard(string name, string socket, string memory) : base(name, "Motherboard")
    {
        MemoryType = memory;
        Socket = socket;
    }
}

public class Ram : Component
{
    public string MemoryType { get; set; }

    public Ram(string name, string memory) : base(name, "Ram")
    {
        MemoryType = memory;
    }
}