using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GeolocationTestHarness.Controllers
{
    [Authorize]
    public class SecurityController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SecurityController));

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public RedirectResult CustomSignout()
        {
            if (logger.IsDebugEnabled)
                logger.Debug("Signout Module: custom signout handled");

            var ticks = DateTime.Now.Ticks;
            return new RedirectResult("~/2fa_signout?" + ticks.ToString());
        }
    }
}