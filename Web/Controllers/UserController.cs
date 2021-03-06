﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using DataLayer;
using Newtonsoft.Json.Serialization;
using Entities;
using System.Threading;

namespace Web.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
		 public IEnumerable<User> Get()
        {
			  return new UserRepository().GetAll();
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
