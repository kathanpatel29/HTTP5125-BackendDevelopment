using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignments.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of the integer input {id}.
        /// </summary>
        /// <param int="id"></param>
        /// <example>http://localhost:55731/api/square/2</example>
        /// <returns> 4 </returns>
        /// <example>http://localhost:55731/api/square/-2</example>
        /// <returns> 4 </returns>
        /// <example>http://localhost:55731/api/square/10</example>
        /// <returns> 100 </returns>
        public int Get(int id)
        {
            int Square = id * id;
            return Square;
        }
    }
}
