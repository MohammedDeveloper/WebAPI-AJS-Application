using System.Web;
using System.Web.Optimization;

namespace GEP.Employee.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            /// adding bootstrap base library
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            /// adding angular js base library
            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                     "~/Scripts/angular.min.js",
                     "~/Scripts/ajs/modules/app.module.js"
                     ));
            
            /// adding angular js module specific libraries
            bundles.Add(new ScriptBundle("~/bundles/ajs-employee").Include(
                     "~/Scripts/ajs/services/employee/app.employee.service.js",
                     "~/Scripts/ajs/controllers/employee/app.employee.controller.js"
                     ));

            /// CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            /// set the optimizations as TRUE for bundling to improve performance
            BundleTable.EnableOptimizations = true;
        }
    }
}
