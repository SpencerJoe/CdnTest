using System;
using System.Collections;
using System.Text;
using System.Web;

namespace GeolocationTestHarness.Adapters
{
    public class CookiesAdapter : ICookiesAdapter
    {
        private readonly HttpCookieCollection _requestCookies;
        private readonly HttpCookieCollection _responseCookies;

        public CookiesAdapter(HttpCookieCollection requestCookies, HttpCookieCollection responseCookies)
        {
            _requestCookies = requestCookies;
            _responseCookies = responseCookies;
        }

        public ICollection GetRequestCookies()
        {
            return _requestCookies;
        }

        public ICollection SetResponseCookies(HttpCookie newCookie)
        {
            _responseCookies.Add(newCookie);
            return _responseCookies;
        }

        public void GenerateDummyCookies(string cookieName, int cookieSizeInKb)
        {
            const string oneKb = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwx";

            var sb = new StringBuilder("");

            for (int i = 1; i <= cookieSizeInKb; i++)
            {
                sb.Append(oneKb);
                if (i % 4 == 0)
                {
                    _responseCookies.Add(new HttpCookie(cookieName + i, sb.ToString()) { Expires = DateTime.Now.AddDays(365) });
                    sb.Clear();
                }
            }

        }
    }
}