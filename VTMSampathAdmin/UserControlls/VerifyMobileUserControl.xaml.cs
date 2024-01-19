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
            SessionInputsUserControl sessionInputsUserControl = (SessionInputsUserControl)UserControlsHandlerClass.GetUserControl("4");

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

        private void BtnSendOTP_Click(object sender, RoutedEventArgs e)
        {
            VerifyMobileOTPUserControl verifyMobileOTPUserControl = new VerifyMobileOTPUserControl();
            UserControlsHandlerClass.AddUserControl("421", verifyMobileOTPUserControl);

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(verifyMobileOTPUserControl);
                });
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TbNicInput.Focus();
        }

        private void TbNicInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Actions.NumberValidation(sender, e);
        }
    }
}
