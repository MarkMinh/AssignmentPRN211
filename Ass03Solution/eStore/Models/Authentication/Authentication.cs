using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eStore.Models.Authentication
{
    public class Authentication:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("email") == null)
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        {"Controller","Access" },
                        {"Action","Login" }
                    });
            }
            
            if (context.HttpContext.Session.GetString("admin") == null)
            {
                var actionName = context.RouteData.Values["Action"].ToString();
                if (actionName != "Details" && actionName != "Edit")
                {
                    context.Result = new RedirectToRouteResult(
                        new RouteValueDictionary
                        {
                        {"Controller","Access" },
                        {"Action","Unauthorized" }
                        });
                }
            }
        }
    }
}
