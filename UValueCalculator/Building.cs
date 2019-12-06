using System;
using System.Collections.Generic;

namespace UValueCalculator
{
    public class Building : IUValue
    {
        public string Name { get; set; }
        public List<IUValueComponent> Components { get; } = new List<IUValueComponent>();

        public bool IsValid
        {
            get
            {
                return Components.Count > 1;
            }
        }

        public Building()
        {
        }

        public Building(string name, List<IUValueComponent> components)
        {
            Name = name;
            this.Components = components;
        }

        public Building(List<IUValueComponent> components) : this("Untitled Building", components)
        {
        }

        public void AddComponent(IUValueComponent component)
        {
            Components.Add(component);
        }

        public void RemoveComponent(IUValueComponent component)
        {
            Components.Remove(component);
        }

        public double CalculateUValue()
        {
            if (!IsValid) throw new ArgumentException("Building need 1 or more components.");
            double totalCombined = 0;
            double totalSurfaceArea = 0;

            foreach (IUValueComponent component in Components)
            {
                double temp = component.CalculateUValue();
                totalCombined += component.CalculateUValue() * component.SurfaceArea;
                totalSurfaceArea += component.SurfaceArea;
            }

            return totalCombined / totalSurfaceArea;
        }
    }
}