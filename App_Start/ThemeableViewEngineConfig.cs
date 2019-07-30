using System.Web.Mvc;
using Quintsys.Web.ThemeableRazorViewEngine;

namespace CleanArchitectureAspNetMvc5 {
    public static class ThemeableViewEngineConfig
    {
        public static void RegisterViewEngines(ViewEngineCollection engines, params string[] fileExtensions )
        {
            engines.Clear();
            engines.Add(new ThemeableRazorViewEngine(fileExtensions));
        }
    }
}
