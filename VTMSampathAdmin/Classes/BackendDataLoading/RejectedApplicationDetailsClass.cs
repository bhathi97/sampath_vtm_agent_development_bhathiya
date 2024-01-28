using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes.BackendDataLoading
{
    public class RejectedApplicationDetailsClass
    {
        public int StatusCode { get; set; }
        public DataR Data { get; set; }

    }

    public class DataR : ApplicationDetailsPreviewClass
    {
        public string RejectReason { get; set; }
    }



}
