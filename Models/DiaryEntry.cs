using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoodAid.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Activity { get; set; }
        public decimal Temperature { get; set; }
        public List<Symptom> Symptoms { get; set; }
        public List<ContactPerson> Contacts { get; set; }
        
    }
}
