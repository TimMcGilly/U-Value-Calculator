using System;
using System.Collections.Generic;

namespace UValueCalculator
{
    public class MaterialCompatibility
    {
        private readonly HashSet<Type> compatibleComponents = new HashSet<Type>();

        public bool Unrestricted
        {
            get
            {
                return compatibleComponents.Count == 0;
            }
        }

        public MaterialCompatibility()
        {
        }

        public MaterialCompatibility(params IUValueComponent[] components)
        {
            foreach (IUValueComponent component in components)
            {
                compatibleComponents.Add(component.GetType());
            }
        }

        public bool CheckCompatibility(IUValueComponent uValueComponent)
        {
            if (Unrestricted) return true;
            return compatibleComponents.Contains(uValueComponent.GetType());
        }

        public void AddCompatibleComponentType(IUValueComponent component)
        {
            compatibleComponents.Add(component.GetType());
        }

        public void RemoveCompatibleComponentType(IUValueComponent component)
        {
            compatibleComponents.Add(component.GetType());
        }
    }
}