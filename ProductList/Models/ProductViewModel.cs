using System.Collections.Generic;

namespace ProductList.Models
    {
    public class ProductViewModel
        {
        // Added properties for selected supplier
        public int SelectedSupplierId { get; set; }

        public int SelectedCategoryId { get; set; }
        public int SelectedProductId { get; set; }

       // added supplier list
        public List<Supplier> Supplier { get; set; }

        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        }
    }