using System;
using System.Configuration;

namespace GeolocationTestHarness.Configuration
{
    public class GeolocationTestHarnessConfiguraton
    {
        static GeolocationTestHarnessConfiguraton _configuration;

        public static GeolocationTestHarnessConfiguraton Current
        {
            get
            {
                return _configuration ??
                       (_configuration = new GeolocationTestHarnessConfiguraton());
            }
        }

        public bool GenerateDummyCookie
        {
            get
            {
                var value = ConfigurationManager.AppSettings["generateDummyCookie"];
                return value != null ? bool.Parse(value) : false;
            }
        }

        public string DummyCookieName
        {
            get { return ConfigurationManager.AppSettings["dummyCookieName"] ?? String.Empty; }
        }

        public int DummyCookieSize
        {
            get
            {
                var value = ConfigurationManager.AppSettings["dummyCookieSize"];
                return value != null ? int.Parse(value) : 0;
            }
        }
    }
}