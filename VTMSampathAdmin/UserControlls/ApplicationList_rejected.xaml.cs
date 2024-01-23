using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Effects;
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Classes.BackendDataLoading;
using VTMSampathAdmin.Popups;
using VTMSampathAdmin.VTM;

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

            string url = Actions.IP + @"Application/view-rejected-applications";

            //make to the date range
            DateRangeClass dateRange = new DateRangeClass();

            ApplicationData applicationData = new ApplicationData();
            _ = applicationData.LoadRejectedApplicationData(url, TblDataTable, this, dateRange);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TblDataTable.ViewingMode = FlowDocumentReaderViewingMode.Scroll;
            TblDataTable.IsPageViewEnabled = false;
            TblDataTable.IsTwoPageViewEnabled = false;
        }

        private void BtnDateRangeSelect_Click(object sender, RoutedEventArgs e)
        {
            DateRangePicker dateRangePicker = new DateRangePicker();
            MainWindow mainWindow = Actions.FindAndLoadMainWindow();

            //blure the window
            mainWindow.Effect = (Effect)Application.Current.Resources["BlurEffect"];
            dateRangePicker.ShowDialog();
            mainWindow.Effect = null;

            if (dateRangePicker.IsDateRangeSelect)
            {
                //clear existing table data
                Actions.ClearTableData(TblDataTable);

                //make to the date range
                DateRangeClass dateRange = new DateRangeClass
                {
                    FromDate = dateRangePicker.FromDate,
                    ToDate = dateRangePicker.ToDate
                };

                string url = Actions.IP + @"Application/view-rejected-applications";

                ApplicationData applicationData = new ApplicationData();
                _ = applicationData.LoadRejectedApplicationData(url, TblDataTable, this, dateRange);
            }
        }
    }
}
