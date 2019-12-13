using UValueCalculatorGui.Repositories;

namespace UValueCalculatorGui
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _CurrentViewModel;

        public RelayCommand<ViewModelBase> DisplayViewModel { get; private set; }

        public MainWindowViewModel()
        {
            DisplayViewModel = new RelayCommand<ViewModelBase>(OnDisplayViewModel);
            BuildingRepository buildingRepository = new BuildingRepository();
            BuildingTreeViewModel buildingViewModel = new BuildingTreeViewModel(buildingRepository.GetBuildingFromXMLFile("test"));
            Building = buildingViewModel;
        }

        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set
            {
                _CurrentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        private void OnDisplayViewModel(ViewModelBase viewModel)
        {
            if (viewModel is LayerViewModel)
            {
                viewModel = ((LayerViewModel)viewModel).Parent;
            }
            CurrentViewModel = viewModel;
            Building.OnPropertyChanged("UValue");
        }

        public BuildingTreeViewModel Building
        {
            get;
        }
    }
}