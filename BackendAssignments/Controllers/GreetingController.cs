using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignments.Controllers
{
    public class GreetingController : ApiController
    {
        public string Post()
        {
            return "Hello World";
            //This string will be return on command prompt using curl -d "" 

        }
        public string Get(string id)
        {
            string message = "Greetings to " + id + " people!";
            return message;
        }
    }
}
