using CapQueenCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapQueenCMS.Controllers
{
    public class XSSController : Controller
    {
        [HttpGet]
        // GET: XSS
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(XSSModel model)
        {
            return View(model);
        }
    }
}