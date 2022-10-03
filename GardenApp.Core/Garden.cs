using System;
using System.Collections.Generic;

namespace GardenApp.Core;

public class Garden
{
    public Person Owner { get; }
    
    public double SurfaceArea { get; set; }

    private ICollection<GardenBed> gardenBeds;

    public Garden(Person owner)
    {
        if (owner == null)
        {
            throw new ArgumentException("A garden must have an owner!");
        }
        
        Owner = owner;
        gardenBeds = new List<GardenBed>();
    }

    public void AddGardenBed(GardenBed gardenBed)
    {
        gardenBeds.Add(gardenBed);
    }

    public void ClearGarden()
    {
        gardenBeds.Clear();
    }

    public override string ToString()
    {
        var output = String.Empty;

        output += $"my garden info: (surface: {SurfaceArea} m2)\n";
        output += "--------------------------------------------\n";
        foreach (var gardenBed in gardenBeds)
        {
            output += $"\t{gardenBed}\n";
        }

        return output;
    }
}