
using Crud_Asp_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Asp_MVC.Controllers
{
    public class Homeontroller : Controller
    {

        StudentDBDataContext db = new StudentDBDataContext();
        public ActionResult Index()
        {
            var data = db.students.ToList();    
            return View(data);
        }
    }
}