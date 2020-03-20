using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoodAid.Models
{
    public class HealthAuthority
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
