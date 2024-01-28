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
    /// Interaction logic for IssueDebitCardUserControl.xaml
    /// </summary>
    public partial class IssueDebitCardUserControl : UserControl
    {
        public IssueDebitCardUserControl()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (Actions.Purpose == PurposeEnum.newApplication) 
                {
                    Actions.BackToPreviousUserController<SessionInputsUserControl>("4");
                }
                else if (Actions.Purpose == PurposeEnum.debitCard)
                {
                    Actions.BackToPreviousUserController<SessionInputsUserControl_debitcard>("4");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCardIssue_Click(object sender, RoutedEventArgs e)
        {
            Actions.GoToNewUserController<VerifySignatureUserControl>("461");
        }
    }
}
