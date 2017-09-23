using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return Content("Hello World");
            //return View();
        }
    }
}