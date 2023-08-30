using SanatEvi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Data.Abstract
{
    public interface ITeacherRepository : IGenericRepository<Teacher>
    {
        Task<List<Teacher>> GetAllTeachersAsync(bool isDeleted, bool? isActive = null);
        Task CreateWithUrl(Teacher teacher);
        Task<List<Teacher>> GetAllActiveTeachersAsync(string categoryUrl, string courseUrl);
        Task<Teacher> GetTeachersByUrlAsync(string url);
        Task<List<Teacher>> GetTeachersWithFullDataAsync(bool? isActive);
    }
}
