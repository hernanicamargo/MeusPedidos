using System.Web;
using System.Web.Optimization;

namespace MeusPedidos.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/assets/global/plugins/backstretch/jquery.backstretch.min.js",
                        //"~/assets/global/plugins/jquery.blockui.min.js",
                        "~/assets/global/scripts/jquery.barrating.js",
                        "~/assets/global/plugins/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        //"~/assets/global/plugins/jquery-validation/js/additional-methods.min.js",
                        "~/assets/global/plugins/jquery-validation/js/jquery.validate.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(                        
                        "~/Scripts/modernizr-*"));



            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        //"~/assets/global/scripts/app.min.js",
                        "~/assets/pages/scripts/login-5.min.js",
                        //"~/assets/global/plugins/js.cookie.min.js",
                        //"~/assets/global/plugins/select2/js/select2.full.min.js",
                        //"~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                        "~/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                        "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                 "~/assets/global/css/components.min.css",
                 "~/assets/global/css/plugins.min.css",
                 "~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                 "~/assets/global/plugins/font-awesome/css/css.css",
                 "~/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                 //"~/assets/global/plugins/select2/css/select2-bootstrap.min.css",
                 //"~/assets/global/plugins/select2/css/select2.min.css",
                 "~/assets/global/css/jquerysctipttop.css",
                 "~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                 "~/assets/global/css/rating.css",
                 "~/assets/pages/css/login-5.min.css"));
        }
    }
}
