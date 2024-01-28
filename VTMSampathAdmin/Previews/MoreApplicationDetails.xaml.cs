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
using VTMSampathAdmin.Classes;
using VTMSampathAdmin.Classes.BackendDataLoading;

namespace VTMSampathAdmin.Previews
{
    /// <summary>
    /// Interaction logic for CompletedApplication.xaml
    /// </summary>
    public partial class MoreApplicationDetails : Window
    {
        public EntityForApplicationButtonHandle Entity { get; set; }

        public MoreApplicationDetails(EntityForApplicationButtonHandle entity)
        {
            InitializeComponent();
            Entity = entity;


            /*//testing
            ImgCustomer.ImageSource = new BitmapImage(new Uri("C://Users//payme//Downloads//userrr.jpg"));

            //Imgrate_2.Source = new BitmapImage(new Uri("/Images/star_0.png"));
            //load stars using a switch
            RateToStars(4);


            //testing
            ImgNicFront.Source = new BitmapImage(new Uri("C://Users//payme//Downloads//NICF.png"));*/
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                FetchBackendData().Wait(TimeSpan.FromMilliseconds(500));




            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task FetchBackendData()
        {
            try
            {
                if (Entity.ApplicationStatus == "complete")
                {

                    string url = Actions.IP + @"Application/view-complete-applications/" + Entity.Id;
                    ApplicationData applicationData = new ApplicationData();
                    CompleteApplicationDetailsClass data = await applicationData.LoadCompletedApplicationForId(url);

                    //customer Rating Show
                    int customerRate = int.TryParse(data.Data.CustomerRate, out var rate) ? rate : 0;
                    RateToStars(customerRate);

                    LblNic.Content = data.Data.NicNumber;
                    LblCustNic.Content = data.Data.NicNumber;
                    LblAccount.Content = data.Data.AccountNumber;
                    LblMobile.Content = data.Data.MobileNumber;

                    LblStatus.Content = data.Data.CustomerStatus ? "New Customer" : "Existing Customer";

                    LblIsIssue.Content = data.Data.DebitCardStatus ? "Issued" : "";

                    //have to implement

                    //download file grid -> visible
                    GrdComplete.Visibility = Visibility.Visible;
                    GrdRejected.Visibility = Visibility.Collapsed;

                }
                else if(Entity.ApplicationStatus == "rejected")
                {
                    string url = Actions.IP + @"Application/view-rejected-applications/" + Entity.Id;
                    ApplicationData applicationData = new ApplicationData();
                    RejectedApplicationDetailsClass data = await applicationData.LoadRejectedApplicationForId(url);

                    //customer Rating Show
                    int customerRate = int.TryParse(data.Data.CustomerRate, out var rate) ? rate : 0;
                    RateToStars(customerRate);

                    LblNic.Content = data.Data.NicNumber;
                    LblCustNic.Content = data.Data.NicNumber;
                    LblAccount.Content = data.Data.AccountNumber;
                    LblMobile.Content = data.Data.MobileNumber;
                    LblStatus.Content = data.Data.CustomerStatus ? "New Customer" : "Existing Customer";
                    TbRejectedReason.Text = data.Data.RejectReason;


                    //have to implement


                    GrdComplete.Visibility = Visibility.Collapsed;
                    GrdRejected.Visibility = Visibility.Visible;
                   
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void RateToStars(int rate)
        {
            switch (rate)
            {
                case 1:
                    Imgrate_1.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_2.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    Imgrate_3.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    Imgrate_4.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    Imgrate_5.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    break;

                case 2:
                    Imgrate_1.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_2.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_3.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    Imgrate_4.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    Imgrate_5.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    break;

                case 3:
                    Imgrate_1.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_2.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_3.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_4.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    Imgrate_5.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    break;

                case 4:
                    Imgrate_1.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_2.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_3.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_4.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_5.Source = new BitmapImage(new Uri("/Images/star_0.png", UriKind.Relative));
                    break;

                case 5:
                    Imgrate_1.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_2.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_3.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_4.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    Imgrate_5.Source = new BitmapImage(new Uri("/Images/star_1.png", UriKind.Relative));
                    break;

            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnDownload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDownMandateForm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDownDebitCardForm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDownOtherForms_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
