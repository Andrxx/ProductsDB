using ProductsDB.Models;

namespace ProductsDB.Services
{
    public static class CustomerServices
    {
        public static void AddCustomer(ApplicationDB context, Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public static List<Customer> GetCustomers(ApplicationDB context) 
        {
            return (from customer in context.Customers
                    select customer).ToList(); 
        }
    }
}
