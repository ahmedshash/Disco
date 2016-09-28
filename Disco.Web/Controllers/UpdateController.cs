﻿using Disco.Services.Plugins;
using System.Web.Mvc;

namespace Disco.Web.Controllers
{
    [OutputCache(Duration = 0, Location = System.Web.UI.OutputCacheLocation.None)]
    public partial class UpdateController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!Request.IsLocal && !InitialConfigController.ServerIsCoreSKU.Value)
            {
                filterContext.Result = new HttpStatusCodeResult(System.Net.HttpStatusCode.ServiceUnavailable, "Initialization Configuration of Disco is only allowed via a local connection");
            }
            base.OnActionExecuting(filterContext);
        }

        public virtual ActionResult Index()
        {
            var status = UpdatePluginsAfterDiscoUpdateTask.UpdateDiscoPlugins(true);

            var model = new Models.Update.IndexModel()
            {
                SessionId = status.SessionId
            };

            return View(model);
        }
    }
}