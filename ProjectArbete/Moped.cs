using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApplication
{
    public class Moped : Vehicle
    {
        public int Weight { get; set; }
        public string Seats { get; set; }


        public Moped(string RegNumber, string Color, string Brand, string Type, int NumberOfTires, int Weight, string Seats) :
                base(RegNumber, Color, Brand, Type, NumberOfTires)
        {
            this.Weight = Weight;
            this.Seats = Seats;
        }
    }
}