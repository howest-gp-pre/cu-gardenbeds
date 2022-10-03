using System;
using System.Collections.Generic;

namespace GardenApp.Core;

public class GardenBed
{
    private Guid id;
    private readonly List<Sensor> sensors;

    public GardenBed(Guid id, Sensor sensor)
    {
        this.id = id;
        sensors = new List<Sensor>();
        sensors.Add(sensor);
    }

    public void AddSensor(Sensor sensor)
    {
        sensors.Add(sensor);
    }

    public override string ToString()
    {
        var output = String.Empty;

        output += $"Gardenbed #{id}\n";

        foreach (var sensor in sensors)
        {
            output += $"\t\t{sensor}";
        }

        return output;
    }
}