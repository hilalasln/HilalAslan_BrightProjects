using Microsoft.AspNetCore.Mvc;
using SanatEvi.Business.Abstract;
using SanatEvi.Entity.Concrete;
using SanatEvi.MVC.Models;

namespace SanatEvi.MVC.ViewComponents
{
    public class CategoriesViewComponent: ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
            if (RouteData.Values["categoryurl"] != null)
            {
                categoryListViewModel.SelectedCategoryUrl = RouteData.Values["categoryurl"].ToString();
            }
            else
            {
                categoryListViewModel.SelectedCategoryUrl = "";
            }

            List<Category> categories = await _categoryManager.GetAllAsync();
            List<CategoryViewModel> categoryViewModelList = categories
                .Select(c => new CategoryViewModel
                {
                    Name = c.Name,
                    Url = c.Url
                }).ToList();

            categoryListViewModel.CategoryViewModelList = categoryViewModelList;

            return View(categoryListViewModel);
        }
    }
}
