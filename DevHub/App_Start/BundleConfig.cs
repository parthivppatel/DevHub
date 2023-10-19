using System.Web;
using System.Web.Optimization;

namespace DevHub
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/js/jquery-min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/popper.min.js",
                      "~/Scripts/js/owl.carousel.min.js",
                      "~/Scripts/js/jquery.slicknav.js",
                      "~/Scripts/js/jquery.counterup.min.js",
                      "~/Scripts/js/waypoints.min.js",
                      "~/Scripts/js/form-validator.min.js",
                      "~/Scripts/js/contact-form-script.js",
                      "~/Scripts/js/main.js"
                      ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/line-icons.css",
                      "~/Content/css/owl.carousel.min.css",
                      "~/Content/css/owl.theme.default.css",
                      "~/Content/css/slicknav.min.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/main.css",
                      "~/Content/css/responsive.css"
                      ));
        }
    }
}
