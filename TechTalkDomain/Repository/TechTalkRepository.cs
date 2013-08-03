using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTalkDomain.Repository
{
    public abstract class TechTalkRepository
    {
        public abstract IEnumerable<TechTalk> GetTechTalks();
    }
}
