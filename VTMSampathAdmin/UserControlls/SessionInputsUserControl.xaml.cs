using FontAwesome.WPF;
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
using VTMSampathAdmin.Classes.JsonDataToBackend;
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for SessionInputsUserControl.xaml
    /// </summary>
    public partial class SessionInputsUserControl : UserControl
    {
        public SessionInputsUserControl()
        {
            InitializeComponent();
        }

        private void BtnDrpCheck_Click(object sender, RoutedEventArgs e)
        {
            
            Actions.GoToNewUserController<DRPChaeckUserControl>("41");

        }

        private void BtnVerifyMobile_Click(object sender, RoutedEventArgs e)
        {
            
            //Actions.CheckCircle(BtnVerifyMobileIcon, BtnVerifyMobile,this);
            Actions.GoToNewUserController<VerifyMobileUserControl>("42");

        }

        private void BtnCaptureCustomer_Click(object sender, RoutedEventArgs e)
        {
            //Actions.CheckCircle(BtnCaptureCustomerIcon, BtnCaptureCustomer, this);
            Actions.GoToNewUserController<CaptureCustomerImageUserControl>("43");
        }

        private void BtnAddressProof_Click(object sender, RoutedEventArgs e)
        {
            //Actions.CheckCircle(BtnAddressProofIcon, BtnAddressProof, this);
            Actions.GoToNewUserController<CaptureAddressProofUserControl>("44");
        }

        private void BtnAdditionalDocs_Click(object sender, RoutedEventArgs e)
        {
            //Actions.CheckCircle(BtnAdditionalDocsIcon, BtnAdditionalDocs, this);
            Actions.GoToNewUserController<CaptureAdditionalDocsUserControl>("45");

        }

        private void BtnIssueDC_Click(object sender, RoutedEventArgs e)
        {
            //Actions.CheckCircle(BtnIssueDCIcon, BtnIssueDC, this);
            Actions.GoToNewUserController<IssueDebitCardUserControl>("46");

        }

        private void BtnCaptureSign_Click(object sender, RoutedEventArgs e)
        {
            //Actions.CheckCircle(BtnCaptureSignIcon, BtnCaptureSign,this);
            Actions.GoToNewUserController<CaptureSignatureUserControl>("47");

        }


        /*private void CheckCircle(ImageAwesome imageAwesome , Button button)
        {
            Dispatcher.Invoke(() =>
            {
                imageAwesome.Icon = FontAwesomeIcon.CheckCircle;
                button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
            });
                
        }*/

        private void BtnShowSessionInputs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
