using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using WebigenceApi.Models;

namespace WebigenceApi.Repository
{
    public class AlbumRepository
    {
        private List<Album> albums;

        public AlbumRepository()
        {
            string json = getJson();

            albums = JsonConvert.DeserializeObject<List<Album>>(json);
        }

        public List<Album> getAlbums()
        {
            return albums;
        }

        private string getJson()
        {
            string html = string.Empty;
            string url = @"http://jsonplaceholder.typicode.com/albums";

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