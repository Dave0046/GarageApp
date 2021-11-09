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

        public Truck(string regNumber, string Color, string Brand, string Type, int NumberOfTires, int NumberOfPassengers, string TruckBed, int Weight) :
                base(regNumber, Color, Brand, Type, NumberOfTires, NumberOfPassengers)
        {
            this.TruckBed = TruckBed;
            this.Weight = Weight;
            
        }
    }
}