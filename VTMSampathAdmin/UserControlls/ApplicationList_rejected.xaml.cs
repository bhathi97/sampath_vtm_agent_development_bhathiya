using System.Windows;
using System.Windows.Controls;
using VTMSampathAdmin.Classes;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for ApplicationList_rejected.xaml
    /// </summary>
    public partial class ApplicationList_rejected : UserControl
    {
        public ApplicationList_rejected()
        {
            InitializeComponent();

            string jsonFilePath = @"C:\Users\payme\OneDrive\Desktop\data.json";

            Actions.LoadJsonDataAndUpdateTable(jsonFilePath, TblDataTable, this, "Rejected");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TblDataTable.ViewingMode = FlowDocumentReaderViewingMode.Scroll;
            TblDataTable.IsPageViewEnabled = false;
            TblDataTable.IsTwoPageViewEnabled = false;
        }
    }
}
