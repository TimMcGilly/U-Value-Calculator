using System.Collections;
using System.Collections.Generic;
using UValueCalculator;

namespace TestUValueCalculator
{
    public class MultiLayerTestData : IEnumerable<object[]>
    {
        private readonly Material brick = new Material("Brick", 0.6);
        private readonly Material plaster = new Material("Plaster Sand", 0.71);

        public IEnumerator<object[]> GetEnumerator()
        {
            List<(Material,double)> layers = new List<(Material,double)>() { (brick, 5), (brick, 5) };
            yield return new object[] { layers, 0.06 };

            layers = new List<(Material, double)>() { (brick, 5), (plaster, 5) };
            yield return new object[] { layers, 0.065 };

            layers = new List<(Material, double)>() { (plaster, 5), (brick, 5) };
            yield return new object[] { layers, 0.065 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}