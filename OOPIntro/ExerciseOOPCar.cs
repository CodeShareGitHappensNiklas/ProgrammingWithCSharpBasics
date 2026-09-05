namespace OOPIntro;

// Exercise OOP - Car
public class Car
{
    //Create field/properties, i.e. maxSpeed, currentSpeed
    public string Model = "BMW";
    public int Mileage = 0;
    public int CurrentSpeedKmh = 0;
    public int TopSpeedKmh = 250;
    
    // Create methods, i.e. GoFaster() and GoSlower()
    public void GoFaster()
    {
        if(CurrentSpeedKmh == 0) Console.WriteLine($"{this.Model} is starting!");
        if (CurrentSpeedKmh < TopSpeedKmh)
        {
            CurrentSpeedKmh++;
        }
        if(CurrentSpeedKmh == TopSpeedKmh) Console.WriteLine($"{this.Model} top speed hit!");
        
    }
    public void GoSlower()
    {
        if (CurrentSpeedKmh > 0)
        {
            CurrentSpeedKmh--;
        }
        if(CurrentSpeedKmh == 0) Console.WriteLine($"{this.Model} is stopping!");
    }
    public void DefineCar(string model, int topSpeed)
    {
        this.Model = model;
        this.TopSpeedKmh = topSpeed;
    }
}