using SanatEvi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Entity.Concrete
{
    public class Teacher:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public string EducationStatus { get; set; }
        public int DateOfBirth { get; set; }
        public string About { get; set; }
        public string Url { get; set; }
        public string PhotoUrl { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<Course> Courses { get; set; }

    }
}
