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
