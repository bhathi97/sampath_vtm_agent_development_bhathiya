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
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for SessionInputsUserControl_debitcard.xaml
    /// </summary>
    public partial class SessionInputsUserControl_debitcard : UserControl
    {
        public SessionInputsUserControl_debitcard()
        {
            InitializeComponent();
        }

        private void BtnShowSessionInputs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVerifySign_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Actions.CheckCircle(BtnVerifySignIcon, BtnVerifySign, this);
                Actions.GoToNewUserController<VerifySignatureUserControl>("41");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }

        }

        private void BtnVerifyMobileNumber_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Actions.CheckCircle(BtnVerifyMobileNumberIcon, BtnVerifyMobileNumber, this);
                Actions.GoToNewUserController<VerifyMobileUserControl>("42");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }

        }

        private void BtnIssueDebitCard_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Actions.CheckCircle(BtnIssueDebitCardIcon, BtnIssueDebitCard, this);
                Actions.GoToNewUserController<IssueDebitCardUserControl>("46");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }

        }

        private void BtnCaptureSign_Click(object sender, RoutedEventArgs e)
        {
            Actions.CheckCircle(BtnCaptureSignIcon, BtnCaptureSign, this);
            Actions.GoToNewUserController<CaptureSignatureUserControl>("47");
        }
    }
}
