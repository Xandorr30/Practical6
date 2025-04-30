namespace ProductList.Models
    {
    public class Category
        {
        public int Id { get; set; }
        public string Name { get; set; }
        // added supplier id to category class
        public int SupplierId { get; set; }
    }
    }