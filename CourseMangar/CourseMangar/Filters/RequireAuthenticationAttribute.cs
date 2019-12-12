using CourseMangar.Models;
using CourseMangar.Models.ValidatableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseMangar.Filters
{
    public class RequireAuthenticationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session !=null)
            {
                var user = filterContext.HttpContext.Session["user"]?.ToString();
                if (!string.IsNullOrWhiteSpace(user))
                {
                    return;
                }
                var cookie = filterContext.HttpContext.Response.Cookies?["user"];

                if (string.IsNullOrEmpty(cookie?.Value))
                {
                    throw new UnauthorizedAccessException();

                }
                var content = cookie?.Value.DecryptQueryString();

                 CourseMangarEntities db = new CourseMangarEntities();
                if (db.Users.Any(u => u.Account == content))
                {
                    throw new UnauthorizedException();
                }
       
            }
        }
    }
}