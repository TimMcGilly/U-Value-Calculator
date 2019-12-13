using System.Collections.Generic;
using System.Linq;
using UValueCalculator;
using UValueCalculator.UValueComponents;

namespace UValueCalculatorGui
{
    public class BuildingTreeViewModel: ViewModelBase
    {
        public Building CurrentBuilding { get; set; }

        public BuildingTreeViewModel(Building building)
        {
            CurrentBuilding = building;
        }

        public double UValue
        {
            get
            {
                return CurrentBuilding.CalculateUValue();
            }
        }

        public List<LayeredComponentViewModel> LayeredComponents
        {
            get
            {
                List<LayeredComponentViewModel> viewModels = new List<LayeredComponentViewModel>();
                IEnumerable<IUValueComponent> layeredComponents = CurrentBuilding.Components.Where(x => x is IUValueLayeredComponent);
                foreach (IUValueComponent layeredComponent in layeredComponents)
                {
                    viewModels.Add(new LayeredComponentViewModel((IUValueLayeredComponent)layeredComponent));
                }

                return viewModels;
            }
        }

        public List<WindowComponentViewModel> WindowComponents
        {
            get
            {
                List<WindowComponentViewModel> viewModels = new List<WindowComponentViewModel>();
                IEnumerable<IUValueComponent> windowComponents = CurrentBuilding.Components.Where(x => x is Window);
                foreach (IUValueComponent windowComponent in windowComponents)
                {
                    viewModels.Add(new WindowComponentViewModel((Window)windowComponent));
                }

                return viewModels;
            }
        }

        public List<object> Components
        {
            get
            {
                List<object> o = new List<object>();

                o.AddRange(LayeredComponents.ToArray());
                o.AddRange(WindowComponents.ToArray());
                return o;
            }
        }
    }
}