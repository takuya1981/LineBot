﻿using LineBot.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LineBot
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API の設定およびサービス
            config.MessageHandlers.Add(new CustomizedHandler());

            // Web API ルート
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
