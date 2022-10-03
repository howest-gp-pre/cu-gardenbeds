using System;

namespace GardenApp.Core;

public abstract class Sensor : ISensor
{
    private readonly string _name;
    private string serialNr;

    public Sensor(string name, string serialNr)
    {
        _name = name;
        this.serialNr = serialNr;
    }

    public void SetSerialNr(string serialNr)
    {
        this.serialNr = serialNr;
    }

    public abstract double GetMeasurement();

    public override string ToString()
    {
        var output = String.Empty;
        output += $"Sensor: ({serialNr})";
        return output;
    }
}