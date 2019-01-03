using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class Bus : Vehicle
    {
        private double wheelBaseWidth;

        public Bus(string licenceNumber, string color, int numberOfWheels, double wheelBaseWidth) : base(licenceNumber, color, numberOfWheels) => WheelBaseWidth = wheelBaseWidth;

        public double WheelBaseWidth { get => wheelBaseWidth; set => wheelBaseWidth = value; }

        public override string ToString()
        {
            return $"{base.ToString()}, Wheel Base Width: {WheelBaseWidth}";
        }
    }
}
