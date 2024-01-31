using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignments.Controllers
{
    public class addTenController : ApiController
    {
        /// <summary>
        /// Adding 10 more to the integer input
        /// </summary>
        /// <param int="id"></param>
        /// <example>http://localhost:55731/api/addten/21</example>
        /// <returns> 31 </returns>
        /// <example>http://localhost:55731/api/addten/10</example>
        /// <returns> 20 </returns>
        /// <example>http://localhost:55731/api/addten/-1</example>
        /// <returns> 9 </returns>

        public int Get(int id)
        {
            int addTen = id + 10;
            return addTen;
        }
    }
}
