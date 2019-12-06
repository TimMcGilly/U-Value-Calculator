using UValueCalculator;
using UValueCalculator.UValueComponents;
using Xunit;

namespace TestUValueCalculator
{
    public class BuildingTests
    {
        private readonly Material brick = new Material("Brick", 0.6);
        private readonly Material glass = new Material("Glass", 0.91);
        private readonly Material aluminium = new Material("Aluminium", 0.61);

        [Fact]
        public void SimpleTwoWallComponetsTest()
        {
            Building building = new Building();
            Wall wall1 = new Wall(10);
            wall1.AddLayer(brick, 5);

            Wall wall2 = new Wall(10);
            wall2.AddLayer(brick, 5);

            building.AddComponent(wall1);
            building.AddComponent(wall2);

            Assert.Equal(0.12, building.CalculateUValue());
        }

        [Fact]
        public void WallAndWindowTest()
        {

            Building building = new Building();
            Wall wall1 = new Wall(10);
            wall1.AddLayer(brick, 5);

            Panel panel = new Panel(10, 10);
            panel.AddLayer(glass, 5);

            Frame frame = new Frame(15, 15, 5);
            frame.AddLayer(aluminium, 5);

            WindowSeal seal = new WindowSeal(panel, 3);

            Window window = new Window(panel, frame, seal);

            building.AddComponent(wall1);
            building.AddComponent(window);

            Assert.Equal(0.658, building.CalculateUValue(),3);
        }
    }
}