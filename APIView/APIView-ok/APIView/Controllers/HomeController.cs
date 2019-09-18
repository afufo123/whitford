using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIView.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "jhf test";

            return View();
        }

        public ActionResult Top()
        {
            ViewBag.UserName = "超级管理员";
            ViewBag.AvailableBalance = "8888.00";
            return View();
        }
        public ActionResult Left()
        {
            return View();
        }
        public ActionResult Right()
        {
            return View();
        }

        public ActionResult Bootom()
        {
            return View();
        }

    }
}
