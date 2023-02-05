//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//class Program
//{
//    static void Main(string[] args)
//    {
//        var services = new ServiceCollection();
//        //ConfigureServices(services);

//        var serviceProvider = services.BuildServiceProvider();
//        // Use the service provider to resolve services as needed in your application
//    }

//    //private static void ConfigureServices(IServiceCollection services)
//    //{
//    //    services.AddControllers();

//    //    var configuration = new ConfigurationBuilder()
//    //        .SetBasePath(Directory.GetCurrentDirectory())
//    //        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//    //        .Build();

//    //    services.AddSingleton<IConfiguration>(configuration);
//    //}
//}


#region add product

using PizzaApp.Data;
using PizzaApp.Models;

using PizzaAppContext db = new PizzaAppContext();

//Product phillyCheeseSpecial = new Product()
//{
//    Name = "Philly Cheese Steak Pizza",
//    Price = 6.98M
//};
////db.Add(phillyCheeseSpecial);

//Product pinappleSpecial = new Product()
//{
//    Name = "Pinapple Pizza",
//    Price = 8.99M
//};

////db.Add(pinappleSpecial);
//var productt = db.Products
//    .Where(p => p.Name == phillyCheeseSpecial.Name).FirstOrDefault();

//if (phillyCheeseSpecial != productt)
//{
//    productt.Price = 5.99M;
//}

//db.SaveChanges();

#endregion

//fluent api
//var products = db.Products
//                .Where(p => p.Price <= 9.99M)
//                .OrderBy(p => p.Name);


//linq
var products = from product in db.Products
               where product.Price <= 9.99M
               orderby product.Name
               select product;

foreach (var product in products)
{
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(new string('-', 20));
}