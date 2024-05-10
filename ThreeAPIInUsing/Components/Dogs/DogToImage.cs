using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ThreeAPIInUsing.Components.Dogs
{
    public class DogToImage
    {
        
        public string Url { get; set; }
        public BitmapImage GetPicture()
        {
            var image = WebRequest.Create(Url).GetResponse().GetResponseStream();
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
