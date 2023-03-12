using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebAppWith3Areas.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        [HandleError(View = "MyErrorPage2")]
        public ActionResult Index()
        {
            string str = null;
            int num = str.Length;
            return View();
        }
        [HandleError(View = "MyErrorPage")]
        public ActionResult Test()
        {
            int num = Convert.ToInt32("Hello");
            return View();
        }
    }
}