using ContactOrganizer.Entities.ContactModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ContactOrganizer.Abstract
{
    public interface IContactRepository
    {
        Contact GetContact(int? id);
        List<Contact> GetAllContacts();
        void AddContact(Contact contact);
        Contact GetContactWithFiles(int? id);
        void ImageUpdate(int? id, HttpPostedFileBase upload);
        void RemoveContact(int id);
        void DbSaveChanges();
        void DbDispose();
    }
}
