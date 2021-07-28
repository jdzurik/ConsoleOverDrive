using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Mvc;

namespace WebAppGuessGame1.Controllers
{
    public class GuessController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int guess)
        {
            
            string strSuccessMessage = "";
            //int randNum = Convert.ToInt32(Request.Content.Cookies["RandNum"].Value.ToString());

            //if (guess < randNum)
            //    strSuccessMessage = "Your Guess is Lower";

            //if (guess == randNum)
            //    strSuccessMessage = "Congratulations! Your Guess is Correct";

            //if (guess > randNum)
            //    strSuccessMessage = "Your Guess is Higher";

            return strSuccessMessage;

        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}