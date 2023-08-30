using SanatEvi.Business.Abstract;
using SanatEvi.Data.Abstract;
using SanatEvi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseManager(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task CheckCoursesCategories()
        {
            await _courseRepository.CheckCoursesCategories();
        }

        public async Task CreateAsync(Course course)
        {
           await _courseRepository.CreateAsync(course);
        }

        public async Task CreateCourseAsync(Course course, List<int> SelectedCategoryIds)
        {
            await _courseRepository.CreateCourseAsync(course, SelectedCategoryIds);
        }

        public void Delete(Course course)
        {
            _courseRepository.Delete(course);
        }

        public async Task<List<Course>> GetAllActiveCoursesAsync(string categoryUrl = null, string teacherUrl = null)
        {
            var result = await _courseRepository.GetAllActiveCoursesAsync(categoryUrl,teacherUrl);
            return result;
        }

        public async Task<List<Course>> GetAllAsync()
        {
           var result = await _courseRepository.GetAllAsync();
           return result;
        }

        public async Task<List<Course>> GetAllCoursesWithTeacher(bool isDeleted)
        {
            var result = await _courseRepository.GetAllCoursesWithTeacher(isDeleted);
            return result;
        }

        public async Task<Course> GetByIdAsync(int id)
        {
            var result = await _courseRepository.GetByIdAsync(id);
            return result;
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await _courseRepository.GetCourseByIdAsync(id);
        }

        public async Task<Course> GetCourseByUrlAsync(string courseUrl)
        {
            var result = await _courseRepository.GetCourseByUrlAsync(courseUrl);
            return result;
        }

        public async Task<List<Course>> GetCoursesWithFullDataAsync(bool? isHome = null, bool? isActive = null)
        {
            var result = await _courseRepository.GetCoursesWithFullDataAsync(isHome, isActive);
            return result;
        }


        public void Update(Course course)
        {
            _courseRepository.Update(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.UpdateCourse(course);
        }

        public async Task UpdateTeacherOfCourses()
        {
            await _courseRepository.UpdateTeacherOfCourses();
        }
    }
}
