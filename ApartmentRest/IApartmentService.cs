﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ApartmentRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IApartmentService" in both code and config file together.
    [ServiceContract]
    public interface IApartmentService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
    UriTemplate = "Apartment/")]
        IList<Apartment> GetCustomers();


    }
}
