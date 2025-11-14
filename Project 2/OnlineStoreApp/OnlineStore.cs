using System;
using System.Linq;

namespace OnlineStoreApp
{
    public class OnlineStore
    {
        private Product[] products;

        public OnlineStore()
        {
            // Initialize 9 products - 3 from each category
            products = new Product[]
            {
                // SPORTS products
                new Product(10001, "Tennis Racket", 89.99m, Category.SPORTS, "Professional grade carbon fiber tennis racket"),
                new Product(10002, "Basketball", 29.99m, Category.SPORTS, "Official size leather basketball"),
                new Product(10003, "Yoga Mat", 24.99m, Category.SPORTS, "Non-slip eco-friendly yoga mat"),
                
                // BOOKS products
                new Product(20001, "C# Programming", 49.99m, Category.BOOKS, "Complete guide to C# programming language"),
                new Product(20002, "Data Structures", 59.99m, Category.BOOKS, "Advanced data structures and algorithms"),
                new Product(20003, "Clean Code", 44.99m, Category.BOOKS, "Best practices for writing clean maintainable code"),
                
                // ELECTRONICS products
                new Product(12341, "Calculator", 24.95m, Category.ELECTRONICS, "Solar powered Scientific calculator"),
                new Product(30002, "Wireless Mouse", 19.99m, Category.ELECTRONICS, "Ergonomic wireless optical mouse"),
                new Product(30003, "USB Hub", 15.99m, Category.ELECTRONICS, "4-port USB 3.0 hub with power adapter")
            };
        }

        // Indexer 1: Search by ProductId
        public Product this[int productId]
        {
            get
            {
                return products.FirstOrDefault(p => p.ProductId == productId);
            }
        }

        // Indexer 2: Search by ProductName (exact match, case-insensitive)
        public Product this[string productName]
        {
            get
            {
                return products.FirstOrDefault(p =>
                    p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));
            }
        }

        // Indexer 3: Search by partial description (case-insensitive)
        public Product[] this[string searchTerm, bool isPartialSearch]
        {
            get
            {
                if (isPartialSearch)
                {
                    return products.Where(p =>
                        p.Description.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToArray();
                }
                return new Product[0];
            }
        }

        // Indexer 4: Search by Category
        public Product[] this[Category category]
        {
            get
            {
                return products.Where(p => p.Category == category).ToArray();
            }
        }

        // Helper method to get all products
        public Product[] GetAllProducts()
        {
            return products;
        }
    }
}