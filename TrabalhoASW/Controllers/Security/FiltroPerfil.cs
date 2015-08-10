using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabalhoASW.Controllers.Security
{
    public class FiltroPerfil: AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.Result is HttpUnauthorizedResult)
                filterContext.HttpContext.Response.Redirect("/Home/Negado");
        }
    }
}