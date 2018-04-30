using System.Web.Optimization;
using WebHelpers.Mvc5;

namespace Condominio.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Bundles/css")
                .Include("~/Content/css/bootstrap.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/bootstrap-select.min.css")
                .Include("~/Content/css/bootstrap-datepicker3.min.css")
                .Include("~/Content/css/font-awesome.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/icheck/blue.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/AdminLTE.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/alertifyjs/alertify.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/alertifyjs/themes/bootstrap.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/condominio.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/skins/skin-blue.css"));

            bundles.Add(new ScriptBundle("~/Bundles/js")
                .Include("~/Content/js/plugins/jquery/jquery-3.3.1.min.js")
                .Include("~/Content/js/plugins/bootstrap/bootstrap.min.js")
                .Include("~/Content/js/plugins/fastclick/fastclick.min.js")
                .Include("~/Content/js/plugins/slimscroll/jquery.slimscroll.min.js")
                .Include("~/Content/js/plugins/bootstrap-select/bootstrap-select.min.js")
                .Include("~/Content/js/plugins/moment/moment.min.js")
                .Include("~/Content/js/plugins/datepicker/bootstrap-datepicker.min.js")
                .Include("~/Content/js/plugins/icheck/icheck.min.js")
                .Include("~/Content/js/plugins/validator.min.js")
                .Include("~/Content/js/plugins/inputmask/jquery.inputmask.bundle.min.js")
                .Include("~/Content/js/adminlte.js")
                .Include("~/Content/js/init.js")
                .Include("~/Scripts/alertify.min.js")
                .Include("~/Content/js/main.js"));

            bundles.Add(new ScriptBundle("~/Bundles/js/apartamento")
                .Include("~/Content/js/apartamento.js"));

            bundles.Add(new ScriptBundle("~/Bundles/js/morador")
                .Include("~/Content/js/morador.js"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
