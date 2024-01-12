using Patagames.Pdf.Net;
using Patagames.Pdf.Net.EventArguments;
using System;
using System.Windows;
using VTMSampathAdmin.UserControlls;

namespace VTMSampathAdmin.Previews
{
    /// <summary>
    /// Interaction logic for MandateForm_setting.xaml
    /// </summary>
    public partial class MandateForm_setting : Window
    {
        public MandateForm_setting()
        {
            InitializeComponent();
            PdfDocument doc = PdfDocument.Load("C://Users//payme//Downloads//testMandate.pdf");
            PVMandateForm.Document = doc;

            //PVMandateForm.UpdateLayout();

        }

      
        private void ImgClose_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnRetrySignaturePanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSaveSignaturePanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancelSignaturePanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSharesettingPanel_Click(object sender, RoutedEventArgs e)
        {
            settingPanel.Visibility = Visibility.Collapsed;
            SignaturePanel.Visibility = Visibility.Visible;
        }

        private void BtnCancelsettingPanel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
