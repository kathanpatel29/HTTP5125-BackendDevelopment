using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignments.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            double fortnightRate = 5.50;
            double hstRate = 0.13;
            int fortnights = (id / 14) + 1;
            double subtotal = fortnights * fortnightRate;
            double hst = subtotal * hstRate;
            double total = subtotal + hst;
            return $"{fortnights} fortnights at ${fortnightRate:F2}/FN = ${subtotal:F2}" +
                $" HST 13% = ${hst:F2} CAD" +
                $" Total = ${total:F2} CAD";
        }
    }
}
