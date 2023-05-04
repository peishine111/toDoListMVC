using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjToDo.Models;

namespace prjToDo.Controllers
{
    public class HomeController1 : Controller
    {
        dbToDoEntities1 db = new dbToDoEntities1 ();
        // GET: HomeController1
        public ActionResult Index()
        {
            var todos = db.tToDo.OrderByDescending(m => m.fDate).ToList();

            return View(todos);
        }
    }
}