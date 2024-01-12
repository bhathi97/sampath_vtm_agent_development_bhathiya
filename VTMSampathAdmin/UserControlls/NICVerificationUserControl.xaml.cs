﻿using System;
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
    /// Interaction logic for NICVerificationUserControl.xaml
    /// </summary>
    public partial class NICVerificationUserControl : UserControl
    {
        public NICVerificationUserControl()
        {
            InitializeComponent();
            TbNicInput.Focus();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            CustomerStatusUserControl customerStatusUserControl = new CustomerStatusUserControl();
            UserControlsHandlerClass.AddUserControl("2", customerStatusUserControl);

            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            CallViewBaseUserControl callViewBaseUserControl = (CallViewBaseUserControl)UserControlsHandlerClass.FindVisualChild(mainWindow, typeof(CallViewBaseUserControl));

            if (callViewBaseUserControl != null)
            {
                callViewBaseUserControl.Dispatcher.Invoke(() =>
                {
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Clear();
                    callViewBaseUserControl.GrdCallInputsContainer.Children.Add(customerStatusUserControl);
                });
            }

            
           
        }

        private void BtnShowGuidance_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnScan_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
