using System.Web;
using System.Web.Optimization;

namespace FinanzasPrograAvanzada
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios.  De esta manera estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/StaticFiles/js/jquery.js",
                "~/StaticFiles/js/popper.js",
                "~/StaticFiles/js/bootstrap.js",
                "~/StaticFiles/js/perfect-scrollbar.js",
                "~/StaticFiles/js/menu.js",
                "~/StaticFiles/js/main.js"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/StaticFiles/css/boxicons.css",
                      "~/StaticFiles/css/core.css",
                      "~/StaticFiles/css/theme-default.css",
                      "~/StaticFiles/css/demo.css",
                      "~/StaticFiles/css/perfect-scrollbar.css"));
        }
    }
}
