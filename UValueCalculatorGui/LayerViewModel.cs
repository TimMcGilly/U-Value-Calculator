using UValueCalculator;

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

        public LayerViewModel(Layer layer, LayeredComponentViewModel parent)
        {
            Layer = layer;
            Parent = parent;
        }
    }
}