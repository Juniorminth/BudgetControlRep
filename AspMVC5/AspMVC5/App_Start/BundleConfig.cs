using System;
using System.Web;
using System.Web.Optimization;

namespace AspMVC5
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundle)
        {
            bundle.Add(new ScriptBundle("~/bundles/AngularScripts")
                .IncludeDirectory("~/Scripts/Controller","*.js")
                .Include("~/Scripts/app.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}