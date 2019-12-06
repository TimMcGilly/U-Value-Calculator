using System;
using System.Collections.Generic;
using UValueCalculator;
using UValueCalculator.UValueComponents;
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
            Wall wall = new Wall(10);
            Material wallMaterial = new Material("wallMaterial", conductivity);

            wall.AddLayer(wallMaterial, thickness);

            Assert.Equal(expectedUValue, wall.CalculateUValue());
        }

        [Theory]
        [ClassData(typeof(MultiLayerTestData))]
        public void UValueMultiLayerTest(List<(Material, double)> layers, double expectedUValue)
        {
            Wall wall = new Wall(10);
            foreach ((Material, double) layer in layers)
            {
                wall.AddLayer(layer.Item1, layer.Item2);
            }

            Assert.Equal(expectedUValue, wall.CalculateUValue(), 3);
        }

        [Fact]
        public void WallThrowsArugmentExcetionNegativeSurfaceArea()
        {
            Wall wall;

            Assert.Throws<ArgumentException>(() => wall = new Wall(-5));
        }

        [Fact]
        public void WallMaterialIncompatibleThrowException()
        {
            Wall wall = new Wall(10);
            Material m1 = new Material("m1", 1);
            m1.Compatibility.AddCompatibleComponentType(new Door(10));

            Assert.Throws<ArgumentException>(() => wall.AddLayer(m1, 10));
        }

        [Fact]
        public void NoLayersThrowsExceptionTest()
        {
            Wall wall = new Wall(10);

            Assert.Throws<ArgumentException>(() => wall.CalculateUValue());
        }
    }
}