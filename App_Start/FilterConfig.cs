using System.Web;
using System.Web.Mvc;

namespace One_21MAR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute( ));
        }
    }
}
