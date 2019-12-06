using UValueCalculator;

namespace UValueCalculatorGui
{
    public class LayerViewModel : ViewModelBase
    {
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

        public LayerViewModel(Layer layer)
        {
            Layer = layer;
        }
    }
}