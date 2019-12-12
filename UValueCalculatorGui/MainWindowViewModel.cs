namespace UValueCalculatorGui
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _CurrentViewModel;

        public RelayCommand<ViewModelBase> DisplayViewModel { get; private set; }

        public MainWindowViewModel()
        {
            DisplayViewModel = new RelayCommand<ViewModelBase>(OnDisplayViewModel);
        }

        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set
            {
                if (object.Equals(_CurrentViewModel, value)) return;
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
        }
    }
}