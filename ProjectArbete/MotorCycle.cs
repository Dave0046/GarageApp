using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApplication
{
    public class MotorCycle: Vehicle
    {
        public bool Passenger { get; set; }
        public int Weight { get; set; }
        public bool Chopper { get; set; }

        public MotorCycle(string RegNumber, string Color, string Brand, string Type, int NumberOfTires, int Weight, bool Chopper) :
                base(RegNumber, Color, Brand, Type, NumberOfTires)
        {
            this.Weight = Weight;
            this.Chopper = Chopper;
        }
    }
}