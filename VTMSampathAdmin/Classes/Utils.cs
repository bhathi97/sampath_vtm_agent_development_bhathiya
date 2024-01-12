using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace VTMSampathAdmin.Classes
{
    internal static class Utils
    {
        public static ImageSource BitmapToImageSource(Bitmap bitmap)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            var memoryStream = new MemoryStream();

            bitmap.Save(memoryStream, ImageFormat.Bmp);
            memoryStream.Seek(0, SeekOrigin.Begin);
            bitmapImage.StreamSource = memoryStream;
            bitmapImage.EndInit();
            return bitmapImage;
        }
    }
}
