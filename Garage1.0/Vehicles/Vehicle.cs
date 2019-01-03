using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    [Serializable]
    class Vehicle
    {
        private string licenceNumber;
        private string color;
        private int numberOfWheels;
        protected Vehicle(string licenceNumber, string color, int numberOfWheels){LicenceNumber = licenceNumber;Color = color;NumberOfWheels = numberOfWheels;}
        public string LicenceNumber { get => licenceNumber; set => licenceNumber = value; }
        public string Color { get => color; set => color = value; }
        public int NumberOfWheels { get => numberOfWheels; set => numberOfWheels = value; }
    }
}
