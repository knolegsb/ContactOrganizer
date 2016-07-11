using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactOrganizer.Entities
{
    public class Image
    {
        //public Image()
        //{
        //    ImageList = new List<string>();
        //}

        public int ImageID { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string ImageType { get; set; }
        public byte[] ImageData { get; set; }
        public string ImagePath { get; set; }

        public FileType FileType { get; set; }


        public int PersonID { get; set; }
        public virtual Person Person { get; set; }

        //public List<string> ImageList { get; set; }

        //public HttpPostedFileBase File { get; set; }
    }
}