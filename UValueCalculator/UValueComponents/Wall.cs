namespace UValueCalculator.UValueComponents
{
    public class Wall : SimpleUValueComponent
    {
        public Wall(string name, double surfaceArea)
        {
            Name = name;
            SurfaceArea = surfaceArea;
        }

        public Wall(double surfaceArea) : this("Untitled Wall", surfaceArea)
        {
        }
    }
}