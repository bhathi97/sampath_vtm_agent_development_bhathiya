using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Effects;
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Classes.BackendDataLoading;
using VTMSampathAdmin.Popups;
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for ApplicationList.xaml
    /// </summary>
    public partial class ApplicationList : UserControl
    {
        public ApplicationList()
        {
            InitializeComponent();
            TbSearch.Focus();

            string url = Actions.IP + @"Application/view-all-applications";

            //make to the date range
            DateRangeClass dateRange = new DateRangeClass();


            ApplicationData applicationData = new ApplicationData();
            _ = applicationData.LoadAllAppliactionData(url, TblDataTable, this, dateRange);

            //Actions.LoadAllAppliactionData(url, TblDataTable,this);

            //combo box values
            CBApplicatounList.Items.Add("All");
            CBApplicatounList.Items.Add("Complete List");
            CBApplicatounList.Items.Add("Incomplete List");
            CBApplicatounList.Items.Add("Rejected List");



        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TblDataTable.ViewingMode = FlowDocumentReaderViewingMode.Scroll;
            TblDataTable.IsPageViewEnabled = false;
            TblDataTable.IsTwoPageViewEnabled = false;
        }

        

        private void BtnDateRangeSelect_Click(object sender, RoutedEventArgs e)
        {
            //
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

                string url = Actions.IP + @"Application/view-all-applications";
                



                ApplicationData applicationData = new ApplicationData();
                _ = applicationData.LoadAllAppliactionData(url, TblDataTable, this, dateRange);
            }





        }

        
    }
}
