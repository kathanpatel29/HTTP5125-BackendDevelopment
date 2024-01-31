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
        /// <summary>
        /// CostperFortNight given 5.50
        /// HstRate given 0.13
        /// Declaring int only to fortnights
        /// </summary>
        /// <param number of daysElapsed="id"></param>
        /// <param name="id"></param>
        /// 
        /// <example>http://localhost:55731/api/hostingcost/0</example>
        /// <returns>
        /// 1 fortnights at $5.50/FN = $5.50 HST 13% = $0.72 CAD Total = $6.22 CAD
        ///</returns>
        /// <returns>
        /// <example>>http://localhost:55731/api/hostingcost/14</example>
        /// </returns>
        /// <returns>
        /// 2 fortnights at $5.50/FN = $11.00 HST 13% = $1.43 CAD Total = $12.43 CAD
        /// </returns>
        /// <returns>
        /// <example>http://localhost:55731/api/hostingcost/15</example>
        /// </returns>
        /// <returns>
        /// 2 fortnights at $5.50/FN = $11.00 HST 13% = $1.43 CAD Total = $12.43 CAD
        /// </returns>
        /// <example>http://localhost:55731/api/hostingcost/21</example>
        /// <returns>
        /// 2 fortnights at $5.50/FN = $11.00 HST 13% = $1.43 CAD Total = $12.43 CAD
        /// </returns>
        /// <returns>
        /// <example>http://localhost:55731/api/hostingcost/28</example>
        /// </returns>
        /// <returns>
        /// 3 fortnights at $5.50/FN = $16.50 HST 13% = $2.15 CAD Total = $18.65 CAD
        /// </returns>
        public string Get(int id)
        {
            double fortnightRate = 5.50;
            double hstRate = 0.13;
            int fortnights = (id / 14) + 1; // Fortnight days cannot be determined in decimal So added with +1 integer to get non-decimal value
            double subtotal = fortnights * fortnightRate; //Per Fortnight subttotal rate without hst
            double hst = subtotal * hstRate;
            double total = subtotal + hst;  //Per fortnight rate with added hst
            return $"{fortnights} fortnights at ${fortnightRate:F2}/FN = ${subtotal:F2}" +
                $" HST 13% = ${hst:F2} CAD" +
                $" Total = ${total:F2} CAD";
        }
    }
}
