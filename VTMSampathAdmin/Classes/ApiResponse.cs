using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public List<T> Data { get; set; }
    }
}
