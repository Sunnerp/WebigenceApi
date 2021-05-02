using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using WebigenceApi.Models;

namespace WebigenceApi.Repository
{
    public class PhotoRepository
    {
        private List<Photo> photos;

        public PhotoRepository()
        {
            string json = getJson();
            photos = JsonConvert.DeserializeObject<List<Photo>>(json);
        }
        public List<Photo> getPhotos()
        {
            return photos;
        }
        private string getJson()
        {
            string html = string.Empty;
            string url = @"http://jsonplaceholder.typicode.com/photos";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return html;

        }

    }
}