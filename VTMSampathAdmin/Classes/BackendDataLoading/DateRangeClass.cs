using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes.BackendDataLoading
{
    public class DateRangeClass
    {
        public DateTime FromDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime ToDate { get; set; } = DateTime.Now;
    }
}
