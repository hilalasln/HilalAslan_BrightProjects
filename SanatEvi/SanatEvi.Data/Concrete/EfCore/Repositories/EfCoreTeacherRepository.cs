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
    public class EfCoreTeacherRepository : EfCoreGenericRepository<Teacher>, ITeacherRepository
    {
        public EfCoreTeacherRepository(SanatEviContext _context) : base(_context)
        {

        }

        private SanatEviContext Context
        {
            get { return _dbContext as SanatEviContext; }
        }

        public async Task CreateWithUrl(Teacher teacher)
        {
            await Context.Teachers.AddAsync(teacher);
            await Context.SaveChangesAsync();
            teacher.Url = teacher.Url + "-" + teacher.Id;
            await Context.SaveChangesAsync();
        }

        public async Task<List<Teacher>> GetAllActiveTeachersAsync(string categoryUrl, string courseUrl)
        {
            var result = Context
                .Teachers
                .Where(t => t.IsActive && !t.IsDeleted)
                .Include(t => t.Courses)
                .AsQueryable();
            if (categoryUrl != null)
            {
                result = result
                    .Include(t => t.Courses)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

        public async Task<List<Teacher>> GetAllTeachersAsync(bool isDeleted, bool? isActive = null)
        {
            var result = Context
               .Teachers
               .Where(t => t.IsDeleted == isDeleted)
               .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(t => t.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

        public async  Task<Teacher> GetTeachersByUrlAsync(string url)
        {
            var result = await Context
                  .Teachers
                  .Where(t => t.IsActive && !t.IsDeleted && t.Url == url)
                  .FirstOrDefaultAsync();
            return result;
        }

        public async  Task<List<Teacher>> GetTeachersWithFullDataAsync(bool? isActive)
        {
            var result = Context
               .Teachers
               .Where(t => !t.IsDeleted)
               .AsQueryable();

            if (isActive != null)
            {
                result = result
                    .Where(t => t.IsActive == isActive)
                    .AsQueryable();
            }
            result = result
                .Include(t => t.Courses)
                .AsQueryable();

            return await result.ToListAsync();
        }
    }
}
