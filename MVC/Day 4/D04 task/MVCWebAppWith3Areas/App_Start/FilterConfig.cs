using System.Web;
using System.Web.Mvc;

namespace MVCWebAppWith3Areas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()
            {
                View = "MyErrorPage"
            }
            );
        }
    }
}
