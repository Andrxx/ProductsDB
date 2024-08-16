using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsDB.Models
{
    [NotMapped]
    public class JoinedData
    {
        public string ProductName {  get; set; }
        public string ProductDescription { get; set; }
        public string CategoryName { get; set; }
    }
}
