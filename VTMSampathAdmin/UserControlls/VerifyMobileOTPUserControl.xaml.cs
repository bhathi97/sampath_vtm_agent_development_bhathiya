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
    /// Interaction logic for VerifyMobileOTPUserControl.xaml
    /// </summary>
    public partial class VerifyMobileOTPUserControl : UserControl
    {
        public VerifyMobileOTPUserControl()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Actions.BackToPreviousUserController<VerifyMobileUserControl>("42");
        }

        private void BtnResend_Click(object sender, RoutedEventArgs e)
        {

        }

        #region methods

        //clear textboxes
        private void ClearTextBoxes()
        {
            Tbotp_1.Text = "";
            Tbotp_2.Text = "";
            Tbotp_3.Text = "";
            Tbotp_4.Text = "";
            Tbotp_5.Text = "";
            Tbotp_6.Text = "";
        }


        #endregion


        #region INPUT NUMBER
        #endregion
        private void Tbotp_1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Actions.NumberValidation(sender, e);
        }

        private void Tbotp_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Tbotp_1.Text.Length > 0)
            {
                Tbotp_2.Focus();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Tbotp_1.Focus();
        }

        private void Tbotp_2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Actions.NumberValidation(sender, e);
        }

        private void Tbotp_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tbotp_2.Text.Length > 0)
            {
                Tbotp_3.Focus();
            }
        }

        private void Tbotp_3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Actions.NumberValidation(sender, e);
        }

        private void Tbotp_3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tbotp_3.Text.Length > 0)
            {
                Tbotp_4.Focus();
            }
        }

        private void Tbotp_4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Actions.NumberValidation(sender, e);
        }

        private void Tbotp_4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tbotp_4.Text.Length > 0)
            {
                Tbotp_5.Focus();
            }
        }

        private void Tbotp_5_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Actions.NumberValidation(sender, e);
        }

        private void Tbotp_5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tbotp_5.Text.Length > 0)
            {
                Tbotp_6.Focus();
            }
        }

        private void Tbotp_6_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Actions.NumberValidation(sender, e);
        }

        private void Tbotp_6_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tbotp_6.Text.Length > 0)
            {
                BtnSave.Focus();
            }
        }
    }
}
