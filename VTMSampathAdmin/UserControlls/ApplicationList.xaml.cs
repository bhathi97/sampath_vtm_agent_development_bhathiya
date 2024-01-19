using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using VTMSampathAdmin.Classes;

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

            //testing
            string url = Actions.IP + @"Application/view-all-applications";

            //Actions.LoadJsonDataAndUpdateTable(url, TblDataTable, this);

            Actions.LoadAllAppliactionData(url, TblDataTable,this);

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

        

        
    }
}
