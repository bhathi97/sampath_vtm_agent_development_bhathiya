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
using System.Windows.Shapes;
using VTMSampathAdmin.UserControlls;
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.Popups
{
    /// <summary>
    /// Interaction logic for NewCallRequestWindow.xaml
    /// </summary>
    public partial class NewCallRequestWindow : Window
    {
        public NewCallRequestWindow()
        {
            InitializeComponent();
        }

        private void ImgClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void BtnAcceptCall_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CallViewBaseUserControl callViewBaseUserControl = new CallViewBaseUserControl();

                MainWindow mainWindow = FindOpenWindow<MainWindow>();
                if (mainWindow != null)
                {
                    // Access components within the open MainWindow
                    mainWindow.GrdMain.Children.Clear();
                    mainWindow.GrdMain.Children.Add(callViewBaseUserControl);
 
                    
                }
                else
                {
                    //
                }
                Close();
            }
            catch (Exception ex)
            {

            }

        }



        private T FindOpenWindow<T>() where T : Window
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is T typedWindow)
                {
                    return typedWindow;
                }
            }
            return null;
        }

        private void BtnHoldCall_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
