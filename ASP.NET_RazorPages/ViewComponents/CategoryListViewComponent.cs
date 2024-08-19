using ASP.NET_RazorPages.Data;
using ASP.NET_RazorPages.Entities;
using ASP.NET_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ASP.NET_RazorPages.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ProductDbContext _context;

        public CategoryListViewComponent(ProductDbContext context)
        {
            _context = context;
        }

        public ViewViewComponentResult Invoke()
        {
            var categories = _context.Categories
                .Select(c => new CategoryViewModel { Title = c.Title });
            return View(
                new CategoryListViewModel
                {
                    Categories = categories
                });
        }
    }
}
