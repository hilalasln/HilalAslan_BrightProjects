using SanatEvi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Entity.Concrete
{
    public class Instructor:BaseEntity
    {

        public string Branch { get; set; }
        public string About { get; set; }
        public string Experience { get; set; } //Tecrübe
        public User User { get; set; }
        public string UserId { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}
