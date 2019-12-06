using System;
using UValueCalculator;
using UValueCalculator.UValueComponents;

namespace UValueCalculatorConsole
{
    internal static class Program
    {
        private static void Main()
        {
            Material brick = new Material("Brick", 0.6);
            Building building = new Building();
            Wall wall1 = new Wall(10);
            wall1.AddLayer(brick, 5);

            Wall wall2 = new Wall(10);
            wall2.AddLayer(brick, 5);

            building.AddComponent(wall1);
            building.AddComponent(wall2);
            Console.WriteLine(building.CalculateUValue());
        }
    }
}