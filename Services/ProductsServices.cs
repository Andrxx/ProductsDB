using ProductsDB.Models;

namespace ProductsDB.Services
{
    public static class ProductsServices
    {
        public static List<Product> GetProducts(ApplicationDB context)
        {
            //List<Product> products = new();
            //products = 
            return (from product in context.Products
                    select product).ToList();
        }

        public static void AddProduct(ApplicationDB context, Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public static Product GetProduct(ApplicationDB context, int id)
        {
            return (from product in context.Products
                    where product.Id == id
                    select product).FirstOrDefault();
        }
             


        public static List<Category> GetCategories(ApplicationDB context)
        {
            List<Category> categories = new();
            categories = (from category in context.Categories
                        orderby category.Id
                        select category).ToList();
            return categories;
        }

        public static void AddCategory(ApplicationDB context, Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }


    }
}
