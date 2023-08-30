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
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int CurrentPerson { get; set; }
        public bool IsHome { get; set; }
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }

    }
}
