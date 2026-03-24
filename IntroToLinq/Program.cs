using IntroToLinq.Data;
using IntroToLinq.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new();

            // Read, Filter Rows
            //var customers = db.Customers.AsQueryable();

            //customers = customers.Where(e => e.State == "CA" || e.State == "NY");
            //customers = customers.Where(e => e.CustomerId >= 10 && e.CustomerId <= 100);
            //customers = customers.Where(e => e.Phone == null);
            //customers = customers.Where(e => e.Email.Contains("@yahoo.com"));

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"Id: {item.CustomerId}, Name: {item.FirstName} {item.LastName}, State: {item.State}");
            //}

            // Read, Filter one row

            //try
            //{
            //var customer = db.Customers.First(e => e.State == "NY");
            //var customer = db.Customers.Single(e => e.CustomerId == 1);

            //Console.WriteLine($"Id: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}, State: {customer.State}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message.ToString()}");
            //}

            //var customer = db.Customers.FirstOrDefault(e => e.State == "NY");
            //var customer = db.Customers.SingleOrDefault(e => e.CustomerId == 1);

            //var customer = db.Customers.Find(1);

            //if (customer is not null)
            //Console.WriteLine($"Id: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}, State: {customer.State}");

            // Read, Ordering, Pagination
            //var products = db.Products
            //    .Where(e => e.ListPrice >= 100)
            //    .OrderBy(e => e.ModelYear)
            //    .ThenByDescending(e => e.ListPrice)
            //    .Skip(0)
            //    .Take(10);

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"Id: {item.ProductId}, Model Year: {item.ModelYear}, Price: {item.ListPrice}");
            //}

            // Read, Filter Columns
            //var customers = db.Customers.AsQueryable()
            //    .Select(e => new
            //    {
            //        e.CustomerId, 
            //        FullName = $"{e.FirstName} {e.LastName}",
            //        e.State
            //    });

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"Id: {item.CustomerId}, Name: {item.FullName}, State: {item.State}");
            //}

            // Read, Join
            //var orderWithCustomers = db.Orders.Join(
            //    db.Customers,
            //    o => o.CustomerId,
            //    c => c.CustomerId,
            //    (o, c) => new
            //    {
            //        o.OrderId,
            //        o.OrderDate,
            //        o.OrderStatus,
            //        FullName = $"{c.FirstName} {c.LastName}"
            //    });

            //var orderWithCustomers = db.Orders
            //  //  .Include(e=>e.Customer)
            //    //.Include(e=>e.Store)
            //    //.Include(e=>e.Staff)
            //    .Select(e=> new
            //{
            //    e.OrderId,
            //    e.OrderDate,
            //    e.OrderStatus,
            //    e.Store.StoreName,
            //    CustomerFullName = $"{e.Customer!.FirstName} {e.Customer.LastName}",
            //    StaffFullName = $"{e.Staff!.FirstName} {e.Staff.LastName}",
            //});

            //foreach (var item in orderWithCustomers)
            //{
            //    Console.WriteLine($"Id: {item.OrderId}, Date: {item.OrderDate}, Status: {item.OrderStatus}, Customer Name: {item.CustomerFullName}, Staff Name: {item.StaffFullName} StoreName: {item.StoreName}");
            //}

            //var orderWithCustomers = db.Orders.ToList();

            //foreach (var item in orderWithCustomers)
            //{
            //    Console.WriteLine($"Id: {item.OrderId}, Date: {item.OrderDate}, Status: {item.OrderStatus}, Customer Name: {item.Customer.FirstName} {item.Customer.LastName}");
            //}

            // Read, Group BY (count/min/max/avg/sum)

            //var result = db.Customers.GroupBy(e => e.State).Select(g => new
            //{
            //    state = g.Key,
            //    count = g.Count()
            //});

            //var result = db.Products
            //    .GroupBy(e => e.ModelYear)
            //    .Select(g => new
            //    {
            //        ModelYear = g.Key,
            //        Avg = g.Average(e => e.ListPrice),
            //        Min = g.Min(e => e.ListPrice),
            //        Max = g.Max(e => e.ListPrice),
            //    });
                                                                    

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"state: {item.ModelYear}, Avg: {item.Avg.ToString("c")}, Min: {item.Min.ToString("c")}, Max: {item.Max.ToString("c")}");
            //}
        }
    }
}
