﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blog.API.Controllers
{
    [Route("api/[controller]")]
    public class TagsController : Controller
    {
        // GET api/tags
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/tags/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/tags
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tags/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tags/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
