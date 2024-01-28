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
    /// Interaction logic for VerifySignatureUserControl.xaml
    /// </summary>
    public partial class VerifySignatureUserControl : UserControl
    {
        public VerifySignatureUserControl()
        {
            InitializeComponent();
            
        }

        private void BtnCapture_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(Actions.Purpose == PurposeEnum.debitCard)
                {
                    Actions.BackToPreviousUserController<SessionInputsUserControl_debitcard>("4");
                }
                else if (Actions.Purpose == PurposeEnum.newApplication)
                {
                    Actions.BackToPreviousUserController<IssueDebitCardUserControl>("46");

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }


            
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Actions.GoToNewUserController<CaptureDebitCardUserControl>("4611");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }

            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if(Actions.Purpose == PurposeEnum.debitCard)
            {
                BorderBtnSave.Visibility = Visibility.Visible;
                BorderBtnContinue.Visibility = Visibility.Collapsed;
            }
            else if(Actions.Purpose == PurposeEnum.newApplication)
            {
                BorderBtnSave.Visibility = Visibility.Collapsed;
                BorderBtnContinue.Visibility = Visibility.Visible;
            }
        }
    }
}
