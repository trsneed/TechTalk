using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTalkDataAccess
{
    internal class DomainContext : DbContext
    {
        public DbSet<TechTalk> TechTalks { get; set; } 

        public DomainContext(string connection) : base(connection)
        {
        }
    }
}
