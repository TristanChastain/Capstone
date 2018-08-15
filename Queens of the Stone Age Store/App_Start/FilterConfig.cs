using System.Web;
using System.Web.Mvc;

namespace Queens_of_the_Stone_Age_Store
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
