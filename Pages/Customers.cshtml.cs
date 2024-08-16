using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsDB.Models;
using ProductsDB.Services;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace ProductsDB.Pages
{
    public class CustomersModel : PageModel
    {
        ApplicationDB context { get; set; }
        public List<Customer> customers { get; set; } = new List<Customer>();
        public CustomersModel(ApplicationDB applicationDB) {
            context = applicationDB;
        }
        public void OnGet()
        {
            //CustomerServices.AddCustomer(context, new Customer { age = 31, country = "USA", first_name = "John", last_name = "Doe" });
            //CustomerServices.AddCustomer(context, new Customer { age = 22, country = "USA", first_name = "Robert", last_name = "Luna" });
            //CustomerServices.AddCustomer(context, new Customer { age = 22, country = "UK", first_name = "David", last_name = "Robinson" });
            //CustomerServices.AddCustomer(context, new Customer { age = 25, country = "UK", first_name = "John", last_name = "Reinhart" });
            //CustomerServices.AddCustomer(context, new Customer { age = 28, country = "UAE", first_name = "Betty", last_name = "Doe" });

            customers = CustomerServices.GetCustomers(context);
        }
    }
}
