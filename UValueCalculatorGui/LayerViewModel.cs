using System.Collections.Generic;
using System.Collections.ObjectModel;
using UValueCalculator;
using UValueCalculatorGui.Repositories;

namespace UValueCalculatorGui
{
    public class LayerViewModel : TreeViewItem
    {
        public LayeredComponentViewModel Parent { get; set; }

        public Layer Layer { get; protected set; }

        public string Name
        {
            get { return Layer.Name; }
            set
            {
                Layer.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public double Thickness
        {
            get { return Layer.Thickness; }
            set
            {
                Layer.Thickness = value;
                OnPropertyChanged("Thickness");
            }
        }

        public LayerViewModel(Layer layer, LayeredComponentViewModel parent)
        {
            Layer = layer;
            Parent = parent;
        }

        public ObservableCollection<Material> Materials
        {
            get
            {
                MaterialRepository materialRepository = new MaterialRepository();
                return new ObservableCollection<Material>(materialRepository.GetMaterials());
            }
        }

        public Material Material
        {
            get
            {
                return Layer.Material;
            }
            set
            {
                Layer.Material = value;
                OnPropertyChanged("Material");
            }
        }


        public override bool IsSelected
        {
            get
            {
                return base._isSelected;
            }
            set
            {
                base._isSelected = value;
                Parent.OnPropertyChanged("SelectedObject");
            }
        }
    }
}