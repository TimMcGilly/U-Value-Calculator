using System.Collections.Generic;
using UValueCalculator;

namespace UValueCalculatorGui
{
    public class LayeredComponentViewModel : TreeViewItem
    {
        public IUValueLayeredComponent Component { get; set; }

        public LayeredComponentViewModel(IUValueLayeredComponent component)
        {
            Component = component;
            
        }

        public LayeredComponentViewModel(IUValueLayeredComponent component, string name)
        {
            Component = component;
            this.name = name;
        }

        private string name = "";

        public string Name
        {
            get
            {

                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }
                else
                {
                    return Component.Name.ToString();
                }
            }
        }

        public List<LayerViewModel> Layers
        {
            get
            {
                List<LayerViewModel> viewModels = new List<LayerViewModel>();
                foreach (Layer layer in Component.Layers)
                {
                    viewModels.Add(new LayerViewModel(layer));
                }

                return viewModels;
            }
            set
            {
                List<Layer> layers = new List<Layer>();
                foreach (LayerViewModel layer in value)
                {
                    layers.Add(layer.Layer);
                }
                Component.Layers = layers;
                OnPropertyChanged("Layers");
            }
        }
    }
}