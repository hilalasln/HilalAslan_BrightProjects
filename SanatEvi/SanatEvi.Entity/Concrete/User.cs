using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Entity.Concrete
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string EducationStatus { get; set; }
        public int DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
    }
}
