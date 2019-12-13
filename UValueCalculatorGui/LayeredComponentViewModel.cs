using System.Collections.Generic;
using System.Collections.ObjectModel;
using UValueCalculator;
using UValueCalculatorGui.Repositories;

namespace UValueCalculatorGui
{
    public class LayeredComponentViewModel : TreeViewItem
    {
        public IUValueLayeredComponent Component { get; set; }

        private List<LayerViewModel> layerViewModels;

        public LayeredComponentViewModel(IUValueLayeredComponent component)
        {
            Component = component;
            PopulateLayerViewModels();
        }

        public LayeredComponentViewModel(IUValueLayeredComponent component, string name)
        {
            Component = component;
            this.name = name;
            PopulateLayerViewModels();
        }

        private string name = null;

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
                    return Component.Name;
                }
            }
            set
            {
                if (name != null)
                {
                    name = value;
                }
                else
                {
                    Component.Name = name;
                }
                OnPropertyChanged("Name");
            }
        }

        public List<LayerViewModel> Layers
        {
            get
            {
                return layerViewModels;
            }
            set
            {
                layerViewModels = value;
                OnPropertyChanged("Layers");
            }
        }

        public ObservableCollection<LayerViewModel> SelectedLayer
        {
            get
            {
                if (this.IsSelected) return default(ObservableCollection<LayerViewModel>);
                foreach (LayerViewModel layer in Layers)
                {
                    if (layer.IsSelected) return new ObservableCollection<LayerViewModel>() { layer };
                }
                return default(ObservableCollection<LayerViewModel>);
            }
        }

        public object SelectedObject
        {
            get
            {
                if (this.IsSelected) return this;
                foreach (LayerViewModel layer in Layers)
                {
                    if (layer.IsSelected) return layer;
                }
                return null;
            }
        }

        public void PopulateLayerViewModels()
        {
            List<LayerViewModel> viewModels = new List<LayerViewModel>();
            foreach (Layer layer in Component.Layers)
            {
                viewModels.Add(new LayerViewModel(layer, this));
            }
            Layers = viewModels;
        }

        
    }
}