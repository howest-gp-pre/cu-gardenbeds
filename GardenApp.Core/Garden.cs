using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenApp.Core
{
    public class Garden
    {
        public Person Owner { get; }
        public double Surface { get; set; }

        private List<GardenBed> gardenBeds;

        public Garden(Person owner)
        {
            Owner = owner;
            gardenBeds = new List<GardenBed>();
        }

        public void AddGardenBed(GardenBed newBed)
        {
            if (gardenBeds.Count < 6)
            {
                gardenBeds.Add(newBed);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void CleanGaren()
        {
            gardenBeds = new List<GardenBed>();
        }

        public override string ToString()
        {
            var output = String.Empty;

            output += $"my garden info: (surface: {Surface} m2)\n";
            output += "--------------------------------------------\n";
            foreach (var gardenBed in gardenBeds)
            {
                output += $"\t{gardenBed}\n";
            }
            /*
             * My Garden info: (surface: 100)
             *--------------------------------------------
             *     Gardenbed #1
             *         Temperature Sensor: (...serienr...)
             *     Gardenbed #2
             *     Gardenbed #3
             *     Gardenbed #4
             *     Gardenbed #5
             * ...
             */
            
            
            return output;
        }
    }
}