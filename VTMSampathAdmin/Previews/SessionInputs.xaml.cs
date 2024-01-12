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

namespace VTMSampathAdmin.Previews
{
    /// <summary>
    /// Interaction logic for SessionInputs.xaml
    /// </summary>
    public partial class SessionInputs : Window
    {
        private Point origin;
        private Point start;

        public SessionInputs()
        {
            InitializeComponent();


            //
            TransformGroup transformGroup = new TransformGroup();

            ScaleTransform scaleTransform = new ScaleTransform();
            transformGroup.Children.Add(scaleTransform);

            TranslateTransform translateTransform = new TranslateTransform();
            transformGroup.Children.Add(translateTransform);

            RotateTransform rotateTransform = new RotateTransform();
            transformGroup.Children.Add(rotateTransform);

            ImgPreview.RenderTransform = transformGroup;



            //testing
            ImgNicFront.Source = new BitmapImage(new Uri("C://Users//payme//Downloads//NICF.png"));
            ImgNicBack.Source = new BitmapImage(new Uri("C://Users//payme//Downloads//NICR.png"));
            ImgCard.Source = new BitmapImage(new Uri("C://Users//payme//Downloads//VISAE.png"));


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        //preview buttons
        private void ImgPreview_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    var transform = (ScaleTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is ScaleTransform);

                    double zoom = e.Delta > 0 ? .2 : -.2;
                    transform.ScaleX += zoom;
                    transform.ScaleY += zoom;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void ImgPreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    ImgPreview.CaptureMouse();
                    var translateTransform = (TranslateTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is TranslateTransform);
                    start = e.GetPosition(border);
                    origin = new Point(translateTransform.X, translateTransform.Y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgPreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    ImgPreview.ReleaseMouseCapture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void ImgPreview_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    if (!ImgPreview.IsMouseCaptured) return;

                    var translateTransform = (TranslateTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is TranslateTransform);
                    Vector v = start - e.GetPosition(border);
                    translateTransform.X = origin.X - v.X;
                    translateTransform.Y = origin.Y - v.Y;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnZoomIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    var transform = (ScaleTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is ScaleTransform);
                    transform.ScaleX += 0.2;
                    transform.ScaleY += 0.2;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnZoomOut_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (ImgPreview.Source != null)
                {
                    var transform = (ScaleTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is ScaleTransform);
                    transform.ScaleX -= 0.2;
                    transform.ScaleY -= 0.2;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void BtnRotate_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (ImgPreview.Source != null)
                {
                    var transformGroup = (TransformGroup)ImgPreview.RenderTransform;
                    var rotateTransform = (RotateTransform)transformGroup.Children.First(c => c is RotateTransform);

                    double centerX = ImgPreview.ActualWidth / 2;
                    double centerY = ImgPreview.ActualHeight / 2;

                    rotateTransform.CenterX = centerX;
                    rotateTransform.CenterY = centerY;
                    rotateTransform.Angle += 90;

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

        private void ImgNicFront_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if(ImgNicFront.Source != null)
                {
                    Uri newImageUri = ((BitmapImage)ImgNicFront.Source)?.UriSource;
                    BitmapImage newImage = new BitmapImage(newImageUri);
                    if (ImgPreview.Source != null)
                    {
                        ImgPreview.Source = null;
                    }
                    ImgPreview.Source = newImage;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImgNicBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ImgNicBack.Source != null)
                {
                    Uri newImageUri = ((BitmapImage)ImgNicBack.Source)?.UriSource;
                    BitmapImage newImage = new BitmapImage(newImageUri);
                    if (ImgPreview.Source != null)
                    {
                        ImgPreview.Source = null;
                    }
                    ImgPreview.Source = newImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImgCard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ImgCard.Source != null)
                {
                    Uri newImageUri = ((BitmapImage)ImgCard.Source)?.UriSource;
                    BitmapImage newImage = new BitmapImage(newImageUri);
                    if (ImgPreview.Source != null)
                    {
                        ImgPreview.Source = null;
                    }
                    ImgPreview.Source = newImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //-----------


    }
}
