using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenApp.Core
{
    public class Garden
    {
        public double Surface { get; set; }

        private List<GardenBed> gardenBeds;

        public List<GardenBed> GardenBeds
        {
            get
            {
                return new List<GardenBed>(gardenBeds);
            }
        }

        public Garden()
        {
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
            string output = String.Empty;

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