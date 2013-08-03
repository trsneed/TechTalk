using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using TechTalkDomain.Repository;
using TechTalkDomain.Service;

namespace TechTalkApi.Controllers
{
    public class TechTalkController : ApiController
    {
        private readonly TechTalkRepository repository;

        public TechTalkController(TechTalkRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            this.repository = repository;
        }

        // GET api/techtalks
        public IEnumerable<string> Get()
        {
            var techService = new TechTalkService(this.repository);
            var talks = techService.GetTechTalks(this.User);

            return new string[] { "value1", "value2" };
        }

        // GET api/techtalk/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/techtalk
        public void Post([FromBody]string value)
        {
        }

        // PUT api/techtalk/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/techtalk/5
        public void Delete(int id)
        {
        }
    }
}
