using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace VTMSampathAdmin.Classes.BackendDataLoading
{
    public interface IApplicationData
    {
        Task LoadAllAppliactionData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl, DateRangeClass dateRange);

        Task LoadCompletedApplicationData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl, DateRangeClass dateRange);

        Task LoadIncompletedApplicationData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl, DateRangeClass dateRange);

        Task LoadRejectedApplicationData(string endpoint, FlowDocumentReader tblDataTable, UserControl userControl, DateRangeClass dateRange);

        Task<CompleteApplicationDetailsClass> LoadCompletedApplicationForId(string endpoint);

        Task<RejectedApplicationDetailsClass> LoadRejectedApplicationForId(string endpoint);
    }
}
