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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Previews;
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for CaptureSignatureUserControl.xaml
    /// </summary>
    public partial class CaptureSignatureUserControl : UserControl
    {
        public CaptureSignatureUserControl()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if(Actions.Purpose == PurposeEnum.newApplication)
            {
                Actions.BackToPreviousUserController<SessionInputsUserControl>("4");
            }
            else if(Actions.Purpose == PurposeEnum.debitCard)
            {
                Actions.BackToPreviousUserController<SessionInputsUserControl_debitcard>("4");
            }

            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            //browse/gdarg and drop <- someway load the file 
            //then open the preview with that file 
            MandateForm_setting mandateForm_Setting = new MandateForm_setting();
            

            Effect = (Effect)Application.Current.Resources["BlurEffect"]; //add blur effect to the background
            mandateForm_Setting.ShowDialog();
            Effect = null;


        }
    }
}
