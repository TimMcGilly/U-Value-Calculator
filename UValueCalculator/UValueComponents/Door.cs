namespace UValueCalculator.UValueComponents
{
    public class Door : SimpleUValueComponent
    {

        public Door(string name, double surfaceArea)
        {
            Name = name;
            SurfaceArea = surfaceArea;
        }

        public Door(double surfaceArea) : this("Untitled Door", surfaceArea) { }
    }
}
