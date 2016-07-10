using ContactOrganizer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactOrganizer.Models
{
    public class PersonInfoViewModel
    {
        //public IEnumerable<Person> Persons { get; set; }
        //public IEnumerable<Image> Images { get; set; }
        //public IEnumerable<Address> Addresses { get; set; }

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateAdded { get; set; }
        public string Interests { get; set; }

        //public int ImageID { get; set; }
        public string ImageTitle { get; set; }
        public string ImageFileName { get; set; }
        public string ImageDescription { get; set; }
        public string ImageType { get; set; }
        public byte[] ImageData { get; set; }
        public string ImagePath { get; set; }
        

        //public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        //public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}