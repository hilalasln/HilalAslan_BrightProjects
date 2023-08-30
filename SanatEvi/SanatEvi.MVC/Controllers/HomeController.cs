using Microsoft.AspNetCore.Mvc;
using SanatEvi.MVC.Models;
using System.Diagnostics;
using SanatEvi.Business.Abstract;
using SanatEvi.Entity.Concrete;

namespace SanatEvi.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService _courseManager;

        public HomeController(ICourseService courseManager)
        {
            _courseManager = courseManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Course> courseList = await _courseManager.GetCoursesWithFullDataAsync(true, true);

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
    }
}