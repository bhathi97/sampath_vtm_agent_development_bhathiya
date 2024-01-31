using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace VTMSampathAdmin.Classes
{
    public static class ConvertFromBase64
    {
        public static ImageSource ConvertBase64ToImage(string base64String)
        {
            try
            {
                JsonInformation information = JsonConvert.DeserializeObject<JsonInformation>(base64String);

                string fileType = information.FileType;

                if(fileType == "png" || fileType == "jpg")
                {
                    byte[] bytes = Convert.FromBase64String(information.Base64String);

                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = new MemoryStream(bytes);
                    bitmap.EndInit();

                    return bitmap;
                }


               
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }




    }

    public class JsonInformation
    {
        public string FileType { get; set; }
        public string Base64String { get; set; }

    }


}
