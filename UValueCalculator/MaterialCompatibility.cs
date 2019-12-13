using System;
using System.Collections.Generic;
using System.Linq;

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

        public MaterialCompatibility(params Type[] componentsType)
        {
            foreach (Type type in componentsType)
            {
                compatibleComponents.Add(type);
            } 
        }

        public bool CheckCompatibility(IUValueComponent uValueComponent)
        {
            if (Unrestricted) return true;
            return compatibleComponents.Contains(uValueComponent.GetType());
        }

        public bool CheckCompatibility(Type type)
        {

                return compatibleComponents.Contains(type);
             
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