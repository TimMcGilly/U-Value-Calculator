using System.Collections.Generic;
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
            BuildingViewModel buildingViewModel =new BuildingViewModel( buildingRepository.GetBuildingFromXMLFile("test"));
            this.DataContext = new BuildingsTreeViewModel(new List<BuildingViewModel>() { buildingViewModel});
            InitializeComponent();
        }
    }
}