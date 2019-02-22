using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MVCController : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            //Response.Redirect("/",true);
            //base.HandleUnknownAction(actionName);
            //try
            //{
            //    this.View(actionName).ExecuteResult(this.ControllerContext);
            //}
            //catch (InvalidOperationException ieox)
            //{
            //    ViewData["error"] = "Unknown Action: \"" +
            //        Server.HtmlEncode(actionName) + "\"";
            //    ViewData["exMessage"] = ieox.Message;
            //    this.View("Error").ExecuteResult(this.ControllerContext);
            //}
        }
        // GET: MVC
        public ActionResult Index()
        {
            return View();
        }
    }
}