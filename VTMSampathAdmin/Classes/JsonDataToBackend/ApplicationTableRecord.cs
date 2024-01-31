using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes.JsonDataToBackend
{
    public class ApplicationTableRecord
    {
        private static ApplicationTableRecord _applicationInstance;

        public string AccountNumber { get; set; } = "string";
        public string MobileNumber { get; set; } = "string";
        public string NicNumber { get; set; } = "string";
        public string ApplicationStatus { get; set; } = "complete";
        public bool DebitCardStatus { get; set; } = false;
        public bool DrpStatus { get; set; } = false;
        public string CustomerRate { get; set; } = "string";
        public string NicFrontImage { get; set; } = "string";
        public string NicRearImage { get; set; } = "string";
        public string SignatureImage { get; set; } = "string";
        public string DebitCardImage { get; set; } = "string";
        public string VideoCallRecord { get; set; } = "string";
        public string RejectReason { get; set; } = "string";
        public string MandateFormFile { get; set; } = "string";
        public string DebitCardFormFile { get; set; } = "string";
        public string OtherFile { get; set; } = "string";
        public string CustomerImage { get; set; } = "string";
        public string AddressProofImage { get; set; } = "string";
        public bool AddressNicSame { get; set; } = false;
        public string AdditionalDocumentFiles { get; set; } = "string";
        public string CustomerVtmId { get; set; } = "string";
        public bool CustomerStatus { get; set; } = false;
        public string CustomerPurpose { get; set; } = "string";
        public string AgentRate { get; set; } = "string";
        public string CompletedTasks { get; set; } = "string";
        public string DebitCardNumber { get; set; } = "string";
        public DateTime DebitCardIssueDate { get; set; } = DateTime.Now;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int AgentId { get; set; } = 1141;

        private ApplicationTableRecord(){}

        public static ApplicationTableRecord ApplicationInstance
        {
            get
            {
                if(_applicationInstance == null)
                {
                    _applicationInstance = new ApplicationTableRecord();
                }
                return _applicationInstance;
            }
        }

        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
