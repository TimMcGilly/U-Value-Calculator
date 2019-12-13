using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UValueCalculator;

namespace UValueCalculatorGui.Repositories
{
    public class MaterialRepository
    {
        private List<Material> materials = new List<Material>()
        {
            new Material("Brick", 0.6),
            new Material("Plaster Sand", 0.71),
            new Material("Aluminium", 0.61)

        };

        public List<Material> GetMaterials()
        {
            List<Material> materials = new List<Material>();
            materials.Add(new Material("Brick", 0.6));
            materials.Add(new Material("Plaster Sand", 0.71));
            return materials;
        }
    }
}
