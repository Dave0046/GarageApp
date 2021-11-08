using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApplication
{
    public class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public int NumbearOfTires { get; set; }
        public Bus(string RegNumber, string Color, string Brand, string Type, int NumberOfTires, int numberOfSeats, bool combi) :
        base(RegNumber, Color, Brand, Type, NumberOfTires)
            {
                NumberOfSeats = numberOfSeats;
                NumbearOfTires = NumbearOfTires;
            }
    }
}