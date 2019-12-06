using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UValueCalculatorGui
{
    public class BuildingsTreeViewModel : ViewModelBase
    {
        private ObservableCollection<BuildingViewModel> buildingViewModels;

        public BuildingsTreeViewModel(List<BuildingViewModel> buildingViewModels)
        {
            this.buildingViewModels = new ObservableCollection<BuildingViewModel>(buildingViewModels);
        }

        public ObservableCollection<BuildingViewModel> Buildings
        {
            get
            {
                return buildingViewModels;
            }
            set
            {
                buildingViewModels = value;
                OnPropertyChanged("Buildings");
            }
        }
    }
}