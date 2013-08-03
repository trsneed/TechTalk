using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain = TechTalkDomain;
namespace TechTalkDataAccess
{
    public class SqlTechTalkRepository : Domain.Repository.TechTalkRepository
    {
        private readonly DomainContext _context;

        public SqlTechTalkRepository(string connection)
        {
            this._context = new DomainContext(connection); 
        }

        public override IEnumerable<Domain.TechTalk> GetTechTalks()
        {
            var talks = (from t in _context.TechTalks
                         select t).AsEnumerable();

            return from t in talks
                   select t.ToDomainTechTalk();
        }
    }
}
