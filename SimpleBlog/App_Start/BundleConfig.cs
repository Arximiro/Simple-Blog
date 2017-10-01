﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SimpleBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/admin.css"));

            bundles.Add(new StyleBundle("~/styles")
               .Include("~/content/styles/bootstrap.css")
               .Include("~/content/styles/site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
               .Include("~/scripts/jquery-3.2.1.js")
               .Include("~/scripts/jquery.validate.js")
               .Include("~/scripts/jquery.validate.unobtrusive.js")
               .Include("~/scripts/bootstrap.js")
               .Include("~/areas/admin/scripts/forms.js"));

            // It's important the scripts are loaded in this order due to dependencies. Jq val uno depends on Jq val, which depends on Jq. BS depends on Jq etc.

            bundles.Add(new ScriptBundle("~/scripts")
               .Include("~/scripts/jquery-3.2.1.js")
               .Include("~/scripts/jquery.validate.js")
               .Include("~/scripts/jquery.validate.unobtrusive.js")
               .Include("~/scripts/bootstrap.js"));
        }
    }
}