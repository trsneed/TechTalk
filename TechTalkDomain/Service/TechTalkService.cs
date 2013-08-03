using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TechTalkDomain.Repository;

namespace TechTalkDomain.Service
{
    public class TechTalkService
    {
        private readonly TechTalkRepository _repository;

        public TechTalkService(TechTalkRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            this._repository = repository;
        }

        public IEnumerable<TechTalk> GetTechTalks(IPrincipal user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }

            return from t in _repository.GetTechTalks()
                   select t;
        }
    }
}
