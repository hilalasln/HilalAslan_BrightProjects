using SanatEvi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Data.Abstract
{
    public interface ICourseRepository:IGenericRepository<Course>
    {
        Task<List<Course>> GetCoursesWithFullDataAsync(bool? isHome = null, bool? isActive = null);
        Task<List<Course>> GetAllActiveCoursesAsync(string categoryUrl = null, string teacherUrl = null);
        Task<Course> GetCourseByUrlAsync(string courseUrl);
        Task<Course> GetCourseByIdAsync(int id);
        Task<List<Course>> GetAllCoursesWithTeacher(bool isDeleted);
        Task CreateCourseAsync(Course course, List<int> SelectedCategoryIds);
        Task UpdateTeacherOfCourses();
        Task CheckCoursesCategories();
        void UpdateCourse(Course course);
    }
}
