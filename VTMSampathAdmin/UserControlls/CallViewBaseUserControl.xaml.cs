using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace VTMSampathAdmin.UserControlls
{
    /// <summary>
    /// Interaction logic for CallViewBaseUserControl.xaml
    /// </summary>
    public partial class CallViewBaseUserControl : UserControl
    {
        //camera to screen
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public CallViewBaseUserControl()
        {
            InitializeComponent();
        }

        #region Camera
        private void InitializeCamera()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoSource.NewFrame += VideoSource_NewFrame;
                    videoSource.Start();
                }
                else
                {
                    MessageBox.Show("No camera devices found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check your camera and try again.");
            }
        }
        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            using (Bitmap newFrame = (Bitmap)eventArgs.Frame.Clone())
            {
                this.Dispatcher.Invoke(() =>
                {
                    ImgAgent.Source = Utils.BitmapToImageSource(newFrame);
                });

            }
        }

        #endregion

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
  
            Actions.GoToNewUserController<NICVerificationUserControl>("1");

        }

        private void BtnCall_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVideoOnOff_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReject_Click(object sender, RoutedEventArgs e)
        {

        }
    }




}
