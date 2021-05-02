using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebigenceApi.Models;
using WebigenceApi.Service;

namespace WebigenceApi.Controllers
{
    public class PhotosController : ApiController
    {
        private PhotoGet photoService;
        public PhotosController()
        {
            photoService = new PhotoGet();
        }

        // GET: Photos ** Returns whole photos responses
        public List<Photo> Get()
        {
            return (photoService.getModels());
        }

        // GET: Photos/"id" ** Returns specfic photo based on ID given
        public List<Photo> Get(int id)
        {
            return photoService.getModels().Where(obj => obj.albumId == id).ToList();
        }

    }
}
