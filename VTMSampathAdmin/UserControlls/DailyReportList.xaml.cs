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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for DailyReportList.xaml
    /// </summary>
    public partial class DailyReportList : UserControl
    {
        public DailyReportList()
        {
            InitializeComponent();
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

        private void BtnDownload_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
