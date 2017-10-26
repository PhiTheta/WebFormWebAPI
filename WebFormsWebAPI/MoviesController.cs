using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;

namespace WebFormsWebAPI
{
    public class MoviesController :ApiController
    {
        static List<string> data = initList();

        private static List<string> initList()
        {
            var retVal = new List<string>();
            retVal.Add("Titanic");
            retVal.Add("2001: Space Odyssey");

            return retVal;
        }

        //api/Movies
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return data;
        }

        //api/Movies/1
        [HttpGet]
        public string Get(int id)
        {
            return data[id];
        }


        [HttpPost]
        public void Post([FromBody]string value)
        {
            data.Add(value);
        }

        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
            data[id] = value;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            data.RemoveAt(id);
        }

        /* Notes: 
         * GET & POST are allowed from HTML Forms
         * GET, POST, PUT and DELETE are supported by the implementations of XMLHttpRequest (i.e. AJAX calls) in all the major web browsers (IE, Firefox, Safari, Chrome, Opera).
         * So to test use Fiddler to compose these requests
         * Checkout why there are no PUT and DELETE on HTML Forms : https://softwareengineering.stackexchange.com/questions/114156/why-are-there-are-no-put-and-delete-methods-on-html-forms
         * */
    }
}