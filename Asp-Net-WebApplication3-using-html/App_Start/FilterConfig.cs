using System.Web;
using System.Web.Mvc;

namespace Asp_Net_WebApplication3_using_html
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
