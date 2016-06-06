using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemLazyObject
{
    public class Product
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public Product()
        {
            Thread.Sleep(5000);
        }

        public static IList<Lazy<Product>> GetProductLazyListLazy()
        {
            var list = new List<Lazy<Product>>();
            var product1 = new Lazy<Product>(() =>
            new Product { Id = 1, Title = "Product 1" });
            list.Add(product1);
            var product2 = new Lazy<Product>(() =>
            new Product { Id = 2, Title = "Product 2" });
            list.Add(product2);
            var product3 = new Lazy<Product>(() =>
            new Product { Id = 3, Title = "Product 3" });
            list.Add(product3);
            return list;
        }

        public static IList<Product> GetProductList()
        {
            var product1 = new Product
            {
                Id = 1,
                Title = "Product 1"
            };
            var product2 = new Product
            {
                Id = 2,
                Title = "Product 2"
            };
            var product3 = new Product
            {
                Id = 3,
                Title = "Product 3"
            };

            return new List<Product>(new[] { product1, product2, product3 });

        }
    }
}
