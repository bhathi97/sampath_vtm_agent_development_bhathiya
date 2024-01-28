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
    /// Interaction logic for DRPChaeckUserControl.xaml
    /// </summary>
    public partial class DRPChaeckUserControl : UserControl
    {
        public DRPChaeckUserControl()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        { 
            Actions.BackToPreviousUserController<SessionInputsUserControl>("4");
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRunDrp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
