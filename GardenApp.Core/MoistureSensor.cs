namespace GardenApp.Core;

public class MoistureSensor: Sensor
{
    public MoistureSensor(string name, string serialNr) : base(name, serialNr)
    {
    }

    public override double GetMeasurement()
    {
        return Faker.RandomNumber.Next(0, 100);
    }
    
    public override string ToString()
    {
        return $"Moisture {base.ToString()}";
    }
}