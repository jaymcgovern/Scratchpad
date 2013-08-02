using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Usat.Sports.Business.Services
{
    [DataContract]
    public class ServiceResponse<T>
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public DateTime Timestamp { get; set; }

        [DataMember]
        public string Error { get; set; }

        [DataMember]
        public T Data { get; set; }
    }
}