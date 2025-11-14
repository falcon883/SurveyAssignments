using NUnit.Framework;
using System.Linq;

namespace OnlineStoreApp.Tests
{
    [TestFixture]
    public class OnlineStoreTests
    {
        private OnlineStore store;

        [SetUp]
        public void Setup()
        {
            store = new OnlineStore();
        }

        #region Test Indexer 1: Search by ProductId

        [Test]
        public void TestSearchByProductId_ValidId_ReturnsProduct()
        {
            // Arrange
            int productId = 12341;

            // Act
            Product result = store[productId];

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(12341, result.ProductId);
            Assert.AreEqual("Calculator", result.ProductName);
            Assert.AreEqual(24.95m, result.Price);
            Assert.AreEqual(Category.ELECTRONICS, result.Category);
        }

        [Test]
        public void TestSearchByProductId_InvalidId_ReturnsNull()
        {
            // Arrange
            int productId = 99999;

            // Act
            Product result = store[productId];

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void TestSearchByProductId_MultipleProducts_ReturnsCorrectOne()
        {
            // Arrange & Act
            Product sportsProduct = store[10001];
            Product booksProduct = store[20001];
            Product electronicsProduct = store[30002];

            // Assert
            Assert.AreEqual("Tennis Racket", sportsProduct.ProductName);
            Assert.AreEqual("C# Programming", booksProduct.ProductName);
            Assert.AreEqual("Wireless Mouse", electronicsProduct.ProductName);
        }

        #endregion

        #region Test Indexer 2: Search by ProductName

        [Test]
        public void TestSearchByProductName_ExactMatch_ReturnsProduct()
        {
            // Arrange
            string productName = "Calculator";

            // Act
            Product result = store[productName];

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(12341, result.ProductId);
            Assert.AreEqual("Calculator", result.ProductName);
        }

        [Test]
        public void TestSearchByProductName_CaseInsensitive_ReturnsProduct()
        {
            // Arrange
            string productName = "calculator";

            // Act
            Product result = store[productName];

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Calculator", result.ProductName);
        }

        [Test]
        public void TestSearchByProductName_NonExistent_ReturnsNull()
        {
            // Arrange
            string productName = "NonExistentProduct";

            // Act
            Product result = store[productName];

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void TestSearchByProductName_PartialMatch_ReturnsNull()
        {
            // Arrange
            string productName = "Calc"; // Partial name

            // Act
            Product result = store[productName];

            // Assert
            Assert.IsNull(result, "Exact name search should not return partial matches");
        }

        #endregion

        #region Test Indexer 3: Search by Partial Description

        [Test]
        public void TestSearchByPartialDescription_SingleMatch_ReturnsArray()
        {
            // Arrange
            string searchTerm = "solar";

            // Act
            Product[] results = store[searchTerm, true];

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Length);
            Assert.AreEqual("Calculator", results[0].ProductName);
            Assert.IsTrue(results[0].Description.ToLower().Contains("solar"));
        }

        [Test]
        public void TestSearchByPartialDescription_MultipleMatches_ReturnsArray()
        {
            // Arrange
            string searchTerm = "guide"; // Should match products with "guide" in description

            // Act
            Product[] results = store[searchTerm, true];

            // Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Length > 0);
            foreach (var product in results)
            {
                Assert.IsTrue(product.Description.ToLower().Contains(searchTerm.ToLower()));
            }
        }

        [Test]
        public void TestSearchByPartialDescription_CaseInsensitive_ReturnsMatches()
        {
            // Arrange
            string searchTermLower = "solar";
            string searchTermUpper = "SOLAR";

            // Act
            Product[] resultsLower = store[searchTermLower, true];
            Product[] resultsUpper = store[searchTermUpper, true];

            // Assert
            Assert.AreEqual(resultsLower.Length, resultsUpper.Length);
            Assert.AreEqual(1, resultsLower.Length);
        }

        [Test]
        public void TestSearchByPartialDescription_NoMatch_ReturnsEmptyArray()
        {
            // Arrange
            string searchTerm = "nonexistentterm";

            // Act
            Product[] results = store[searchTerm, true];

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(0, results.Length);
        }

        [Test]
        public void TestSearchByPartialDescription_CommonWord_ReturnsMultipleProducts()
        {
            // Arrange
            string searchTerm = "with"; // Common word in descriptions

            // Act
            Product[] results = store[searchTerm, true];

            // Assert
            Assert.IsNotNull(results);
            // Verify all returned products contain the search term
            foreach (var product in results)
            {
                Assert.IsTrue(product.Description.ToLower().Contains(searchTerm.ToLower()));
            }
        }

        #endregion

        #region Test Indexer 4: Search by Category

        [Test]
        public void TestSearchByCategory_Sports_ReturnsThreeProducts()
        {
            // Arrange
            Category category = Category.SPORTS;

            // Act
            Product[] results = store[category];

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(3, results.Length);
            foreach (var product in results)
            {
                Assert.AreEqual(Category.SPORTS, product.Category);
            }
        }

        [Test]
        public void TestSearchByCategory_Books_ReturnsThreeProducts()
        {
            // Arrange
            Category category = Category.BOOKS;

            // Act
            Product[] results = store[category];

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(3, results.Length);
            foreach (var product in results)
            {
                Assert.AreEqual(Category.BOOKS, product.Category);
            }
        }

        [Test]
        public void TestSearchByCategory_Electronics_ReturnsThreeProducts()
        {
            // Arrange
            Category category = Category.ELECTRONICS;

            // Act
            Product[] results = store[category];

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(3, results.Length);
            foreach (var product in results)
            {
                Assert.AreEqual(Category.ELECTRONICS, product.Category);
            }
            // Verify Calculator is included
            Assert.IsTrue(results.Any(p => p.ProductId == 12341));
        }

        [Test]
        public void TestSearchByCategory_AllCategories_ReturnCorrectCounts()
        {
            // Arrange & Act
            Product[] sportsProducts = store[Category.SPORTS];
            Product[] booksProducts = store[Category.BOOKS];
            Product[] electronicsProducts = store[Category.ELECTRONICS];

            // Assert
            Assert.AreEqual(3, sportsProducts.Length, "SPORTS should have 3 products");
            Assert.AreEqual(3, booksProducts.Length, "BOOKS should have 3 products");
            Assert.AreEqual(3, electronicsProducts.Length, "ELECTRONICS should have 3 products");
        }

        #endregion

        #region Integration Tests

        [Test]
        public void TestInitialization_TotalProductCount_NineProducts()
        {
            // Arrange & Act
            Product[] allProducts = store.GetAllProducts();

            // Assert
            Assert.AreEqual(9, allProducts.Length);
        }

        [Test]
        public void TestInitialization_EachCategoryHasThreeProducts()
        {
            // Arrange & Act
            Product[] allProducts = store.GetAllProducts();
            int sportsCount = allProducts.Count(p => p.Category == Category.SPORTS);
            int booksCount = allProducts.Count(p => p.Category == Category.BOOKS);
            int electronicsCount = allProducts.Count(p => p.Category == Category.ELECTRONICS);

            // Assert
            Assert.AreEqual(3, sportsCount);
            Assert.AreEqual(3, booksCount);
            Assert.AreEqual(3, electronicsCount);
        }

        #endregion
    }
}