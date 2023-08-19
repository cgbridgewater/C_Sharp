// https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=net-6.0

Product[] myProducts = new Product[]
{
    new Product { Name = "Jeans", Category = "Clothing", Price = 24.7},
    new Product { Name = "Socks", Category = "Clothing", Price = 8.12},
    new Product { Name = "Scooter", Category = "Vehicle", Price = 99.99},
    new Product { Name = "Skateboard", Category = "Vehicle", Price = 24.99},
    new Product { Name = "Skirt", Category = "Clothing", Price = 17.5}
};


IEnumerable<Product> sortProductsByPrice = myProducts.Where(c=> c.Category == "Clothing").OrderByDescending(prod => prod.Price);


foreach(Product item in sortProductsByPrice){
    Console.WriteLine($"Product: {item.Name}, Category: {item.Category}, Price: ${item.Price}");
}

double total = myProducts.Sum(p => p.Price);
Console.WriteLine("total price = $" + total);