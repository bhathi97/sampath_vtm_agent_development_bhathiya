using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTMSampathAdmin.Classes.BackendDataLoading
{
    public class EntityForApplicationButtonHandle : IEntityForApplicationButtonHandle
    {
        public int Id { get; set; }
        public string ApplicationStatus { get; set; }
    }
}
