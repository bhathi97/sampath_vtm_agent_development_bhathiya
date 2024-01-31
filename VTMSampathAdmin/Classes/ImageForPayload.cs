using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VTMSampathAdmin.Classes
{
    public class ImageForPayload
    {
        public string FileType { get; set; }
        public string Base64String { get; set; }

        public ImageForPayload(Image image)
        {
            string imagePath = image.Source.ToString();
            FileType = imagePath.Substring(imagePath.LastIndexOf('.') + 1);


            //hace to implement
            if (Uri.TryCreate(imagePath, UriKind.Absolute, out var uriResult) && uriResult.Scheme == Uri.UriSchemeFile)
            {
                imagePath = uriResult.LocalPath;
            }
            Base64String = ConvertImageToBase64(imagePath);

        }

        private string ConvertImageToBase64(string imagePath)
        {
            byte[] imageArray = File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageArray);
        }

        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
