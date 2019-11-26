using UValueCalculator;
using Xunit;

namespace TestUValueCalculator
{
    public class WallTests
    {
        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(10, 5, 2)]
        [InlineData(5, 10, 0.5)]
        public void UValueSingleLayerTest(double conductivity, double thickness, double expectedUValue)
        {
            Wall wall = new Wall();
            Material wallMaterial = new Material("wallMaterial", conductivity);

            wall.AddLayer(wallMaterial, thickness);

            Assert.Equal(expectedUValue, wall.CalculateUValue());
        }

        
    }
}