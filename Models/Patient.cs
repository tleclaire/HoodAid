using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoodAid.Models
{
    public class Patient : Person
    {
        public int HealthAuthorityId { get; set; }
        public HealthAuthority HealthAuthority { get; set; }
    }
}
