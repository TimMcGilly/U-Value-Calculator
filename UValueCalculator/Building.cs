using System;
using System.Collections.Generic;

namespace UValueCalculator
{
    public class Building : IUValue
    {
        public string Name { get; set; }
        public List<IUValueComponent> Components { get => components; }

        private readonly List<IUValueComponent> components = new List<IUValueComponent>();

        public bool IsValid
        {
            get
            {
                return components.Count > 1;
            }
        }

        public Building()
        {
        }

        public Building(string name, List<IUValueComponent> components)
        {
            Name = name;
            this.components = components;
        }

        public Building(List<IUValueComponent> components) : this("Untitled Building", components)
        {
        }

        public void AddComponent(IUValueComponent component)
        {
            components.Add(component);
        }

        public void RemoveComponent(IUValueComponent component)
        {
            components.Remove(component);
        }

        public double CalculateUValue()
        {
            if (!IsValid) throw new ArgumentException("Building need 1 or more components.");
            double totalCombined = 0;
            double totalSurfaceArea = 0;

            foreach (IUValueComponent component in Components)
            {
                totalCombined += component.CalculateUValue() * component.SurfaceArea;
                totalSurfaceArea += component.SurfaceArea;
            }

            return totalCombined / totalSurfaceArea;
        }
    }
}