using Patagames.Pdf.Net;
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
    /// Interaction logic for MandateForm_signature.xaml
    /// </summary>
    public partial class MandateForm_signature : Window
    {
        public MandateForm_signature()
        {
            InitializeComponent();
            PdfDocument doc = PdfDocument.Load("C://Users//payme//Downloads//testMandate.pdf");
            PVMandateForm.Document = doc;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRetry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ImgClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
