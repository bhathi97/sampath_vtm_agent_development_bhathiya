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
    /// Interaction logic for VerifyMobileUserControl.xaml
    /// </summary>
    public partial class VerifyMobileUserControl : UserControl
    {
        public VerifyMobileUserControl()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if(Actions.Purpose == PurposeEnum.newApplication)
            {
                Actions.BackToPreviousUserController<SessionInputsUserControl>("4");
            }
            else if(Actions.Purpose == PurposeEnum.debitCard)
            {
                Actions.BackToPreviousUserController<SessionInputsUserControl_debitcard>("4");
            }

            
        }

        private void BtnSendOTP_Click(object sender, RoutedEventArgs e)
        {
            BtnSendOTP.IsEnabled = false;
            Actions.CustomerMobileNumberToVerify = TbMobileInput.Text;
            TbMobileInput.Text = "";
            Actions.GoToNewUserController<VerifyMobileOTPUserControl>("421");


        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TbMobileInput.Focus();
            Actions.CustomerMobileNumberToVerify = "";
        }

        private void TbMobileInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Actions.NumberValidation(sender, e);
            
        }

        private void TbMobileInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TbMobileInput.Text.Length == 10)
            {
                BtnSendOTP.IsEnabled = true;
            }
        }
    }
}
