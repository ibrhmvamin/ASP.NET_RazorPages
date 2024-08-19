﻿using ASP.NET_RazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_RazorPages.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly ProductDbContext _context;

        public IndexModel(ProductDbContext context)
        {
            _context = context;
        }

        public List<Entities.Product> Products { get; set; } = new List<Entities.Product>();

        public string Info { get; set; }

        [BindProperty]
        public Entities.Product Product { get; set; }

        public void OnGet(string info = "")
        {
            Products = _context.Products.ToList();
            Info = info;
        }

        public IActionResult OnPost()
        {
            if (Product.Id == 0)
            {
                _context.Products.Add(Product);
                Info = $"{Product.Name} added successfully";
            }
            else
            {
                var existingProduct = _context.Products.Find(Product.Id);
                if (existingProduct != null)
                {
                    existingProduct.Name = Product.Name;
                    existingProduct.Price = Product.Price;
                    Info = $"{Product.Name} updated successfully";
                }
                else
                {
                    Info = "Product not found";
                }
            }

            _context.SaveChanges();
            return RedirectToPage("Index", new { info = Info });
        }

        public IActionResult OnGetEdit(int id)
        {
            Product = _context.Products.Find(id);

            if (Product == null)
            {
                Info = "Product not found";
                return RedirectToPage("Index", new { info = Info });
            }

            return Page();
        }

        public IActionResult OnGetDelete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                Info = $"{product.Name} deleted successfully";
            }
            else
            {
                Info = "Product not found";
            }

            return RedirectToPage("Index", new { info = Info });
        }
    }
}
