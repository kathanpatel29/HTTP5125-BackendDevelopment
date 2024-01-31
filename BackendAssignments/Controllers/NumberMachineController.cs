using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignments.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Taking a number and performing mathematical operations
        /// </summary>
        /// <param int="id"></param>
        /// <example>http://localhost:55731/api/numbermachine/10<example>
        /// <returns>
        /// Addition (doubled): 20, Subtraction: 0, Multiplication (squared): 100, Division (halved): 5
        /// </returns>
        /// <example>http://localhost:55731/api/numbermachine/10</example>
        /// <returns>
        /// Addition (doubled): -10, Subtraction: 0, Multiplication (squared): 25, Division (halved): -2
        /// </returns>
        /// <example>http://localhost:55731/api/numbermachine/10</example>
        /// <returns>
        /// Addition (doubled): 60, Subtraction: 0, Multiplication (squared): 900, Division (halved): 15
        /// </returns>

        public string Get(int id)
        {
            //Addition
            int addition = id + id;


            //Subtracted
            int subtraction = id - id;


            //Squared or multiply
            int multiplication = id * id;


            //halved or divided
            int division = id/2;

            return $"Addition (doubled): {addition}, Subtraction: {subtraction}, Multiplication (squared): {multiplication}, Division (halved): {division}";
        }
    }
}
