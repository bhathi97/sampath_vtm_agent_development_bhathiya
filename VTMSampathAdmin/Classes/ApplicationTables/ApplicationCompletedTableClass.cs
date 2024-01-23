using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes
{
    public class ApplicationCompletedTableClass
    {
        public int StatusCode { get; set; }
        public List<DataArray> Data { get; set; }

        public class DataArray
        {
            public int Id { get; set; }
            public string AccountNumber { get; set; }
            public string NicNumber { get; set; }
            public string MobileNumber { get; set; }
            public bool DebitCardStatus { get; set; }
            public string CreatedAt { get; set; }
        }
    }
}
