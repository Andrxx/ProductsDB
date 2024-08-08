using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsDB.Models;
using ProductsDB.Services;

namespace ProductsDB.Pages
{
    public class AddToDBModel : PageModel
    {
        ApplicationDB context { get; set; }
        [BindProperty]
        public Product newProduct { get; set; }
        [BindProperty]
        public Category newCategory { get; set; }
        [BindProperty]
        public List<Product> products { get; set; } = new();
        [BindProperty]
        public List<Category> categories { get; set; } = new();

        public AddToDBModel(ApplicationDB applicationDB) 
        {
            context = applicationDB;
        }   
        public void OnGet()
        {
            products = ProductsServices.GetProducts(context);
            categories = ProductsServices.GetCategories(context);
        }

        public IActionResult OnPostSaveProduct(Product newProduct)
        {
            ProductsServices.AddProduct(context, newProduct);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostSaveCategory(Category newCategory)
        {
            ProductsServices.AddCategory(context, newCategory);
            return RedirectToAction("Get");
        }
    }
}
