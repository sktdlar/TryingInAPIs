using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ThreeAPIInUsing.Components.Dogs
{
    
    public class DogImage
    {
        public string message { get; set; }
        public BitmapImage GetPicture()
        {
            var image = WebRequest.Create(message).GetResponse().GetResponseStream();
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream ms = image as MemoryStream)
            {
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = image;
                bitmapImage.EndInit();
            }
            return bitmapImage;
        }
    }
}
