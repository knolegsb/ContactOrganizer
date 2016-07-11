using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactOrganizer.Models
{
    public class ImageViewModel
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