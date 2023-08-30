using Microsoft.AspNetCore.Mvc;
using SanatEvi.Business.Abstract;
using SanatEvi.Entity.Concrete;
using SanatEvi.MVC.Models;

namespace SanatEvi.MVC.Controllers
{
    public class SanatEviController : Controller
    {
        private readonly ICourseService _courseManager;

        public SanatEviController(ICourseService courseManager)
        {
            _courseManager = courseManager;
        }

        public async Task<IActionResult> CourseList(string categoryurl = null, string teacherurl = null)
        {
            List<Course> courseList = await _courseManager.GetAllActiveCoursesAsync(categoryurl, teacherurl);
            List<CourseViewModel> courseViewModelList = courseList.Select(c => new CourseViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Price = c.Price,
                Url = c.Url,
                Duration = c.Duration,
                ImageUrl = c.ImageUrl,
                TeacherName = c.Teacher.FirstName + " " + c.Teacher.LastName,
                TeacherUrl = c.Teacher.Url,
            }).ToList();
            return View(courseViewModelList);
        }
        public async Task<IActionResult> CourseDetails(string url)
        {
            Course course = await _courseManager.GetCourseByUrlAsync(url);
            CourseDetailsViewModel courseDetailsViewModel = new CourseDetailsViewModel
            {
                Id = course.Id,
                Name = course.Name,
                TeacherName = course.Teacher.FirstName + " " + course.Teacher.LastName,
                TeacherAbout = course.Teacher.About,
                TeacherUrl = course.Teacher.Url,
                Url = course.Url,
                ImageUrl = course.ImageUrl,
                Description = course.Description,
                Duration = course.Duration,
                Price = course.Price,
                CurrentPerson = course.CurrentPerson,
                
                Categories = course.CourseCategories.Select(cc => new CategoryViewModel
                {
                    Name = cc.Category.Name,
                    Url = cc.Category.Url
                }).ToList()
            };
            return View(courseDetailsViewModel);
        }
    }
}

