using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UValueCalculator;
using UValueCalculator.UValueComponents;

namespace UValueCalculatorGui.Repositories
{
    public class MaterialRepository
    {
        private readonly List<Material> materials = new List<Material>()
        {
            new Material("Brick", 0.6),
            new Material("Plaster Sand", 0.71),
            new Material("Aluminium", 0.61),
            new Material("Glass", 0.91, new MaterialCompatibility(typeof(Panel)))

        };

        public List<Material> GetAllMaterials()
        {
            return materials;
        }

        public List<Material> GetCompatibleMaterials(IUValueComponent uValueComponent)
        {
            List<Material> compatibleMaterials = new List<Material>();
            foreach (Material material in materials)
            {
                if (material.CheckCompatibility(uValueComponent))
                {
                    compatibleMaterials.Add(material);
                }
            }
            return compatibleMaterials;
        }

        public Material GetMaterialByName(string name)
        {
            foreach (Material material in materials)
            {
                if (material.Name == name) return material;
            }
            return null;
        }
    }
}
