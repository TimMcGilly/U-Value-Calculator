using UValueCalculator.UValueComponents;

namespace UValueCalculatorGui
{
    public class WindowViewModel : ViewModelBase
    {
        public Window Component { get; set; }

        public WindowViewModel(Window component)
        {
            Component = component;
        }

        public LayeredComponentViewModel Frame
        {
            get { return new LayeredComponentViewModel(Component.Frame); } 
            set
            {
                Component.Frame = (Frame)value.Component;
                OnPropertyChanged("Frame");
            }
        }

        public LayeredComponentViewModel Panel
        {
            get { return new LayeredComponentViewModel(Component.Frame); }
            set
            {
                Component.Panel = (Panel)value.Component;
                OnPropertyChanged("Panel");
            }
        }

        public WindowSeal Seal
        {
            get { return (Component.Seal); }
            set
            {
                Component.Seal = value;
                OnPropertyChanged("Panel");
            }
        }
    }
}