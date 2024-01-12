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
            CheckCircle(BtnDrpCheckIcon, BtnDrpCheck);

            DRPChaeckUserControl dRPChaeckUserControl = new DRPChaeckUserControl();
            UserControlsHandlerClass.AddUserControl("41", dRPChaeckUserControl);

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(dRPChaeckUserControl);
                });
            }


        }

        private void BtnVerifyMobile_Click(object sender, RoutedEventArgs e)
        {
            
            CheckCircle(BtnVerifyMobileIcon, BtnVerifyMobile);

            VerifyMobileUserControl verifyMobileUserControl = new VerifyMobileUserControl();
            UserControlsHandlerClass.AddUserControl("42", verifyMobileUserControl);

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

        private void BtnCaptureCustomer_Click(object sender, RoutedEventArgs e)
        {
            CheckCircle(BtnCaptureCustomerIcon, BtnCaptureCustomer);

            CaptureCustomerImageUserControl captureCustomerImageUserControl = new CaptureCustomerImageUserControl();
            UserControlsHandlerClass.AddUserControl("43", captureCustomerImageUserControl);

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(captureCustomerImageUserControl);
                });
            }
        }

        private void BtnAddressProof_Click(object sender, RoutedEventArgs e)
        {
            CheckCircle(BtnAddressProofIcon, BtnAddressProof);

            CaptureAddressProofUserControl captureAddressProofUserControl = new CaptureAddressProofUserControl();
            UserControlsHandlerClass.AddUserControl("44", captureAddressProofUserControl);

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(captureAddressProofUserControl);
                });
            }
        }

        private void BtnAdditionalDocs_Click(object sender, RoutedEventArgs e)
        {
            CheckCircle(BtnAdditionalDocsIcon, BtnAdditionalDocs);

            CaptureAdditionalDocsUserControl captureAdditionalDocsUserControl = new CaptureAdditionalDocsUserControl();
            UserControlsHandlerClass.AddUserControl("45", captureAdditionalDocsUserControl);

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(captureAdditionalDocsUserControl);
                });
            }
        }

        private void BtnIssueDC_Click(object sender, RoutedEventArgs e)
        {
            CheckCircle(BtnIssueDCIcon, BtnIssueDC);


            IssueDebitCardUserControl issueDebitCardUserControl = new IssueDebitCardUserControl();
            UserControlsHandlerClass.AddUserControl("46", issueDebitCardUserControl);

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(issueDebitCardUserControl);
                });
            }



        }

        private void BtnCaptureSign_Click(object sender, RoutedEventArgs e)
        {
            CheckCircle(BtnCaptureSignIcon, BtnCaptureSign);

            CaptureSignatureUserControl captureSignatureUserControl = new CaptureSignatureUserControl();
            UserControlsHandlerClass.AddUserControl("47", captureSignatureUserControl);

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(captureSignatureUserControl);
                });
            }


        }


        private void CheckCircle(ImageAwesome imageAwesome , Button button)
        {
            Dispatcher.Invoke(() =>
            {
                imageAwesome.Icon = FontAwesomeIcon.CheckCircle;
                button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
            });
                
        }

        private void BtnShowSessionInputs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
