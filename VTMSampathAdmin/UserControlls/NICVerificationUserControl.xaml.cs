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
    /// Interaction logic for NICVerificationUserControl.xaml
    /// </summary>
    public partial class NICVerificationUserControl : UserControl
    {
        public NICVerificationUserControl()
        {
            InitializeComponent();
            TbNicInput.Focus();


            //testing----------------------------
            //ImgNICFront.Source = new BitmapImage(new Uri("/Images/NICF.png", UriKind.Relative));
            ImgNICFront.Source = new BitmapImage(new Uri(@"C:\Users\payme\Downloads\NICF.png"));
            ImgNICRear.Source = new BitmapImage(new Uri(@"C:\Users\payme\Downloads\NICR.png"));


        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            //only for testing
            ImageForPayload imagePayloadNicFront = new ImageForPayload(ImgNICFront);
            string jsonStringOfNicFront = imagePayloadNicFront.ToJsonString();

            ImageForPayload imageForPayloadNicRear = new ImageForPayload(ImgNICRear);
            string jsonStringOfNicRear = imageForPayloadNicRear.ToJsonString();



            ApplicationTableRecord.ApplicationInstance.NicFrontImage = jsonStringOfNicFront;
            ApplicationTableRecord.ApplicationInstance.NicRearImage = jsonStringOfNicRear;

            //laod twith sample data
            /*string jsonDataForNewApplication = ApplicationTableRecord.ApplicationInstance.ToJsonString();



            string url = Actions.IP + @"Application/create-new-application";

            CreateNewRecord newRecord = new CreateNewRecord();
            _ = newRecord.CreateNewApplicationRecord(url, jsonDataForNewApplication);*/












            //--------------------------------------------------------------------------------------
            //this is the real code
            Actions.GoToNewUserController<CustomerStatusUserControl>("2");
            //
        }

        private void BtnShowGuidance_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnScan_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
