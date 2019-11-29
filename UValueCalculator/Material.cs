namespace UValueCalculator
{
    public class Material
    {
        public string Name { get; }
        public double Conductivity { get; }

        public MaterialCompatibility Type { get; }

        public Material(string name, double conductivity, MaterialCompatibility type)
        {
            Name = name;
            Conductivity = conductivity;
            Type = type;
        }

        public Material(string name, double conductivity)
        {
            Name = name;
            Conductivity = conductivity;
            Type = new MaterialCompatibility();
        }

        public bool CheckCompatibility(IUValueComponent uValueComponent)
        {
            return Type.CheckCompatibility(uValueComponent);
        }
    }
}