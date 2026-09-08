using System.Runtime.CompilerServices;

namespace Main;

using OOPIntro;

class Program
{
    static void Main(string[] args)
    {
        #region Component init
        Motherboard mobo = new Motherboard(
            "ASUS ROG Strix B650-A Gaming WiFi",
            "AM5",
            "DDR5");
        Motherboard moboTwo = new Motherboard(
            "ASUS Z97-A",
            "LGA1150",
            "DDR3");
        Cpu cpu = new Cpu(
            "Intel i5-4690K",
            "LGA1150");
        Ram ram = new Ram(
            "Corsair Vengeance DDR3",
            "DDR3");
        Ram ramTwo = new Ram(
            "CORSAIR Vengeance DDR5 32GB",
            "DDR5");
        #endregion
        Component[] components = [cpu,ram, ramTwo];
        
        mobo.MoboCompatability(moboTwo,components);
    }
}