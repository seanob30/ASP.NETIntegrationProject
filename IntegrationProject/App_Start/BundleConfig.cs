using System;
using System.Web;
using System.Web.Optimization;
using Newtonsoft.Json;

namespace IntegrationProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            TimeSpan sevenAM = new TimeSpan(07, 0, 0);
            TimeSpan sixPM = new TimeSpan(18, 0, 0);

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

           
            if (DateTime.Now.TimeOfDay >= sevenAM && DateTime.Now.TimeOfDay < sixPM)
            {
                bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/respond.js"));

                bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap-flatly.css",
                    "~/Content/site.css"));
            }
            else
            {
                bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/respond.js"));

                bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/Content/bootstrap-darkly.css",
                   "~/Content/site.css"));
            }
        }
    }
}
