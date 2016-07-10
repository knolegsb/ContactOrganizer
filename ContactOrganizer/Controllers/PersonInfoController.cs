using ContactOrganizer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactOrganizer.Controllers
{
    public class PersonInfoController : Controller
    {
        // GET: PersonInfo
        public ActionResult CreatePerson()
        {
            return View(new PersonInfo());
        }

        [HttpPost]
        public ActionResult CreatePerson(PersonInfo person)
        {
            return View("DisplayPerson", person);
        }
    }
}