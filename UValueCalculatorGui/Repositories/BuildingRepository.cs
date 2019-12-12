using UValueCalculator;
using UValueCalculator.UValueComponents;

namespace UValueCalculatorGui.Repositories
{
    public class BuildingRepository
    {
        public Building GetBuildingFromXMLFile(string path)
        {
            Material brick = new Material("Brick", 0.6);
            Material glass = new Material("Glass", 0.91);
            Material aluminium = new Material("Aluminium", 0.61);
            //TODO Implement XML Storage

            Building building = new Building();
            Wall wall1 = new Wall(10);
            wall1.AddLayer(brick, 5);
            wall1.AddLayer(brick, 5);
            wall1.AddLayer(brick, 5);

            Door door1 = new Door(10);
            door1.AddLayer(brick, 5);
            door1.AddLayer(glass, 5);

            Panel panel = new Panel(10, 10);
            panel.AddLayer(glass, 5);

            Frame frame = new Frame(15, 15, 5);
            frame.AddLayer(aluminium, 5);

            WindowSeal seal = new WindowSeal(panel, 3);

            Window window = new Window(panel, frame, seal);

            building.AddComponent(wall1);
            building.AddComponent(window);
            building.AddComponent(door1);
            building.AddComponent(door1);

            return building;
        }
    }
}