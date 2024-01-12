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
    /// Interaction logic for CustomerStatusUserControl.xaml
    /// </summary>
    public partial class CustomerStatusUserControl : UserControl
    {
        public CustomerStatusUserControl()
        {
            InitializeComponent();
        }

        private void BtnNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            BtnNewCustomerIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.CheckCircle;
            if(BtnExistingCustomerIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                BtnExistingCustomerIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.None;
            }

            Actions.IsNewCustomer = true;
        }

        private void BtnExistingCustomer_Click(object sender, RoutedEventArgs e)
        {
            BtnExistingCustomerIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.CheckCircle;
            if (BtnNewCustomerIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                BtnNewCustomerIcon.Icon = FontAwesome.WPF.FontAwesomeIcon.None;
            }

            Actions.IsNewCustomer = false;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if(BtnNewCustomerIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle || BtnExistingCustomerIcon.Icon == FontAwesome.WPF.FontAwesomeIcon.CheckCircle)
            {
                PurposeSelectionUserControl purposeSelectionUserControl = new PurposeSelectionUserControl();
                UserControlsHandlerClass.AddUserControl("3", purposeSelectionUserControl);

                MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

                if (callViewBaseUserControl != null)
                {
                    callViewBaseUserControl.Dispatcher.Invoke(() =>
                    {
                        callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                        callViewBaseUserControl.GrdCallInputsContainer.Children.Add(purposeSelectionUserControl);
                    });
                }
            }
            else
            {
                MessageBox.Show("Select The Customer status", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
