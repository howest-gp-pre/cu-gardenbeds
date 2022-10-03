using System;

namespace GardenApp.Core;

public class GardenBed
{
    private Guid id;

    public GardenBed(Guid id)
    {
        this.id = id;
    }

    public override string ToString()
    {
        var output = String.Empty;

        output += $"Gardenbed #{id}\n";

        /* TODO print connected sensor inf*/       

        return output;
    }
}