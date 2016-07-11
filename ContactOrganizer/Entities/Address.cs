using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactOrganizer.Entities
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        //public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public int PersonID { get; set; }
        public virtual Person Person { get; set; }
    }
}