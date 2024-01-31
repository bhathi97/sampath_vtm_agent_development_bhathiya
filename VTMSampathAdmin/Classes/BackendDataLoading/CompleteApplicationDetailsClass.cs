using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes.BackendDataLoading
{
    public class CompleteApplicationDetailsClass
    {

        public int StatusCode { get; set; }
        public Data Data { get; set; }
 
    }
    public class Data : ApplicationDetailsPreviewClass
    {
        public bool DebitCardStatus { get; set; }
        public string DebitCardNumber { get; set; }
        public DateTime DebitCardIssueDate { get; set; }
        public string MandateFormFile { get; set; }
        public string DebitCardFormFile { get; set; }
        public string OtherFile { get; set; }
        public string SignatureImage { get; set; }
        public string DebitCardImage { get; set; }
        public string VideoCallRecord { get; set; }

    }
}
