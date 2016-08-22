using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WeatherForecast
{
    public class BundleConfig 
    {
        public static void RegisterBundles(BundleCollection bundle)
        {
            bundle.Add(new ScriptBundle("~/bundles/Angular")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                 .IncludeDirectory("~/Scripts/Factories", "*.js")
                  .IncludeDirectory("~/Scripts/Directives", "*.js")
                .Include("~/Scripts/app.js"));
            BundleTable.EnableOptimizations = true;

        }
    }
}