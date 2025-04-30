using System.Collections.Generic;

namespace ProductList.Models
    {
    public class ProductRepository
        {
        //Added Supplier Class
        public static List<Supplier> GetSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier { Id = 1, Name = "Supplier 1" },
                new Supplier { Id = 2, Name = "Supplier 2" },
                new Supplier { Id = 3, Name = "Supplier 3" },
           
            };
        }

        // Added supplierId to the Category class and new categories


        public static List<Category> GetCategories()
            {
            return new List<Category>
    {
        new Category { Id = 1, Name = "Category 1", SupplierId = 1 },
        new Category { Id = 2, Name = "Category 2", SupplierId = 1 },
        new Category { Id = 3, Name = "Category 3", SupplierId = 1 },
        new Category { Id = 4, Name = "Category 4", SupplierId = 2 },
        new Category { Id = 5, Name = "Category 5", SupplierId = 2 },
        new Category { Id = 6, Name = "Category 6", SupplierId = 2 },
        new Category { Id = 7, Name = "Category 7", SupplierId = 3 },
        new Category { Id = 8, Name = "Category 8", SupplierId = 3 },
        new Category { Id = 9, Name = "Category 9", SupplierId = 3 },
    };
            }


        // Added supplierId to the Product class and new products
        public static List<Product> GetProducts()
            {
            return new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", SupplierId = 1, CategoryId = 1 },
        new Product { Id = 2, Name = "Product 2", SupplierId = 1, CategoryId = 1 },
        new Product { Id = 3, Name = "Product 3", SupplierId = 1, CategoryId = 2 },
        new Product { Id = 4, Name = "Product 4", SupplierId = 1, CategoryId = 3 },
        new Product { Id = 5, Name = "Product 5", SupplierId = 1, CategoryId = 3 },
        new Product { Id = 6, Name = "Product 6", SupplierId = 2, CategoryId = 4 },
        new Product { Id = 7, Name = "Product 7", SupplierId = 2, CategoryId = 4 },
        new Product { Id = 8, Name = "Product 8", SupplierId = 2, CategoryId = 5 },
        new Product { Id = 9, Name = "Product 9", SupplierId = 2, CategoryId = 5 },
        new Product { Id = 10, Name = "Product 10", SupplierId = 2, CategoryId = 6 },
        new Product { Id = 11, Name = "Product 11", SupplierId = 2, CategoryId = 6 },
        new Product { Id = 12, Name = "Product 12", SupplierId = 3, CategoryId = 7 },
        new Product { Id = 13, Name = "Product 13", SupplierId = 3, CategoryId = 7 },
        new Product { Id = 14, Name = "Product 14", SupplierId = 3, CategoryId = 8 },
        new Product { Id = 15, Name = "Product 15", SupplierId = 3, CategoryId = 8 },
        new Product { Id = 16, Name = "Product 16", SupplierId = 3, CategoryId = 9 },
    };
            }
        }
    }