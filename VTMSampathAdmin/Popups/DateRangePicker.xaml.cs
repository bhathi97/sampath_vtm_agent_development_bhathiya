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

namespace VTMSampathAdmin.Popups
{
    /// <summary>
    /// Interaction logic for DateRangePicker.xaml
    /// </summary>
    public partial class DateRangePicker : Window
    {
        public DateRangePicker()
        {
            InitializeComponent();
            CalanderFrom.SelectedDatesChanged += CalanderFrom_SelectedDatesChanged;
            CalanderTo.SelectedDatesChanged += CalanderTo_SelectedDatesChanged;
            LblFrom.Content = DateTime.Now.ToString("yyyy/MM/dd");
            LblTo.Content = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void ImgClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CalanderFrom_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CalanderFrom.SelectedDate.HasValue)
            {
                LblFrom.Content = CalanderFrom.SelectedDate.Value.ToString("yyyy/MM/dd");
            }
            else
            {
                LblFrom.Content = DateTime.Now.ToString("yyyy/MM/dd");
            }
        }

        private void CalanderTo_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CalanderTo.SelectedDate.HasValue)
            {
                LblTo.Content = CalanderTo.SelectedDate.Value.ToString("yyyy/MM/dd");
            }
            else
            {
                LblTo.Content = DateTime.Now.ToString("yyyy/MM/dd");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CalanderFrom.SelectedDatesChanged -= CalanderFrom_SelectedDatesChanged;
            CalanderTo.SelectedDatesChanged -= CalanderTo_SelectedDatesChanged;
        }
    }
}
