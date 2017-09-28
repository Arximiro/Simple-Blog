using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SimpleBlog.ViewModels;

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


        // This is model binding. It takes in an AuthLogin object that is generated via the post method of the other Login action.
        // It allows us to pass data from the controller to the view back to the controller.
        // When we execute the POST request, the ASP.Net modelbinder sees the model and tries to push as many of the posted parameters into it as possibl   e.

        
        // This HttpPost attribute lets ASP.Net know this action should only be executed by a POST request.
        [HttpPost]
        [Route("login")]    
        public ActionResult Login(AuthLogin form, string returnUrl) // Model binder will set returnUrl to whatever is in the address bar if it exists.
        {
            if (!ModelState.IsValid)
                return View(form);

            FormsAuthentication.SetAuthCookie(form.Username, true);
            // This is how we tell ASP.NET someone is who they say they are. It puts a cookie on the user's web browser.


            if (!String.IsNullOrWhiteSpace(returnUrl)) // This will redirect the user to a return url if present after login.
                return Redirect(returnUrl);

            return RedirectToAction("Index", "Posts");
            //return View(form);
        }

        
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToRoute("");
        }
    }
}