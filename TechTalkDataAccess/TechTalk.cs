using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain = TechTalkDomain;

namespace TechTalkDataAccess
{
    public class TechTalk : IEntity
    {
        public int Id { get; set; }
        public DateTime LastModificationDateTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Domain.TechTalk ToDomainTechTalk()
        {
            var d = new Domain.TechTalk();
            d.Id = this.Id;
            d.Name = this.Name;
            d.Description = this.Description;
            return d;
        }
    }
}
