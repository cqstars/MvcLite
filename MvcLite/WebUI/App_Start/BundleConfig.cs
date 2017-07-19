using System.Web;
using System.Web.Optimization;

namespace WebUI
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/MVCAjax").Include("~/Scripts/jquery-3.1.0.js",
              "~/Scripts/jquery.unobtrusive-ajax.js",
              "~/Scripts/jquery.validate.js",
              "~/Scripts/jquery.validate.unobtrusive.js",
              "~/Scripts/jquery.msgProcess.js"));
            bundles.Add(new ScriptBundle("~/BootStrap/js").Include("~/Scripts/jquery-3.1.1.min.js", "~/Scripts/bootstrap.min.js",
                 "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Scripts/msgProcess.js"));
            bundles.Add(new StyleBundle("~/BootStarp/CSS").Include("~/Content/bootstrap.min.css", "~/Content/bootstrap-theme.min.css", "~/Content/MyStely.css"));
            bundles.Add(new ScriptBundle("~/Myjs/js").Include("~/Scripts/jquery-3.1.1.min.js",
               "~/Scripts/jquery.unobtrusive-ajax.min.js",
              "~/Scripts/jquery.validate.js",
              "~/Scripts/jquery.validate.unobtrusive.min.js",
              "~/Scripts/msgProcess.js"));
            bundles.Add(new StyleBundle("~/MyCss/CSS").Include("~/Content/HayTnStyle.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
