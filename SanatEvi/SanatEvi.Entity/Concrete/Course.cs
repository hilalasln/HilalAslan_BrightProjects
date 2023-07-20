using SanatEvi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Entity.Concrete
{
    public class Course:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Classtime { get; set; }
        public decimal Price { get; set; }
        public int CurrentPerson { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }


    }
}
