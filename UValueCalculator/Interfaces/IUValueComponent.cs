using System.Collections.Generic;

namespace UValueCalculator
{
    public interface IUValueComponent : IUValue
    {
        string Name { get; set; }
        double SurfaceArea { get; }
    }

    public interface IUValueLayeredComponent : IUValueComponent
    {
        List<Layer> Layers { get; set; }

        void AddLayer(Material material, double thickness);

        void RemoveLayer(Layer layer);
    }
}