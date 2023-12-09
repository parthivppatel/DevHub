using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevHub.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class CustomAuthorizationAttribute : ActionFilterAttribute
    {
        private readonly string[] _roles;

        public CustomAuthorizationAttribute(params string[] roles)
        {
            _roles = roles;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result = new RedirectResult("/Account/Login"); // Redirect to the login page if the user is not authenticated
            }
            else
            {
                var authorized = false;
                foreach (var role in _roles)
                {
                    if (filterContext.HttpContext.User.IsInRole(role))
                    {
                        authorized = true;
                        break;
                    }
                }

                if (!authorized)
                {
                    filterContext.Result = new RedirectResult("https://localhost:44305/ErrorPages/Forbidden.html"); // Redirect to a custom page if the user is authenticated but does not have the required role
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
  }