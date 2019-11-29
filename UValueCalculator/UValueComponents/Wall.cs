using System;

namespace UValueCalculator
{
    public class Wall : SimpleUValueComponent
    {
        public string Name { get; set; }

        public Wall(string name, double surfaceArea)
        {
            Name = name;
            SurfaceArea = surfaceArea;
        }

        public Wall(double surfaceArea) : this("Untitled Wall", surfaceArea) { }

    }
}