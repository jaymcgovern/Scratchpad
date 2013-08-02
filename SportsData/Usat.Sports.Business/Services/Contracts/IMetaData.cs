using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Usat.Sports.Business.Services.Contracts
{
    [ServiceContract(ConfigurationName = "MetaDataService.IMetaData")]
    public interface IMetaData
    {
        [OperationContract(Action = "http://tempuri.org/IMetaData/GetLeagueKeys", ReplyAction = "http://tempuri.org/IMetaData/GetLeagueKeysResponse")]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/leaguekeys", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Stream GetLeagueKeys();
    }
}