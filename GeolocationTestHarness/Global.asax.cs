using log4net;
using SpencerStuart.Common.Security.Web.Signout;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GeolocationTestHarness
{
    public class Global : System.Web.HttpApplication
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(HttpApplication));

        protected void Application_Start(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            BundleTable.Bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
        }

        protected void Application_BeginRequest()
        {
            if (!String.IsNullOrEmpty(HttpContext.Current.Request.QueryString["inject2FAHeader"]) && HttpContext.Current.Request.Headers["X-SSI-User-Location"] == null)
                HttpContext.Current.Request.Headers.Add("X-SSI-User-Location", "");
        }

        protected void SignoutModule_OnTwoFASignoutFailure(object sender, TwoFASignoutFailureEventArgs e)
        {
            if (logger.IsDebugEnabled)
                logger.Debug("Signout Module: custom app 2fa failure handler");
        }
    }
}