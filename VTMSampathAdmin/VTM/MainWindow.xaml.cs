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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Popups;
using VTMSampathAdmin.UserControlls;

namespace VTMSampathAdmin.VTM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //load dashboard user control to the Main grid
            try
            {




                DashBoardUserControl dashBoardUserControl = new DashBoardUserControl();
                Dispatcher.Invoke(() =>
                {
                    LblUserName.Content = Actions.AgentName;
                    LblUserLocation.Content = Actions.AgentBranch;
                    GrdMain.Children.Add(dashBoardUserControl);
                });


                SetAgentDetails();






                /*CallViewBaseUserControl callViewBaseUserControl = new CallViewBaseUserControl();
                Dispatcher.Invoke(() =>
                {
                    GrdMain.Children.Add(callViewBaseUserControl);
                });*/

                /*View_CompletedApplication view_CompletedApplication = new View_CompletedApplication();
                GrdMain.Children.Add(view_CompletedApplication);*/

                /* View_RejectedApplication view_RejectedApplication = new View_RejectedApplication();
                 GrdMain.Children.Add(view_RejectedApplication);*/

                /*View_DebitCardIssuedApplication view_DebitCardIssuedApplication = new View_DebitCardIssuedApplication();
                GrdMain.Children.Add(view_DebitCardIssuedApplication);*/

            }
            catch(Exception ex)
            {

            }
        }

        

        private void Window_Closed(object sender, EventArgs e)
        {
            GrdMain.Children.Clear();

        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void BtnAddAgentDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SetAgentDetails();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButton.OKCancel,MessageBoxImage.Error);
            }
        }

        private void SetAgentDetails()
        {
            SetProfileWindow setProfileWindow = new SetProfileWindow();
            setProfileWindow.Owner = this;

            Effect = (Effect)Application.Current.Resources["BlurEffect"]; //add blur effect to the background
            setProfileWindow.ShowDialog();
            Effect = null;

            if(Actions.AgentName != null)
            {
                LblUserName.Content = Actions.AgentName;
            }
            if(Actions.AgentBranch != null)
            {
                LblUserLocation.Content = Actions.AgentBranch;
            }
            
        }
    }
}
