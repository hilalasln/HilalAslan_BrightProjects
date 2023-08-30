using Microsoft.AspNetCore.Mvc;
using SanatEvi.Business.Abstract;
using SanatEvi.Entity.Concrete;
using SanatEvi.MVC.Models;

namespace SanatEvi.MVC.ViewComponents
{
    public class TeachersViewComponent:ViewComponent
    {

        private readonly ITeacherService _teacherManager;

        public TeachersViewComponent(ITeacherService teacherManager)
        {
            _teacherManager = teacherManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Teacher> teacherList = await _teacherManager.GetAllAsync();
            List<TeacherViewModel> teacherViewModelList = teacherList.Select(t => new TeacherViewModel
            {
                Name = t.FirstName + " " + t.LastName,
                Url = t.Url
            }).ToList();
            return View(teacherViewModelList);
        }
    }
}
