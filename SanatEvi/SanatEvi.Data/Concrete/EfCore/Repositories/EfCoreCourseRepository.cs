using Microsoft.EntityFrameworkCore;
using SanatEvi.Data.Abstract;
using SanatEvi.Data.Concrete.EfCore.Contexts;
using SanatEvi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Data.Concrete.EfCore.Repositories
{

    public class EfCoreCourseRepository : EfCoreGenericRepository<Course>, ICourseRepository
    {
        public EfCoreCourseRepository(SanatEviContext _context) : base(_context)
        {

        }
        private SanatEviContext Context
        {
            get { return _dbContext as SanatEviContext; }
        }
        public async Task CheckCoursesCategories()
        {
            var courseCategoryIds = await Context
               .CourseCategories
               .Select(cc => cc.CourseId)
               .Distinct()
               .ToListAsync();
            var courseIds = await Context
                .Courses
                .Select(c => c.Id)
                .ToListAsync();
            List<int> different = courseIds.Except(courseCategoryIds).ToList();
            await Context.CourseCategories.AddRangeAsync(different.Select(d => new CourseCategory
            {
                CourseId = d,
                CategoryId = 1
            }).ToList());
            await Context.SaveChangesAsync();
        }

        public async Task CreateCourseAsync(Course course, List<int> SelectedCategoryIds)
        {
            await Context.Courses.AddAsync(course);
            await Context.SaveChangesAsync();
            course.CourseCategories = SelectedCategoryIds.Select(sc => new CourseCategory
            {
                CourseId = course.Id,
                CategoryId = sc
            }).ToList();
            Context.Courses.Update(course);
            await Context.SaveChangesAsync();
        }

        public async Task<List<Course>> GetAllActiveCoursesAsync(string categoryUrl = null, string teacherUrl = null)
        {
            var result = Context
                .Courses
                .Where(c => c.IsActive && !c.IsDeleted)
                .Include(c => c.Teacher)
                .AsQueryable();
            if (categoryUrl != null)
            {
                result = result
                    .Include(c => c.CourseCategories)
                    .ThenInclude(cc => cc.Category)
                    .Where(c => c.CourseCategories.Any(cc => cc.Category.Url == categoryUrl))
                    .AsQueryable();
            }
            if (teacherUrl != null)
            {
                result = result
                    .Where(c => c.Teacher.Url == teacherUrl)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

        public async Task<List<Course>> GetAllCoursesWithTeacher(bool isDeleted)
        {
            var result = await Context
                .Courses
                .Where(c => c.IsDeleted == isDeleted)
                .Include(c => c.Teacher)
                .ToListAsync();
            return result;
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var result = await Context
               .Courses
               .Where(c => c.IsActive && !c.IsDeleted && c.Id == id)
               .Include(c => c.CourseCategories)
               .ThenInclude(cc => cc.Category)
               .Include(c => c.Teacher)
               .FirstOrDefaultAsync();
            return result;
        }

        public async Task<Course> GetCourseByUrlAsync(string courseUrl)
        {
            var result = await Context
               .Courses
               .Where(c => c.IsActive && !c.IsDeleted && c.Url == courseUrl)
               .Include(c => c.CourseCategories)
               .ThenInclude(cc => cc.Category)
               .Include(c => c.Teacher)
               .FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Course>> GetCoursesWithFullDataAsync(bool? isHome = null, bool? isActive = null)
        {
            var result = Context
                .Courses
                .Where(c => !c.IsDeleted)
                .AsQueryable();

            if (isHome != null)
            {
                result = result
                    .Where(c => c.IsHome == isHome)
                    .AsQueryable();
            }

            if (isActive != null)
            {
                result = result
                    .Where(c => c.IsActive == isActive)
                    .AsQueryable();
            }
            result = result
                .Include(c => c.CourseCategories)
                .ThenInclude(cc => cc.Category)
                .Include(c => c.Teacher)
                .AsQueryable();

            return await result.ToListAsync();
        }

        public void UpdateCourse(Course course)
        {
            Course oldCourse = Context
                .Courses
                .Include(c => c.CourseCategories)
                .ThenInclude(cc => cc.Category)
                .Include(c => c.Teacher)
                .Where(c => c.Id == course.Id)
                .FirstOrDefault();
            oldCourse.Name = course.Name;
            oldCourse.Description = course.Description;
            oldCourse.Price = course.Price;
            oldCourse.CurrentPerson = course.CurrentPerson;
            oldCourse.Duration = course.Duration;
            oldCourse.IsActive = course.IsActive;
            oldCourse.IsHome = course.IsHome;
            oldCourse.IsDeleted = course.IsDeleted;
            oldCourse.TeacherId = course.TeacherId;
            oldCourse.Url = course.Url;
            oldCourse.ModifiedDate = DateTime.Now;
            oldCourse.CourseCategories = course.CourseCategories;
            oldCourse.ImageUrl = course.ImageUrl;

            Context.Courses.Update(oldCourse);
            Context.SaveChanges();
        }

        public async Task UpdateTeacherOfCourses()
        {
            var courses = await Context
                 .Courses
                 .Where(c => c.TeacherId == null)
                 .ToListAsync();
            foreach (var course in courses)
            {
                course.TeacherId = 5;
            };
            Context.Courses.UpdateRange(courses);
            await Context.SaveChangesAsync();
        }
    }
}
