using GeolocationTestHarness.Adapters;
using GeolocationTestHarness.Configuration;
using System.Configuration;
using System.Net;
using System.Web.Mvc;

namespace GeolocationTestHarness.Controllers
{
    public class HomeController : Controller
    {
        GeolocationTestHarnessConfiguraton config = GeolocationTestHarnessConfiguraton.Current;

        public HomeController()
        {
            //_cookiesAdapter = new CookiesAdapter(Request.Cookies, Response.Cookies);
        }

        // GET: Home
        public ActionResult Index()
        {
            var cookiesAdapter = new CookiesAdapter(Request.Cookies, Response.Cookies);

            if (config.GenerateDummyCookie)
                cookiesAdapter.GenerateDummyCookies(config.DummyCookieName, config.DummyCookieSize);

            return View();
        }

        [AllowAnonymous]
        public HttpStatusCodeResult Ping()
        {
            return new HttpStatusCodeResult(HttpStatusCode.NoContent);
        }
    }
}