using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class Boat : Vehicle
    {
        private double waterLineLength;

        public Boat(string licenceNumber, string color, int numberOfWheels, double waterLineLength) : base(licenceNumber, color, numberOfWheels) => WaterLineLength = waterLineLength;

        public double WaterLineLength { get => waterLineLength; set => waterLineLength = value; }

        public override string ToString()
        {
            return $"{base.ToString()}, Mater Line Length: {WaterLineLength}";
        }
    }
}
