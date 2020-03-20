using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoodAid.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public GenderType Gender { get; set; }

        public string Name
        {
            get 
            { 
                return $"{FirstName} {LastName}"; 
            }
        }

    }

    public enum GenderType
    {
        Male,
        Female,
        Diverse
    }
}
