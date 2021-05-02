using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebigenceApi.Models;
using WebigenceApi.Repository;

namespace WebigenceApi.Service
{
    public class AlbumGet
    {
        private AlbumRepository albumRepository;

        public AlbumGet()
        {
            albumRepository = new AlbumRepository();
        }

        public List<Album> getModels()
        {
            return albumRepository.getAlbums();
        }
    }
}