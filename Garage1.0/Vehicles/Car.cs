using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class Car : Vehicle
    {
        private int numberOfDoors;

        public Car(string licenceNumber, string color, int numberOfWheels, int numberOfDoors) : base(licenceNumber, color, numberOfWheels) => NumberOfDoors = numberOfDoors;
        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }

        public override string ToString()
        {
            return $"{base.ToString()}, Number Of Doors: {NumberOfDoors}";
        }
    }
}
