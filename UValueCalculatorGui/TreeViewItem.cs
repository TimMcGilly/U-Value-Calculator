namespace UValueCalculatorGui
{
    public class TreeViewItem : ViewModelBase
    {
        protected bool _isSelected;

        public virtual bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    this.OnPropertyChanged("IsSelected");
                    this.OnPropertyChanged("SelectedObject");
                }
            }
        }
    }
}