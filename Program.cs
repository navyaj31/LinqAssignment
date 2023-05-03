using linqexercise;

namespace linqexercise
{
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        
        public void SeedData(List<Product> products)
        {
            /*products = new List<Product>();
             {*/
            products.Add(new Product { ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 });
            products.Add(new Product { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 });
            products.Add(new Product { ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000 });
            products.Add(new Product { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 });
            products.Add(new Product { ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500 });
        }

    }
}
   internal class Program
   {
      static void Main(string[] args)
      {
        List<Product> products = new List<Product>();
        Product p = new Product();
        p.SeedData(products);

        //query1
        Console.WriteLine("retring the Product names from Product List where Price is between 20000 to 40000 :");
        var query1 = products.Where(p => p.Price > 20000 & p.Price < 40000);
        int i = 1;
        foreach (var item in query1)
        {
            Console.WriteLine($"{i++}.{item.ProductName}");
        }
        //query2
        Console.WriteLine("retrieving the data from Product List where ProductName contains letter a");
        var query2 = products.Where(p => p.ProductName.ToLower().Contains('a'));
        int i1 = 1;
        foreach (var item in query2)
        {
            Console.WriteLine($"{i1++}.");
            Console.WriteLine($"ProductID : {item.ProductId}\nProductName : {item.ProductName}\nBrand : {item.Brand}\nQuantity : {item.Quantity}\nPrice : {item.Price}");
        }
        //query3
        Console.WriteLine("retrieving all data from Product List arranged in alphabetical order based on ProductName :");
        var query3 = products.OrderBy(p => p.ProductName);

        int i2 = 1;
        foreach (var item in query3)
        {
            Console.WriteLine($"{i2++}.");
            Console.WriteLine($"ProductID : {item.ProductId}\nProductName : {item.ProductName}\nBrand : {item.Brand}\nQuantity : {item.Quantity}\nPrice : {item.Price}");
        }
        //query4
        Console.WriteLine("retrieving the highest Price from Product List :");
        var query4 = products.Max(p => p.Price);
        Console.WriteLine($"Highest Price in the List : {query4}");

        //query5
        Console.WriteLine("Product with ProductId P003 exists in Product List or not :");
        var query5 = products.Any(p => p.ProductId == "P003");
        Console.WriteLine(query5);


      }
   }

