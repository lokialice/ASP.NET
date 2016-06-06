using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLazyObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            IList<Product> list = Product.GetProductList();
            Console.WriteLine(watch.Elapsed.Seconds);
            Console.WriteLine("Total products in my list: " + list.Count());

            watch = Stopwatch.StartNew();
            var listTemps = Product.GetProductLazyListLazy();
            Console.WriteLine(watch.Elapsed.Seconds);
            Console.WriteLine("Total products in my GetProductLazyListLazy: " + listTemps.Count());
            watch = Stopwatch.StartNew();
            foreach (var item in listTemps)
            {
                var itemTitle = item.Value.Title;
            }
            Console.WriteLine("Foreach {0}", watch.Elapsed.Seconds);
            Console.ReadLine();
        }
    }
}
