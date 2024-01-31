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
using VTMSampathAdmin.Classes.JsonDataToBackend;
using VTMSampathAdmin.VTM;

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for CaptureCustomerImageUserControl.xaml
    /// </summary>
    public partial class CaptureCustomerImageUserControl : UserControl
    {
        public CaptureCustomerImageUserControl()
        {
            InitializeComponent();
            ImgCustImage.Source = new BitmapImage(new Uri(@"C:\Users\payme\Downloads\userrr.jpg"));
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            ImageForPayload imagePayloadCustomerImage = new ImageForPayload(ImgCustImage);
            string jsonStringOfCustomerImage = imagePayloadCustomerImage.ToJsonString();
            ApplicationTableRecord.ApplicationInstance.CustomerImage = jsonStringOfCustomerImage;

            if (ImgCustImage.Source != null)
            {
                Actions.AccessAndChangeCheckCircleOfUserControl<SessionInputsUserControl>("4", "BtnCaptureCustomerIcon");
            }

            Actions.BackToPreviousUserController<SessionInputsUserControl>("4");
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Actions.BackToPreviousUserController<SessionInputsUserControl>("4");
        }

        private void BtnCapture_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
