using System;

namespace UValueCalculator
{
    public class Layer
    {
        public Material Material { get; set; }
        public string Name { get; set; }

        public double Thickness { get; set; }

        public Layer(Material material, double thickness, IUValueComponent parentComponent) : this("Untitled Layer", material, thickness, parentComponent)
        {
        }

        public Layer(string name, Material material, double thickness, IUValueComponent parentComponent)
        {
            Name = name;
            if (!material.CheckCompatibility(parentComponent)) throw new ArgumentException("Incompatible material added to layer of component");
            this.Material = material;
            this.Thickness = thickness;
        }

        public double GetRValue()
        {
            return Thickness / Material.Conductivity;
        }
    }
}