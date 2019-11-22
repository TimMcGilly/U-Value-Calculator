using System;
using System.Collections.Generic;

namespace UValueCalculator
{
    public class Component : IUValue
    {
        private List<Layer> layers = new List<Layer>();
        private double surfaceArea;
        public double CalculateUValue()
        {
            throw new NotImplementedException();
        }
    }
}
