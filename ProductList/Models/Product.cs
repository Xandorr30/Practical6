namespace ProductList.Models
    {
    public class Product
        {
        public int Id { get; set; }
        public string Name { get; set; }
        // Added supplierid to product class
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        }
    }