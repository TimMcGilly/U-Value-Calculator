namespace UValueCalculator
{
    public class Material
    {
        public string Name { get; }
        public double Conductivity { get; }

        public Material(string name, double conductivity)
        {
            Name = name;
            Conductivity = conductivity;
        }
    }
}