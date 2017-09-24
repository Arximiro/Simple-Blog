using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [Route("login")]
        public ActionResult Login()
        {
            return View();
        }
    }
}