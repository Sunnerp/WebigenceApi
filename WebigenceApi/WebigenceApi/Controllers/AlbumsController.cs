using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebigenceApi.Models;
using WebigenceApi.Service;

namespace WebigenceApi.Controllers
{
    public class AlbumsController : ApiController
    {
        private AlbumGet albumService;

        public AlbumsController()
        {
            albumService = new AlbumGet();
        }

        // GET: api/Albums ** Returns whole album responses
        public List<Album> Get()
        {
            return (albumService.getModels());
        }

        // GET: api/Albums/5 ** Returns specfic album based on ID given
        public List<Album> Get(int id)
        {
            return albumService.getModels().Where(obj => obj.userId == id).ToList();
        }
    }
}
