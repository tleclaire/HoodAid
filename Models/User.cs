using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoodAid.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Vorname { get; set; }
        public string  Nachname { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string Strasse { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
    }
}
