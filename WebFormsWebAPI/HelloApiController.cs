using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebFormsWebAPI
{
    public class HelloApiController : ApiController
    {
        //Browse using : api/HelloApi

        public string Get()
        {
            return "Hello";
        }
    }
}