using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContactOrganizer.Entities;

namespace ContactOrganizer.DAL
{
    public class ContactDbInitializer : DropCreateDatabaseIfModelChanges<ContactDbContext>
    {
        protected override void Seed(ContactDbContext context)
        {
            //base.Seed(context);
            var persons = new List<Person>
            {
                new Person {PersonID =1, FirstName = "Sean", LastName = "John", BirthDate = DateTime.Parse("1990-03-01"), DateAdded = DateTime.Now, Interests = "Sports" }
            };

            persons.ForEach(p => context.People.Add(p));
            context.SaveChanges();

            var address = new List<Address>()
            {
                new Address { AddressId = 1, Line1 = "2011 Wilshire", City = "Los Angeles", PostalCode = "92001", Country = "USA" }
            };

            address.ForEach(a => context.Addresses.Add(a));
            context.SaveChanges();

            var image = new List<Image>()
            {
                new Image {ImageID=1, Title = "Profile Image", FileName = "Profile.jpg", Description = "taken at very happy momnet" }
            };

            image.ForEach(i => context.Images.Add(i));
            context.SaveChanges();
        }
    }
}