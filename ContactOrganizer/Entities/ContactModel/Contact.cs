using System;
using System.Collections.Generic;

namespace ContactOrganizer.Entities.ContactModel
{
    public class Contact : Person
    {

        public DateTime DateAdded { get; set; }
        public string Interests { get; set; }

        //public int AddressID { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}