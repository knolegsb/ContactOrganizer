using ContactOrganizer.DAL;
using ContactOrganizer.Entities;
using ContactOrganizer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ContactOrganizer.Concrete
{    
    public class ImageRepository
    {
        private readonly ContactDbContext db = new ContactDbContext();

        public int UploadImageInDatabase(HttpPostedFileBase file, ImageViewModel imageViewModel)
        {
            imageViewModel.ImageData = ConvertToBytes(file);
            var newImage = new Image
            {
                ImageID = imageViewModel.ImageID,
                Title = imageViewModel.Title,
                FileName = imageViewModel.FileName,
                Description = imageViewModel.Description,
                ImageType = imageViewModel.ImageType,
                ImageData = imageViewModel.ImageData,
                ImagePath = imageViewModel.ImagePath
            };
            db.Images.Add(newImage);
            int i = db.SaveChanges();
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private byte[] ConvertToBytes(HttpPostedFileBase file)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(file.InputStream);
            imageBytes = reader.ReadBytes((int)file.ContentLength);
            return imageBytes;
        }
    }
}