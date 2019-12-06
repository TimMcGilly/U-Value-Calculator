using System.Collections.Generic;
using UValueCalculator;

namespace UValueCalculatorGui
{
    public class LayeredComponentViewModel : ViewModelBase
    {
        public IUValueLayeredComponent Component { get; set; }

        public LayeredComponentViewModel(IUValueLayeredComponent component)
        {
            Component = component;
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