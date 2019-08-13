using System.Web;
using System.Web.Mvc;

namespace DBFirst_Ecommerce_August13
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
