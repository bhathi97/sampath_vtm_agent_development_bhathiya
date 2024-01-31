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
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Classes.JsonDataToBackend;
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.Popups
{
    /// <summary>
    /// Interaction logic for SetProfileWindow.xaml
    /// </summary>
    public partial class SetProfileWindow : Window
    {
        private bool _isBranchSelected = false;
        public SetProfileWindow()
        {
            InitializeComponent();

            /*CBBranchList.Items.Add("Select Your Branch");
            CBBranchList.SelectedItem = "Select Your Branch";

            // load branches from backend 
            //testing
            CBBranchList.Items.Add("Colombo");
            CBBranchList.Items.Add("Kandy");
            CBBranchList.Items.Add("Gampaha");*/


            


        }

        private void ImgClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            //if name not null and select a branch
            if(TBName != null)
            {
                Actions.AgentName = TBName.Text;



                //only for testing--------------------------------------------------------
                Random random = new Random(100);
                ApplicationTableRecord.ApplicationInstance.AgentId = random.Next();
                //Actions.AgentBranch = CBBranchList.SelectedItem.ToString();

                //change the name after hello in dashboard
                int spaceIndex = TBName.Text.IndexOf(' ');
                string firstName = "";
                if(spaceIndex != -1)
                {
                    firstName = TBName.Text.Substring(0, spaceIndex);
                }
                else
                {
                    firstName = TBName.Text;
                }

                Actions.DashBoardContentUserControl.LblAgentName.Content = firstName;


                Close();
            }
        }

        /*private void CBBranchList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!_isBranchSelected)
            {
                _isBranchSelected = true;
            }
            else
            {
                CBBranchList.Items.Remove("Select Your Branch");
            }
            
           
        }*/

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //if agent has already add data 
            if (Actions.AgentName != null)
            {
                TBName.Text = Actions.AgentName;
            }
            /*if (Actions.AgentBranch != null)
            {
                CBBranchList.SelectedItem = Actions.AgentBranch;
            }*/

            //focus to the name entering text box
            TBName.Focus();
            TBName.CaretIndex = TBName.Text.Length;
        }

        private void TBName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //CBBranchList.Focus();
                e.Handled = true;
            }
        }
    }
}
