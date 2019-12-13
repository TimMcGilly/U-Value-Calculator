using System.Windows;
using System.Windows.Controls;
using UValueCalculatorGui.Repositories;

namespace UValueCalculatorGui
{
    /// <summary>
    /// Interaction logic for BuildingTreeView.xaml
    /// </summary>
    public partial class BuildingTreeView : UserControl
    {
        public static readonly DependencyProperty BuildingViewProperty =
           DependencyProperty.Register("BuildingView", typeof(BuildingTreeViewModel), typeof(UserControl), new FrameworkPropertyMetadata(null));


        public BuildingTreeViewModel BuildingView
        {
            get { return (BuildingTreeViewModel)GetValue(BuildingViewProperty); }
            set { SetValue(BuildingViewProperty, value); }
        }

        public BuildingTreeView()
        {
            //BuildingRepository buildingRepository = new BuildingRepository();
            //BuildingTreeViewModel buildingViewModel = new BuildingTreeViewModel(buildingRepository.GetBuildingFromXMLFile("test"));
            InitializeComponent();
            Loaded += BuildingTreeViewLoaded;
        }
        private void BuildingTreeViewLoaded(object sender, RoutedEventArgs e)
        {
            Building.ItemsSource = BuildingView.Components;
        }

    }
}