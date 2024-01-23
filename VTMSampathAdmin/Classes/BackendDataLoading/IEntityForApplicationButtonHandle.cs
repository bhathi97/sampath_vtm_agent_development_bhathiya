using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes
{
    public interface IEntityForApplicationButtonHandle
    {
        int Id { get; set; }
        string ApplicationStatus { get; set; }
    }
}
