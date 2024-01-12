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
using VTMSampathAdmin.Classes;

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
            string jsonFilePath = @"C:\Users\payme\OneDrive\Desktop\data.json";

            Actions.LoadJsonDataAndUpdateTable(jsonFilePath, TblDataTable, this, "Complete");


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
    }
}
