using System;

namespace OnlineStoreApp
{
    public enum Category
    {
        SPORTS,
        BOOKS,
        ELECTRONICS
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }

        public Product(int productId, string productName, decimal price, Category category, string description)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Category = category;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Price: ${Price}, Category: {Category}, Description: {Description}";
        }
    }
}