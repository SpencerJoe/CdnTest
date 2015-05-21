using System.Collections;
using System.Web;

namespace GeolocationTestHarness.Adapters
{
    public interface ICookiesAdapter
    {
        ICollection GetRequestCookies();
        ICollection SetResponseCookies(HttpCookie cookie);
        void GenerateDummyCookies(string cookieName, int cookieSizeInKb);
    }
}