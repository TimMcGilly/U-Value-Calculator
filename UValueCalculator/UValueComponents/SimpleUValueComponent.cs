using System;
using System.Collections.Generic;
using System.Linq;

namespace UValueCalculator
{
    public abstract class SimpleUValueComponent : IUValueLayeredComponent
    {
        public string Name { get; set; }

        public List<Layer> Layers { get; set; } = new List<Layer>();

        private double surfaceArea;

        public double SurfaceArea
        {
            get => surfaceArea;
            set
            {
                if (value < 0) throw new ArgumentException("Surface area cannot be negative");
                surfaceArea = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return Layers.Count > 0;
            }
        }

        public void AddLayer(Material material, double thickness)
        {
            Layers.Add(new Layer(material, thickness, this));
        }

        public void RemoveLayer(Layer layer)
        {
            Layers.Remove(layer);
        }

        public double CalculateUValue()
        {
            if (!IsValid) throw new ArgumentException("Component must have layers.");
            return 1 / Layers.Sum(layer => layer.GetRValue());
        }
    }
}