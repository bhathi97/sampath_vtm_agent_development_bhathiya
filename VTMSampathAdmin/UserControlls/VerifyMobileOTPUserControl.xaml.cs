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
            VerifyMobileUserControl verifyMobileUserControl = (VerifyMobileUserControl)UserControlsHandlerClass.GetUserControl("42");

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(verifyMobileUserControl);
                });
            }
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

    }
}
