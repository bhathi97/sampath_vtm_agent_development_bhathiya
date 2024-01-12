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
                SessionInputsUserControl sessionInputsUserControl = new SessionInputsUserControl();
                UserControlsHandlerClass.AddUserControl("4", sessionInputsUserControl);

                MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

                if (callViewBaseUserControl != null)
                {
                    callViewBaseUserControl.Dispatcher.Invoke(() =>
                    {
                        callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                        callViewBaseUserControl.GrdCallInputsContainer.Children.Add(sessionInputsUserControl);
                    });
                }
            } 
        }

        private void BtnAccountOpen_Click(object sender, RoutedEventArgs e)
        {
            Actions.Purpose = Actions.PurposeSelectOptions.a;

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
            Actions.Purpose = Actions.PurposeSelectOptions.o;
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
            Actions.Purpose = Actions.PurposeSelectOptions.d;
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
