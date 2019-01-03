using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class Airplane : Vehicle
    {
        private double wingSpan;

        public Airplane(string licenceNumber, string color, int numberOfWheels, double wingSpan) : base(licenceNumber, color, numberOfWheels) => WingSpan = wingSpan;

        public double WingSpan { get => wingSpan; set => wingSpan = value; }

        public override string ToString()
        {
            return $"{base.ToString()}, Wing Span: {WingSpan}";
        }
    }
}
