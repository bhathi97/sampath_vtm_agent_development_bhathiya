using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes.BackendDataLoading
{
    public class ApplicationDetailsPreviewClass
    {
        public string CustomerImage { get; set; }
        public string PreviewName { get; set; }
        public string CustomerRate { get; set; }
        public bool CustomerStatus { get; set; } // if new?true:false
        public string NicNumber { get; set; }
        public string MobileNumber { get; set; }
        public string AccountNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public string NicFrontImage { get; set; }
        public string NicRearImage { get; set; }
        public bool DrpStatus { get; set; }
    }
}
