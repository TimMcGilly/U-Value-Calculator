namespace UValueCalculator
{
    public class Layer
    {
        public Material Material { get; set; }

        public double Thickness { get; set; }

        public Layer(Material material, double thickness)
        {
            this.Material = material;
            this.Thickness = thickness;
        }

        public double GetRValue()
        {
            return Thickness / Material.Conductivity;
        }
    }
}