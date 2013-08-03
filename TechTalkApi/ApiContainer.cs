using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using TechTalkApi.Controllers;
using TechTalkDomain.Repository;

namespace TechTalkApi
{
    public class ApiContainer : IDependencyResolver
    {
        private static readonly TechTalkRepository Repository;

        public void Dispose()
        {
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(TechTalkController))
            {
                return new TechTalkController(Repository);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public IDependencyScope BeginScope()
        {
            // This example does not support child scopes, so we simply return 'this'.
            return this;
        }
    }
}