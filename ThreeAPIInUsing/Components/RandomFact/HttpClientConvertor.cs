using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using ThreeAPIInUsing.Components.Dogs;
using ThreeAPIInUsing.Components.Gender;

namespace ThreeAPIInUsing.Components.RandomFact
{
    public class HttpClientConvertor
    {
        public CatFact GetCatFact()
        {
            var url = "https://catfact.ninja/fact";
            return ConvertFromJson<CatFact>(MakeRequest(url));
        }
        public DogImage DogToImage()
        {
            var url = "https://dog.ceo/api/breeds/image/random";
            return ConvertFromJson<DogImage>(MakeRequest(url));
        }
        public AgeFromName AgeFromName(string name)
        {
            var url = @"https://api.agify.io/?name=" + name;
            return AgeConvertFromJson(MakeRequest(url));
        }
        private T ConvertFromJson<T>(string Json)
        {
            T? result = JsonSerializer.Deserialize<T>(Json);
            return result;
        }
        private AgeFromName AgeConvertFromJson(string Json)
        {
            var result = JsonSerializer.Deserialize<AgeFromName>(Json);
            return result;
        }
        private string MakeRequest(string url)
        {
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var HttpStatusCode = (response as HttpWebResponse).StatusCode;
            if(HttpStatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(HttpStatusCode.ToString());
                return "";
            }
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using(var streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("Windows-1251")))
            {
                string result = streamReader.ReadToEnd();
                return result;
            }
        }
    }
}
