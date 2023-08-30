namespace SanatEvi.MVC.Models
{
    public class CourseDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int CurrentPerson { get; set; }
        public string TeacherName { get; set; }
        public string TeacherAbout { get; set; }
        public string TeacherUrl { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
       
    }
}
