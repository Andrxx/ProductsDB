using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ProductsDB.Models;
using ProductsDB.Services;

namespace ProductsDB.Pages
{
    public class IndexModel : PageModel
    {
        ApplicationDB context { get; set; }
        
        public List<JoinedData> allProducts, productsByCategory;

        public IndexModel(ApplicationDB applicationDB)
        {
            context = applicationDB;
        }

        public void OnGet()
        {
            allProducts = ProductsServices.GetJoinedData(context);
            productsByCategory = ProductsServices.GetJoinedData(context, 1);
        }
    }
}