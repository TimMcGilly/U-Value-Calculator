namespace UValueCalculator.UValueComponents
{
    public class Door : SimpleUValueComponent
    {
        public string Name { get; set; }

        public Door(string name, double surfaceArea)
        {
            Name = name;
            SurfaceArea = surfaceArea;
        }

        public Door(double surfaceArea) : this("Untitled Door", surfaceArea) { }
    }
}
