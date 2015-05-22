using System.Web;
using System.Web.Optimization;

namespace GeolocationTestHarness
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*", "~/Scripts/quest*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/quest.css",
                      "~/Content/quest1.css",
                      "~/Content/quest2.css",
                      "~/Content/quest3.css",
                      "~/Content/bootstrap-responsive.css"));

            //Uses geolocation
            //const string geolocationUri = "http://news.bbc.co.uk/";

            //bundles.Add(new ScriptBundle("~/bundles/geolocated_jquery", geolocationUri).Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/geolocated_jqueryval", geolocationUri).Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/geolocated_modernizr", geolocationUri).Include(
            //            "~/Scripts/modernizr-*", "~/Scripts/quest*"));

            //bundles.Add(new ScriptBundle("~/bundles/geolocated_bootstrap", geolocationUri).Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/geolocated_css", geolocationUri).Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css",
            //          "~/Content/quest.css",
            //          "~/Content/quest1.css",
            //          "~/Content/quest2.css",
            //          "~/Content/quest3.css",
            //          "~/Content/bootstrap-responsive.css"));
        }
    }
}
