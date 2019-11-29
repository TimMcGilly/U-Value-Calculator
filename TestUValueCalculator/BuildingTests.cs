using UValueCalculator;
using Xunit;

namespace TestUValueCalculator
{
    public class BuildingTests
    {
        private readonly Material brick = new Material("Brick", 0.6);

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
    }
}