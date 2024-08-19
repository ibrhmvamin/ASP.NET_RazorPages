using ASP.NET_RazorPages.Entities;

namespace ASP.NET_RazorPages.Models
{
    public class ProductCategoryListViewModel
    {
        public IQueryable<ProductViewModel>? Products { get; set; }
        public IQueryable<CategoryViewModel>? Categories { get; set; }
    }
}
