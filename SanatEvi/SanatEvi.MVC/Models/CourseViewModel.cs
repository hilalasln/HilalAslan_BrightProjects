using SanatEvi.Entity.Concrete;
namespace SanatEvi.MVC.Models
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
        public string TeacherUrl { get; set; }
        public string TeacherName { get; set; }
        public List<CategoryViewModel> Categories { get; set; }



    }
}
