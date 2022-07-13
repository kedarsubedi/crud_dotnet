using Microsoft.AspNetCore.Mvc;
using mySqlCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mySqlCrud.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult Index()
        {
            MusicStoreContext context = HttpContext.RequestServices.GetService(typeof(mySqlCrud .Models.MusicStoreContext)) as MusicStoreContext;

            return View(context.GetAllAlbums());
        }
    }
}
