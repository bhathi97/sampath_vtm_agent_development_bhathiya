using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes.ApplicationTables
{
    internal class ApplicationIncompletedTableClass
    {
        public int StatusCode { get; set; }
        public List<DataArray> Data { get; set; }

        public class DataArray
        {
            public int Id { get; set; }
            public string NicNumber { get; set; }
            public string MobileNumber { get; set; }
            public string CreatedAt { get; set; }
            public string RejectReason { get; set; }
        }
    }
}
