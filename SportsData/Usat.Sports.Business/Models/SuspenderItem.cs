using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Usat.Sports.Business.Models;

namespace Usat.Sports.Business.Models
{
    [DataContract]
    public class SuspenderItem
    {
        [DataMember]
        [JsonProperty]
        public string Name { get; set; }

        [DataMember]
        [JsonProperty]
        public bool Active { get; set; }

        [DataMember]
        [JsonProperty]
        public int Order { get; set; }
    }
}
