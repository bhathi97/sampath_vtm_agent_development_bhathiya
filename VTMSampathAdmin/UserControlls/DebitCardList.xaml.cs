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
    /// Interaction logic for DebitCardList.xaml
    /// </summary>
    public partial class DebitCardList : UserControl
    {
        public DebitCardList()
        {
            InitializeComponent();




        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TblDataTable.ViewingMode = FlowDocumentReaderViewingMode.Scroll;
            TblDataTable.IsPageViewEnabled = false;
            TblDataTable.IsTwoPageViewEnabled = false;


            //combo box values
            myComboBox.Items.Add("All");
            myComboBox.Items.Add("Complete List");
            myComboBox.Items.Add("Incomplete List");
            myComboBox.Items.Add("Rejected List");
        }
    }
}
