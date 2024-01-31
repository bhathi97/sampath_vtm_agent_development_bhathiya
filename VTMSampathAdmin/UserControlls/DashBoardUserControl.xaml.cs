using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using VTMSampathAdmin.Classes;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for DashBoardUserControl.xaml
    /// </summary>
    public partial class DashBoardUserControl : UserControl
    {
        public Button[] buttons;
        public DashBoardUserControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            buttons = new Button[12];
            buttons[0] = BtnDashboard;
            buttons[1] = BtnApplicationList;
            buttons[2] = BtnDebitCardIssue;
            buttons[3] = BtnSetting;
            buttons[4] = BtnLogout;
            //list
            buttons[5] = BtnApplicationListApproved;
            buttons[6] = BtnApplicationListIncomplete;
            buttons[7] = BtnApplicationListRejected;
            //debit cards
            buttons[8] = BtnDebitCardIssueApproved;
            buttons[9] = BtnDebitCardIssueIncomplete;
            buttons[10] = BtnDebitCardIssueRejected;

            buttons[11] = BtnDailyReport;

            //by default select the dashboard 
            GrdDashMain.Children.Clear();
            ChangeButtonColors(BtnDashboard);
            //load DashBoardContent user control
            DashBoardContentUserControl dashBoardContentUserControl = new DashBoardContentUserControl();
            dashBoardContentUserControl.LblAgentName.Content = Actions.AgentName;
            Actions.DashBoardContentUserControl = dashBoardContentUserControl;
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(dashBoardContentUserControl);
            });
        }

        private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        {
            GrdDashMain.Children.Clear();

            ChangeButtonColors(BtnDashboard);
            //load DashBoardContent user control

            
                this.Dispatcher.Invoke(() =>
                {
                    GrdDashMain.Children.Add(Actions.DashBoardContentUserControl);
                });
            
           
            

        }

        private void BtnApplicationList_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnApplicationList);
            //make visible collaped buttons under listButton
            BtnApplicationListApproved.Visibility = (BtnApplicationListApproved.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            BtnApplicationListIncomplete.Visibility = (BtnApplicationListIncomplete.Visibility ==  Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible ;
            BtnApplicationListRejected.Visibility = (BtnApplicationListRejected.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            IconApplicationList.Icon = (IconApplicationList.Icon == FontAwesome.WPF.FontAwesomeIcon.ChevronDown) ? FontAwesome.WPF.FontAwesomeIcon.ChevronUp : FontAwesome.WPF.FontAwesomeIcon.ChevronDown;


            //application list table show
            GrdDashMain.Children.Clear();
            //load DashBoardContent user control
            ApplicationList applicationList = new ApplicationList();
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(applicationList);
            });


        }

        private void BtnDebitCardIssue_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnDebitCardIssue);
            //make visible collaose under dabit cards
            BtnDebitCardIssueApproved.Visibility = (BtnDebitCardIssueApproved.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            BtnDebitCardIssueIncomplete.Visibility = (BtnDebitCardIssueIncomplete.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            BtnDebitCardIssueRejected.Visibility = (BtnDebitCardIssueRejected.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            IconDebitCardIssue.Icon = (IconDebitCardIssue.Icon == FontAwesome.WPF.FontAwesomeIcon.ChevronDown) ? FontAwesome.WPF.FontAwesomeIcon.ChevronUp : FontAwesome.WPF.FontAwesomeIcon.ChevronDown;
        }

        private void BtnSetting_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnSetting);
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnLogout);
        }

        //control buttons appearance
        #region menu button appearance
        private void ChangeButtonColors(Button button)
        {

            foreach (Button btn in buttons)
            {
                btn.MouseEnter -= Button_MouseEnter;
                btn.MouseLeave -= Button_MouseLeave;

                if (btn.Name != button.Name)
                { 
                    btn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(ColorsClass.NormalColor));
                    btn.Foreground = Brushes.White;
                }
                else
                {
                    if (button.Name ==  BtnApplicationListApproved.Name || button.Name == BtnApplicationListIncomplete.Name || button.Name == BtnApplicationListRejected.Name)
                    {
                        btn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#fa9646"));
                        btn.Foreground = Brushes.White;
                    }
                    else if(button.Name == BtnDebitCardIssueApproved.Name || button.Name == BtnDebitCardIssueIncomplete.Name || button.Name == BtnDebitCardIssueRejected.Name)
                    {
                        btn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#fa9646"));
                        btn.Foreground = Brushes.White;
                    }
                    else
                    {
                        btn.Background = Brushes.White;
                        btn.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
                    }
                    
                }

                btn.MouseEnter += Button_MouseEnter;
                btn.MouseLeave += Button_MouseLeave;
            }

            button.IsEnabled = false;
            foreach (Button btn in buttons)
            {
                if (btn != button)
                {
                    btn.IsEnabled = true;
                }
                if(button == BtnApplicationListRejected || button == BtnApplicationListIncomplete || button == BtnApplicationListApproved)
                {
                    BtnApplicationList.Background = Brushes.White;
                    BtnApplicationList.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
                }
                if (button == BtnDebitCardIssueRejected || button == BtnDebitCardIssueIncomplete || button == BtnDebitCardIssueApproved)
                {
                    BtnDebitCardIssue.Background = Brushes.White;
                    BtnDebitCardIssue.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
                }

            }
            BtnApplicationList.IsEnabled = true;
            BtnDebitCardIssue.IsEnabled = true;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                if(btn.Background != Brushes.White)
                {
                    btn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E36616"));
                    btn.Foreground = Brushes.White;
                }
               
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Button btn && !btn.IsFocused)
            {
                if (btn.Background != Brushes.White)
                {
                    btn.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
                    btn.Foreground = Brushes.White;
                }
                
            }
        }

        #endregion 

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnApplicationListApproved_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnApplicationListApproved);
            //application list table show
            GrdDashMain.Children.Clear();
            //load DashBoardContent user control
            ApplicationList_completed applicationList = new ApplicationList_completed();
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(applicationList);
            });
        }

        private void BtnApplicationListIncomplete_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnApplicationListIncomplete);


            //application list table show
            GrdDashMain.Children.Clear();
            //load DashBoardContent user control
            ApplicationList_incompleted applicationList = new ApplicationList_incompleted();
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(applicationList);
            });
        }

        private void BtnApplicationListRejected_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnApplicationListRejected);


            //application list table show
            GrdDashMain.Children.Clear();
            //load DashBoardContent user control
            ApplicationList_rejected applicationList = new ApplicationList_rejected();
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(applicationList);
            });

        }

        private void BtnDebitCardIssueApproved_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnDebitCardIssueApproved);

            //application list table show
            GrdDashMain.Children.Clear();
            //load DashBoardContent user control
            DebitCardList_complete applicationList = new DebitCardList_complete();
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(applicationList);
            });
        }

        private void BtnDebitCardIssueIncomplete_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnDebitCardIssueIncomplete);

            //application list table show
            GrdDashMain.Children.Clear();
            //load DashBoardContent user control
            DebitCardList_incomplete applicationList = new DebitCardList_incomplete();
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(applicationList);
            });
        }

        private void BtnDebitCardIssueRejected_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnDebitCardIssueRejected);

            //application list table show
            GrdDashMain.Children.Clear();
            //load DashBoardContent user control
            DebitCardList_rejected applicationList = new DebitCardList_rejected();
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(applicationList);
            });
        }
        
        private void BtnDailyReport_Click(object sender, RoutedEventArgs e)
        {
            ChangeButtonColors(BtnDailyReport);

            //application list table show
            GrdDashMain.Children.Clear();
            //load DashBoardContent user control
            DailyReportList applicationList = new DailyReportList();
            this.Dispatcher.Invoke(() =>
            {
                GrdDashMain.Children.Add(applicationList);
            });
        }
    }
}
