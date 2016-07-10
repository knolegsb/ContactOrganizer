using ContactOrganizer.DAL;
using ContactOrganizer.Entities;
using ContactOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactOrganizer.Controllers
{
    public class ContactController : Controller
    {
        private ContactDbContext db = new ContactDbContext();

        public ActionResult ShowPerson()
        {
            var person = db.People.ToList();

            return View(person);
        }
        // GET: Contact
        //public ViewResult Index()
        //{
        //    IEnumerable<Person> person = db.Persons.Select(pai => new Person()
        //    {
        //        PersonID = pai.PersonID,
        //        FirstName = pai.FirstName,
        //        LastName = pai.LastName,
        //        BirthDate = pai.BirthDate,
        //        DateAdded = pai.DateAdded,
        //        Interests = pai.Interests,
        //        //pai.ProfileImage.Title,
        //        //pai.ProfileImage.FileName,
        //        //pai.ProfileImage.Description,
        //        //pai.ProfileImage.ImageType,
        //        //pai.ProfileImage.ImageData,
        //        //pai.ProfileImage.ImagePath,
        //        //pai.HomeAddress.Line1,
        //        //pai.HomeAddress.Line2,
        //        //pai.HomeAddress.City,
        //        //pai.HomeAddress.PostalCode,
        //        //pai.HomeAddress.Country
        //    });

        //    IEnumerable<PersonInfoViewModel> persons = person.Select(p => new PersonInfoViewModel()
        //    {
        //        PersonID = p.PersonID,
        //        FirstName = p.FirstName,
        //        LastName = p.LastName,
        //        BirthDate = p.BirthDate,
        //        DateAdded = p.DateAdded,
        //        Interests = p.Interests,
        //        //ImageTitle = p.Title,
        //        //ImageFileName = p.FileName,
        //        //ImageDescription = p.Description,
        //        //ImageType = p.ImageType,
        //        //ImageData = p.ImageData,
        //        //ImagePath = p.ImagePath,
        //        //Line1 = p.Line1,
        //        //Line2 = p.Line2,
        //        //City = p.City,
        //        //PostalCode = p.PostalCode,
        //        //Country = p.Country
        //    });
        //    return View(person);
        //}
    }
}