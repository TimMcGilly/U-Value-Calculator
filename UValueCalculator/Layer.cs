using System;

namespace UValueCalculator
{
    public class Layer
    {
        public Material Material { get; set; }

        public double Thickness { get; set; }

        public Layer(Material material, double thickness, IUValueComponent parentComponent)
        {
            if (material.CheckCompatibility(parentComponent) == false) throw new ArgumentException("Incompatible material added to layer of component");
            this.Material = material;
            this.Thickness = thickness;
        }

        public double GetRValue()
        {
            return Thickness / Material.Conductivity;
        }
    }
}