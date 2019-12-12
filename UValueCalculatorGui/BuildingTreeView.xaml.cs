using System.Windows.Controls;
using UValueCalculatorGui.Repositories;

namespace UValueCalculatorGui
{
    /// <summary>
    /// Interaction logic for BuildingTreeView.xaml
    /// </summary>
    public partial class BuildingTreeView : UserControl
    {
        public BuildingTreeView()
        {
            BuildingRepository buildingRepository = new BuildingRepository();
            BuildingTreeViewModel buildingViewModel = new BuildingTreeViewModel(buildingRepository.GetBuildingFromXMLFile("test"));
            //this.DataContext = buildingViewModel;
            InitializeComponent();
            Building.ItemsSource = buildingViewModel.Components;
        }
    }
}