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
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherManager(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task CreateAsync(Teacher teacher)
        {
            await _teacherRepository.CreateAsync(teacher);
        }

        public async Task CreateWithUrl(Teacher teacher)
        {
            await _teacherRepository.CreateWithUrl(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _teacherRepository.Delete(teacher);
        }

        public Task<List<Teacher>> GetAllActiveTeachersAsync(string categoryUrl = null, string teacherUrl = null)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            var result = await _teacherRepository.GetAllAsync();
            return result;

        }

        public async Task<List<Teacher>> GetAllTeachersAsync(bool isDeleted, bool? isActive = null)
        {
            var result = await _teacherRepository.GetAllTeachersAsync(isDeleted, isActive);
            return result;
        }

        public async Task<Teacher> GetByIdAsync(int id)
        {
            var result = await _teacherRepository.GetByIdAsync(id);
            return result;
        }

        public async Task<Teacher> GetTeachersByUrlAsync(string teacherUrl)
        {
            var result = await _teacherRepository.GetTeachersByUrlAsync(teacherUrl);
            return result;
        }
        public async Task<List<Teacher>> GetTeachersWithFullDataAsync(bool? isActive = null)
        {
            var result = await _teacherRepository.GetTeachersWithFullDataAsync(isActive);
            return result;
        }
        public void Update(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }
    }
}
