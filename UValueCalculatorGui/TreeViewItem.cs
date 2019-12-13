namespace UValueCalculatorGui
{
    public class TreeViewItem : ViewModelBase
    {
        protected bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    this.OnPropertyChanged("IsSelected");
                    this.OnPropertyChanged("SelectedLayer");
                }
            }
        }
    }
}