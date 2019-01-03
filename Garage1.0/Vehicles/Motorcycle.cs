using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class Motorcycle : Vehicle
    {

        private double numberOfCylinders;


        public Motorcycle(string licenceNumber, string color, int numberOfWheels, double numberOfCylinders) : base(licenceNumber, color, numberOfWheels) => NumberOfCylinders = numberOfCylinders;

        public double NumberOfCylinders { get => numberOfCylinders; set => numberOfCylinders = value; }


        public override string ToString()
        {
        return $"{base.ToString()}, Number Of Doors: {NumberOfCylinders}";
        }
    }
}
