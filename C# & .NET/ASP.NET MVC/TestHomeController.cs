using project.Areas.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project.Areas.Test.Controllers
{
    public class TestHomeController : Controller
    {
        // GET: Test/TestHome
        public ActionResult Index()
        {
            PersonModel person = new PersonModel() {
                Name = "Name",
                Surname = "Surname",
                Age = 20
            };
            return View(person);
        }
    }
}
