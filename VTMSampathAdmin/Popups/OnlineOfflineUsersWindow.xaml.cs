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
using System.Windows.Shapes;

namespace VTMSampathAdmin.Popups
{
    /// <summary>
    /// Interaction logic for OnlineOfflineUsersWindow.xaml
    /// </summary>
    public partial class OnlineOfflineUsersWindow : Window
    {
        public OnlineOfflineUsersWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TblDataTable.ViewingMode = FlowDocumentReaderViewingMode.Scroll;
            TblDataTable.IsPageViewEnabled = false;
            TblDataTable.IsTwoPageViewEnabled = false;
        }

        private void ImgClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
