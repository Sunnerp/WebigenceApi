using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebigenceApi.Models;
using WebigenceApi.Repository;

namespace WebigenceApi.Service
{
    public class PhotoGet
    {
        private PhotoRepository photoRepository;

        public PhotoGet()
        {
            photoRepository = new PhotoRepository();
        }

        public List<Photo> getModels()
        {
            return photoRepository.getPhotos();
        }
    }
}