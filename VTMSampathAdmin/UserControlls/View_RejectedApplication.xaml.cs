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
    /// Interaction logic for View_RejectedApplication.xaml
    /// </summary>
    public partial class View_RejectedApplication : UserControl
    {
        public View_RejectedApplication()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ImgCustomer.ImageSource = new BitmapImage(new Uri("C://Users//payme//Downloads//userrr.jpg"));
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDownload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
