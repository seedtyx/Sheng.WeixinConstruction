﻿using Sheng.WeixinConstruction.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sheng.WeixinConstruction.Management.Shell
{
    public static class SessionContainer
    {
        public static void SetUserContext(HttpContextBase httpContext, UserContext userContext)
        {
            httpContext.Session["UserContext"] = userContext;
        }

        public static UserContext GetUserContext(HttpContextBase httpContext)
        {
            return httpContext.Session["UserContext"] as UserContext;
        }

        public static UserContext GetUserContext(HttpContext httpContext)
        {
            return httpContext.Session["UserContext"] as UserContext;
        }

        public static void ClearUserContext(HttpContextBase httpContext)
        {
            httpContext.Session["UserContext"] = null;
        }
    }
}