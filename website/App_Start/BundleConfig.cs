using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using Umbraco.Core.Logging;

namespace website.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/assets/styles/bundled.css"));


            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include("~/assets/scripts/3rdparty/jquery-2.2.0.min.js")
                .Include("~/assets/scripts/3rdparty/TweenMax.min.js")
                .Include("~/assets/scripts/menu/menu.js")
                .Include("~/assets/scripts/main.js")
                );

            LogHelper.Info<string>("Bundles Loaded");

            //Comment this out to control this setting via web.config compilation debug attribute
            //BundleTable.EnableOptimizations = true;
        }
    }
}