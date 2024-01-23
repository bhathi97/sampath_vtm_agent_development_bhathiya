using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Classes.BackendDataLoading;
using VTMSampathAdmin.Popups;
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for ApplicationList_completed.xaml
    /// </summary>
    public partial class ApplicationList_completed : UserControl
    {
        public ApplicationList_completed()
        {
            InitializeComponent();
            string url = Actions.IP + @"Application/view-complete-applications";

            //make to the date range
            DateRangeClass dateRange = new DateRangeClass();

            ApplicationData applicationData = new ApplicationData();
            _ = applicationData.LoadCompletedApplicationData(url, TblDataTable, this, dateRange);


        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TblDataTable.ViewingMode = FlowDocumentReaderViewingMode.Scroll;
            TblDataTable.IsPageViewEnabled = false;
            TblDataTable.IsTwoPageViewEnabled = false;
        }

        public static implicit operator ApplicationList_completed(ApplicationList v)
        {
            throw new NotImplementedException();
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

                string url = Actions.IP + @"Application/view-complete-applications";

                ApplicationData applicationData = new ApplicationData();
                _ = applicationData.LoadCompletedApplicationData(url, TblDataTable, this, dateRange);
            }
        }
    }
}
