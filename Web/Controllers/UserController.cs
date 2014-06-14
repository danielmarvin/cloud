using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using DataLayer;
using Newtonsoft.Json.Serialization;

namespace Web.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public string Get()
        {
			  //var s = JsonConvert.SerializeObject(new UserRepository().GetAll());

			  var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
			  var s = JsonConvert.SerializeObject((new UserRepository().GetAll()), Formatting.None, settings);
				return s; 
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
