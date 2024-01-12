using System.Windows;
using System.Windows.Controls;
using VTMSampathAdmin.Classes;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for ApplicationList_incompleted.xaml
    /// </summary>
    public partial class ApplicationList_incompleted : UserControl
    {
        public ApplicationList_incompleted()
        {
            InitializeComponent();

            //testing
            string jsonFilePath = @"C:\Users\payme\OneDrive\Desktop\data.json";

            Actions.LoadJsonDataAndUpdateTable(jsonFilePath, TblDataTable, this, "Incomplete");

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TblDataTable.ViewingMode = FlowDocumentReaderViewingMode.Scroll;
            TblDataTable.IsPageViewEnabled = false;
            TblDataTable.IsTwoPageViewEnabled = false;
        }
    }
}
