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
        /// <summary>
        /// 
        /// </summary>
        /// <example>RETURNING STRING "Hello World" by using POST Method in Command Prompt curl -d "http://localhost:55731/api/Greeting"</example>
        /// <returns>"Hello World"</returns>
        /// <example>http://localhost:55731/api/Greeting/3</example>
        /// <returns>Greetings to 3 people!</returns>
        /// <example>http://localhost:55731/api/Greeting/6</example>
        /// <returns>Greetings to 6 people!</returns>
        /// <example>http://localhost:55731/api/Greeting/0</example>
        /// <returns>Greetings to 0 people!</returns>
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
