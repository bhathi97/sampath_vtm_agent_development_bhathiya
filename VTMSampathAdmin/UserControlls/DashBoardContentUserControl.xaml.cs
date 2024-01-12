using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Popups;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for DashBoardContentUserControl.xaml
    /// </summary>
    public partial class DashBoardContentUserControl : UserControl
    {
        public DashBoardContentUserControl()
        {
            InitializeComponent();
            Dispatcher.Invoke(() =>
            {
                BorderToggleButton.Background = Brushes.DimGray;
                BtnOnOff.Content = "Offline";
            });
        }

        private void BtnOnOff_Click(object sender, RoutedEventArgs e)
        {
            Actions.IsOnline = !Actions.IsOnline;

            if (Actions.IsOnline)
            {
                BorderToggleButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F78020"));
                BtnOnOff.Content = "Online";
            }
            else
            {
                BorderToggleButton.Background = Brushes.DimGray;
                BtnOnOff.Content = "Offline";
            }

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
    }
}
