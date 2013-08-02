using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Usat.Sports.Business.Models;
using Usat.Sports.Business.Services;
using Usat.Sports.Business.Services.Contracts;

namespace Usat.Sports.Services
{
    public class Tools : ITools
    {
        public ServiceResponse<IList<SuspenderItem>> GetSuspenderList(string full = null)
        {
            var response = new ServiceResponse<IList<SuspenderItem>>();

            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Timestamp = DateTime.Now;
                response.Error = e.Message;
            }

            return response;
        }

        public ServiceResponse<IList<SuspenderItem>> SetSuspenderList(IList<SuspenderItem> items)
        {
            var response = new ServiceResponse<IList<SuspenderItem>>();

            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Timestamp = DateTime.Now;
                response.Error = e.Message;
            }

            return response;
        }
    }
}
