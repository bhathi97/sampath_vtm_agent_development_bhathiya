using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes.JsonDataToBackend
{
    interface ICreateNewRecord
    {
        Task CreateNewApplicationRecord(string endpoint, string contentJson);
    }
}
