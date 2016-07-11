using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactOrganizer.Entities
{
    public class Person
    {        
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        
        public DateTime DateAdded { get; set; }
        public string Interests { get; set; }

        public virtual ICollection<Address> HomeAddress { get; set; }
        public virtual ICollection<Image> ProfileImage { get; set; }
    }
}
