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

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for SuccessDebitCardIssuanceUserControl.xaml
    /// </summary>
    public partial class SuccessUserControl1 : UserControl
    {
        private int _msgNumber;
        public SuccessUserControl1(int msgNumber = 1)
        {
            InitializeComponent();
            _msgNumber = msgNumber;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (_msgNumber == 1)
            {
                TxtMassege.Text = "Service Provision Successful!";
            }
            else if(_msgNumber == 2)
            {
                TxtMassege.Text = "Debit Card Issuance Successful!";
            }
            else
            {
                TxtMassege.Text = "error";
            }
        }
        private void BtnRateUs_Click(object sender, RoutedEventArgs e)
        {

        }



        
    }
}
