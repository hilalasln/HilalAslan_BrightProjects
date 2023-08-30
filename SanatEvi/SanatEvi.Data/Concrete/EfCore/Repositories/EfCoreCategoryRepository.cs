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
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(SanatEviContext _context) : base(_context)
        {

        }
        private SanatEviContext Context
        {
            get { return _dbContext as SanatEviContext; }
        }
        public async Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                 .Categories
                 .Where(c => c.IsDeleted == isDeleted)
                 .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(c => c.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
