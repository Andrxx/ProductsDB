namespace ProductsDB.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set;}
        public string country { get; set; }
        public int age { get; set; }
    }
}