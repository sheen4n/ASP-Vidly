using System.Web;
using System.Web.Optimization;

namespace VidlyASP
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/lib/bootbox.js/bootbox.min.js",
                        "~/lib/dataTables/js/jquery.dataTables.min.js",
                        "~/Scripts/typeahead.bundle.min.js",
                        "~/Scripts/toastr.min.js",
                        "~/lib/dataTables/js/dataTables.bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/lib/dataTables/css/dataTables.bootstrap.min.css",
                      "~/Content/typeahead.css",
                      "~/Content/toastr.min.css",
                      "~/Content/site.css"));
        }
    }
}
