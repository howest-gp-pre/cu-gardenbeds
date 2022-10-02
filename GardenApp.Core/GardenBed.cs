using System;
using System.Collections.Generic;

namespace GardenApp.Core
{
    public class GardenBed
    {
        public int Id { get; private set; }

        private List<Sensor> sensors;
        
        public List<Sensor> Sensors => sensors;

        public GardenBed(int id)
        {
            Id = id;
            sensors = new List<Sensor>();
        }

        public void AddSensor(Sensor sensor)
        {
            if (sensors.Count < 3)
            {
                sensors.Add(sensor);
            }
        }

        public override string ToString()
        {
            var output = String.Empty;

            output += $"Gardenbed #{Id}\n";

            foreach (var sensor in sensors)
            {
                output += $"\t\t{sensor}";
            }
            
            return output;
        }
    }
}