using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactOrganizer.Entities.ContactModel
{
    public class FilePath
    {
        public int FilePathID { get; set; }

        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public int PersonID { get; set; }
        public virtual Person Person { get; set; }
    }
}