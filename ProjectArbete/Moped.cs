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


        public Moped(string regNumber, string Color, string Brand, string Type, int NumberOfTires, int NumberOfPassengers, int Weight, string Seats) :
                base(regNumber, Color, Brand, Type, NumberOfTires, NumberOfPassengers)
        {
            this.Weight = Weight;
            this.Seats = Seats;
        }
    }
}