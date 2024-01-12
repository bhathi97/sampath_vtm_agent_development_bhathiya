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
    /// Interaction logic for CaptureDebitCardUserControl.xaml
    /// </summary>
    public partial class CaptureDebitCardUserControl : UserControl
    {
        public CaptureDebitCardUserControl()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            IssueDebitCardUserControl issueDebitCardUserControl = (IssueDebitCardUserControl)UserControlsHandlerClass.GetUserControl("46");

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

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnScan_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
