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
        public List<Material> GetMaterials()
        {
            List<Material> materials = new List<Material>();
            materials.Add(new Material("Brick", 0.6));
            materials.Add(new Material("Plaster Sand", 0.71));
            return materials;
        }
    }
}
