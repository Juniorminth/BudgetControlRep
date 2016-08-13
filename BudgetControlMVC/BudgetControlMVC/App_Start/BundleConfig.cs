using System.Web;
using System.Web.Optimization;

namespace BudgetControlMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
         
            bundles.Add(new StyleBundle("~/Content/css").Include(                     
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/AngularFrameWork")
                .IncludeDirectory("~/Scripts/Angular", "*.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
