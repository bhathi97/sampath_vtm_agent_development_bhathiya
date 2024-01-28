using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Popups;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for DashBoardContentUserControl.xaml
    /// </summary>
    public partial class DashBoardContentUserControl : UserControl
    {

        private TranslateTransform TranslateTransform;
        private DispatcherTimer StopDotTimer;
        private int MarginXOfDot;
        private int DotSpeed;

        public DashBoardContentUserControl()
        {
            InitializeComponent();

            InitializeTranslateTransform();

            InitializeTimer();

            MarginXOfDot = Convert.ToInt32(BorderOnOffDot.Margin.Left);
            DotSpeed = 8;



            Dispatcher.Invoke(() =>
            {
                BorderToggleButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CCCCCC"));
                LblOnOff.Content = "Offline"; LblOnOff.Foreground = Brushes.Black;

            });
        }

        private void BtnOnOff_Click(object sender, RoutedEventArgs e)
        {
            StopDotTimer.Start();
            Actions.IsOnline = !Actions.IsOnline;


            //testing pourpose only ---------------------------------------------------------------------------------------------------------
            NewCallRequestWindow newCallRequestWindow = new NewCallRequestWindow();
            newCallRequestWindow.ShowDialog();

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //testing 
            string jsonFilePath = @"C:\Users\payme\OneDrive\Desktop\data2.json";
            List<CardDetailsClass> cardList = JsonConvert.DeserializeObject<List<CardDetailsClass>>(File.ReadAllText(jsonFilePath));

            foreach (var card in cardList)
            {
                CardDetailsUserControl cardDetailsUserControl = new CardDetailsUserControl();
                cardDetailsUserControl.LblBranchName.Content = card.BranchName;
                cardDetailsUserControl.LblCardCount.Content = card.CardCount;
                cardDetailsUserControl.LblCardCenter.Content = card.CardCenter;

                int count = int.Parse(card.CardCount);

                int progress = (int)Math.Round(((decimal)count / 100) * 250);
                cardDetailsUserControl.BorderProgressBar.Width = progress;

                //need correct limits
                if (count >= 75)
                {
                    cardDetailsUserControl.BoderTopic.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#33CC33");
                    cardDetailsUserControl.LblCountStatus.Content = "Good";
                    cardDetailsUserControl.BorderProgressBar.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#33CC33");

                }
                else if(count < 75 && count > 30)
                {
                    cardDetailsUserControl.BoderTopic.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#3498DB");
                    cardDetailsUserControl.LblCountStatus.Content = "Normal";
                    cardDetailsUserControl.BorderProgressBar.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#3498DB");
                }
                else
                {
                    cardDetailsUserControl.BoderTopic.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF505A");
                    cardDetailsUserControl.LblCountStatus.Content = "Critical";
                    cardDetailsUserControl.BorderProgressBar.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF505A");
                }

                PnlLoadCards.Children.Add(cardDetailsUserControl);

            }

        }


        //toggle button animation
        private void InitializeTimer()
        {
            StopDotTimer = new DispatcherTimer();
            StopDotTimer.Interval = TimeSpan.FromMilliseconds(10);
            StopDotTimer.Tick += Timer_Tick;
        }

        private void InitializeTranslateTransform()
        {
            TranslateTransform = new TranslateTransform();
            BorderOnOffDot.RenderTransform = TranslateTransform;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (Actions.IsOnline)
            {
                TranslateTransform.X += DotSpeed;

                if (TranslateTransform.X + BorderOnOffDot.Width > GrdBtnContent.ActualWidth - (DotSpeed) - MarginXOfDot)
                {
                    StopDotTimer.Stop();
                }

                BorderToggleButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33CC33"));
                LblOnOff.Content = "Online";
                LblOnOff.Foreground = Brushes.White;

            }
            else
            {

                TranslateTransform.X -= DotSpeed;

                if (TranslateTransform.X == 0)
                {
                    StopDotTimer.Stop();
                }

                BorderToggleButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CCCCCC"));
                LblOnOff.Content = "Offline";
                LblOnOff.Foreground = Brushes.Black;
            }


        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            StopDotTimer.Tick -= Timer_Tick;
        }
    }
}
