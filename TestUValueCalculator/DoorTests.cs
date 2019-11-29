using System.Collections.Generic;
using UValueCalculator;
using UValueCalculator.UValueComponents;
using Xunit;

namespace TestUValueCalculator
{
    public class DoorTests
    {
        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(10, 5, 2)]
        [InlineData(5, 10, 0.5)]
        public void UValueSingleLayerTest(double conductivity, double thickness, double expectedUValue)
        {
            Door door = new Door();
            Material doorMaterial = new Material("doorMaterial", conductivity);

            door.AddLayer(doorMaterial, thickness);

            Assert.Equal(expectedUValue, door.CalculateUValue());
        }

        [Theory]
        [ClassData(typeof(MultiLayerTestData))]
        public void UValueMultiLayerTest(List<(Material,double)> layers, double expectedUValue)
        {
            Door door = new Door();
            foreach ((Material,double) layer in layers)
            {
                door.AddLayer(layer.Item1, layer.Item2);
            }

            Assert.Equal(expectedUValue, door.CalculateUValue(), 3);
        }
    }
}