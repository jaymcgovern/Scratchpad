using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Usat.Sports.Business.Models;

namespace Usat.Sports.Business.Services.Contracts
{
    [ServiceContract(ConfigurationName = "ToolsService.ITools")]
    public interface ITools
    {
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/suspenderlist/{*full}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ServiceResponse<IList<SuspenderItem>> GetSuspenderList(string full = null);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle= WebMessageBodyStyle.Bare, UriTemplate = "/suspenderlist/save", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ServiceResponse<IList<SuspenderItem>> SetSuspenderList(IList<SuspenderItem> items);
    }
}
