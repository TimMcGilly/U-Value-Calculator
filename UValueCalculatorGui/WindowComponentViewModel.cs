using System.Collections.Generic;
using UValueCalculator.UValueComponents;

namespace UValueCalculatorGui
{
    public class WindowComponentViewModel : TreeViewItem
    {
        public Window Component { get; set; }

        public WindowComponentViewModel(Window component)
        {
            Component = component;
        }

        public string Name
        {
            get
            {
                return Component.Name;
            }
        }

        public LayeredComponentViewModel Frame
        {
            get { return new LayeredComponentViewModel(Component.Frame, "Frame"); } 
            set
            {
                Component.Frame = (Frame)value.Component;
                OnPropertyChanged("Frame");
            }
        }

        public LayeredComponentViewModel Panel
        {
            get { return new LayeredComponentViewModel(Component.Panel, "Panel"); }
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

        public List<object> Components
        {
            get
            {
                return new List<object>() { Frame, Panel, Seal };
            }
        }

    }
}