namespace UValueCalculator
{
    public class Material
    {
        public string Name { get; }
        public double Conductivity { get; }

        public MaterialCompatibility Compatibility { get; }

        public Material(string name, double conductivity, MaterialCompatibility type)
        {
            Name = name;
            Conductivity = conductivity;
            Compatibility = type;
        }

        public Material(string name, double conductivity)
        {
            Name = name;
            Conductivity = conductivity;
            Compatibility = new MaterialCompatibility();
        }

        public bool CheckCompatibility(IUValueComponent uValueComponent)
        {
            return Compatibility.CheckCompatibility(uValueComponent);
        }
    }
}