using ContactOrganizer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactOrganizer.Controllers
{
    public class ImageController : Controller
    {
        private ContactDbContext db = new ContactDbContext();
        // GET: Image
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Images.Find(id);
            return File(fileToRetrieve.ImageData, fileToRetrieve.ImageType);
        }            
    }
}