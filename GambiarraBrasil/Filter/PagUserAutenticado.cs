﻿using GambiarraBrasil.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;

namespace GambiarraBrasil.Filter {
    public class PagUserAutenticado : ActionFilterAttribute {
        public override void OnActionExecuting(ActionExecutingContext filterContext) {
            string sectionUser = filterContext.HttpContext.Session.GetString("sectionUserAutenticado");

            if (string.IsNullOrEmpty(sectionUser)) {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Logar" }, { "action", "AcessoNegado" } });
            }
            else {
                Usuario usuario = JsonConvert.DeserializeObject<Usuario>(sectionUser);
                if (usuario == null) {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Logar" }, { "action", "AcessoNegado" } });
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
