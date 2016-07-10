using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactOrganizer.Entities
{
    public class PersonInfo
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public HomeAddress HomeAddress { get; set; }
        public DateTime DateAdded { get; set; }
        public string Interests { get; set; }

        public ProfileImage ProfileImage { get; set; }
    }

    public class HomeAddress
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class ProfileImage
    {
        public int ImageID { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string ImageType { get; set; }
        public byte[] ImageData { get; set; }
        public string ImagePath { get; set; }
    }
}