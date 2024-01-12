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
    /// Interaction logic for ReviewWindow.xaml
    /// </summary>
    public partial class ReviewWindow : Window
    {
        private bool isSelectAccOpening  = false;
        private bool isSelectSmsService = false;
        private bool isSelectEmailChange = false;
        private bool isSelectDebitCardIssue = false;
        private bool isSelectNumberChange = false;
        private bool isSelectAddressChange = false;




        public ReviewWindow()
        {
            InitializeComponent();
        }

        

        private void ImgClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        #region check buttons 
        private void BtnAccOpen_Click(object sender, RoutedEventArgs e)
        {
            isSelectAccOpening = !isSelectAccOpening;
            Img_BtnAccOpen.Icon = isSelectAccOpening ? FontAwesome.WPF.FontAwesomeIcon.CheckSquare : FontAwesome.WPF.FontAwesomeIcon.None;

        }

        private void BtnSmsService_Click(object sender, RoutedEventArgs e)
        {
            isSelectSmsService = !isSelectSmsService;
            Img_BtnSmsService.Icon = isSelectSmsService ? FontAwesome.WPF.FontAwesomeIcon.CheckSquare : FontAwesome.WPF.FontAwesomeIcon.None;
        }

        private void BtnEmailChange_Click(object sender, RoutedEventArgs e)
        {
            isSelectEmailChange = !isSelectEmailChange;
            Img_BtnEmailChange.Icon = isSelectEmailChange ? FontAwesome.WPF.FontAwesomeIcon.CheckSquare : FontAwesome.WPF.FontAwesomeIcon.None;
        }

        private void BtnDebitCardIssue_Click(object sender, RoutedEventArgs e)
        {
            isSelectDebitCardIssue = !isSelectDebitCardIssue;
            Img_BtnDebitCardIssue.Icon = isSelectDebitCardIssue ? FontAwesome.WPF.FontAwesomeIcon.CheckSquare : FontAwesome.WPF.FontAwesomeIcon.None;
        }

        private void BtnNumberChange_Click(object sender, RoutedEventArgs e)
        {
            isSelectNumberChange = !isSelectNumberChange;
            Img_BtnNumberChange.Icon = isSelectNumberChange ? FontAwesome.WPF.FontAwesomeIcon.CheckSquare : FontAwesome.WPF.FontAwesomeIcon.None;
        }

        private void BtnAddressChange_Click(object sender, RoutedEventArgs e)
        {
            isSelectAddressChange = !isSelectAddressChange;
            Img_BtnAddressChange.Icon = isSelectAddressChange ? FontAwesome.WPF.FontAwesomeIcon.CheckSquare : FontAwesome.WPF.FontAwesomeIcon.None;
        }


        #endregion

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
