namespace ASP.NET_RazorPages.Models
{
    public class CategoryListViewModel
    {
        public IQueryable<CategoryViewModel>? Categories { get; set; }
    }
}
