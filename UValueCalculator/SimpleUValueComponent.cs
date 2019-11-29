using System.Collections.Generic;
using System.Linq;

namespace UValueCalculator
{
    public abstract class SimpleUValueComponent : IUValueComponent
    {
        public List<Layer> Layers { get; set; } = new List<Layer>();
        public double SurfaceArea { get; set; }

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
            return 1 / Layers.Sum(layer => layer.GetRValue());
        }
    }
}