using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApplication
{
    public class Truck : Vehicle
    {
        public string TruckBed { get; set; }
        public int Weight { get; set; }

        public Truck(string RegNumber, string Color, string Brand, string Type, int NumberOfTires, string TruckBed, int Weight) :
                base(RegNumber, Color, Brand, Type, NumberOfTires)
        {
            this.TruckBed = TruckBed;
            this.Weight = Weight;
            
        }
    }
}