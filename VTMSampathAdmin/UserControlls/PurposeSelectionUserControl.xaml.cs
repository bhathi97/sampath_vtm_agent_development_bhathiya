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
    /// Interaction logic for PurposeSelectionUserControl.xaml
    /// </summary>
    public partial class PurposeSelectionUserControl : UserControl
    {

        public PurposeSelectionUserControl()
        {
            InitializeComponent();

        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if(BtnOtherServicesIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle || BtnDebitCardIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle || BtnAccountOpenIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                //check Select Application or Debit Card
                if(Actions.Purpose == PurposeEnum.newApplication)
                {
                    Actions.GoToNewUserController<SessionInputsUserControl>("4");
                }
                else if (Actions.Purpose == PurposeEnum.debitCard)
                {
                    Actions.GoToNewUserController<SessionInputsUserControl_debitcard>("4");
                }

               
            } 
        }

        private void BtnAccountOpen_Click(object sender, RoutedEventArgs e)
        {
            Actions.Purpose = PurposeEnum.newApplication;

            BtnAccountOpenIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.CheckCircle;
            if (BtnOtherServicesIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                BtnOtherServicesIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.None;
            }
            if (BtnDebitCardIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                BtnDebitCardIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.None;
            }

        }

        private void BtnOtherServices_Click(object sender, RoutedEventArgs e)
        {
            Actions.Purpose = PurposeEnum.other;

            BtnOtherServicesIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.CheckCircle;

            if (BtnDebitCardIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                BtnDebitCardIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.None;
            }
            if (BtnAccountOpenIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                BtnAccountOpenIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.None;
            }
        }

        private void BtnDebitCard_Click(object sender, RoutedEventArgs e)
        {
            Actions.Purpose = PurposeEnum.debitCard;

            BtnDebitCardIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.CheckCircle;

            if (BtnOtherServicesIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                BtnOtherServicesIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.None;
            }
            if (BtnAccountOpenIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                BtnAccountOpenIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.None;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (Actions.IsNewCustomer)
            {
                GrdDebitCard.Visibility = Visibility.Collapsed;
            }

            
        }
    }
}
