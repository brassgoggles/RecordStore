using HelloWuld.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWuld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List population

            #region Populated in order
            //List<Album> albums = new List<Album>()
            //{
            //    new Album(1, "Shiesty Season", new DateTime(2020, 1, 1), 10),
            //    new Album(2, "Fine Line", new DateTime(2021, 1, 1), 10),
            //    new Album(3, "My Turn", new DateTime(2019, 1, 1), 20),
            //    new Album(4, "Hollywood's Bleeding", new DateTime(2020, 1, 1), 15)
            //};

            //List<AlbumSale> albumSales = new List<AlbumSale>()
            //{
            //    new AlbumSale(1, 1, 1),
            //    new AlbumSale(2, 2, 1),
            //    new AlbumSale(3, 2, 1),
            //    new AlbumSale(4, 4, 1),

            //    new AlbumSale(5, 3, 2),

            //    new AlbumSale(6, 3, 3),
            //    new AlbumSale(7, 2, 3),
            //    new AlbumSale(8, 4, 3),

            //    new AlbumSale(9, 3, 4),
            //    new AlbumSale(10, 1, 4)
            //};

            //List<SalesPerson> salesPersons = new List<SalesPerson>()
            //{
            //    new SalesPerson(1, "John Smith"),
            //    new SalesPerson(2, "Sandy Doe")
            //};

            //List<Sale> sales = new List<Sale>()
            //{
            //    new Sale(1, 2, 45), // Sandy Doe
            //    new Sale(2, 1, 10), // John Smith
            //    new Sale(3, 2, 45), // Sandy Doe
            //    new Sale(4, 1, 30), // John Smith
            //}; 
            #endregion

            #region Populated out of order

            List<Album> albums = new List<Album>()
            {
                new Album(2, "Fine Line", new DateTime(2021, 1, 1), 10),
                new Album(4, "Hollywood's Bleeding", new DateTime(2020, 1, 1), 15),
                new Album(3, "My Turn", new DateTime(2019, 1, 1), 20),
                new Album(1, "Shiesty Season", new DateTime(2020, 1, 1), 10)                
            };

            List<AlbumSale> albumSales = new List<AlbumSale>()
            {
                new AlbumSale(9, 3, 4),
                new AlbumSale(10, 1, 4),

                new AlbumSale(1, 1, 1),
                new AlbumSale(2, 2, 1),
                new AlbumSale(3, 2, 1),
                new AlbumSale(4, 4, 1),

                new AlbumSale(6, 3, 3),
                new AlbumSale(7, 2, 3),
                new AlbumSale(8, 4, 3),

                new AlbumSale(5, 3, 2),
                new AlbumSale(11, 3, 2)
            };

            List<SalesPerson> salesPersons = new List<SalesPerson>()
            {
                new SalesPerson(1, "John Smith"),
                new SalesPerson(2, "Sandy Doe")
            };

            List<Sale> sales = new List<Sale>()
            {
                new Sale(1, 2, 45, new DateTime(2020, 11, 5, 10, 30, 0)), // Sale by - Sandy Doe
                new Sale(2, 1, 10, new DateTime(2021, 1, 16, 11, 0, 0)), // Sale by - John Smith
                new Sale(5, 1, 10, new DateTime(2021, 1, 16, 11, 0, 0)), // Sale by - John Smith
                new Sale(3, 2, 45, new DateTime(2021, 1, 20, 14, 5, 0)), // Sale by - Sandy Doe
                new Sale(4, 1, 30, new DateTime(2021, 2, 14, 15, 0, 0)), // Sale by - John Smith
            };

            #endregion

            #endregion

            #region SalesPersonAlbumSales

            //// Gets list of Albums that the SalesPerson has sold (according to the sp.Id clause).
            //var salesPersonAlbumSales = from sp in salesPersons
            //                            join s in sales on sp.Id equals s.SalesPersonId
            //                            join als in albumSales on s.Id equals als.SaleId
            //                            join a in albums on als.AlbumId equals a.Id
            //                            where sp.Id == 2
            //                            select a;

            //var albumCounts = salesPersonAlbumSales.GroupBy(als => als.Name)
            //                                       .Select(grp => new
            //                                       {
            //                                           Name = grp.Key,
            //                                           Count = grp.Count()
            //                                       });

            // All the names of the albums that have been sold by the SalesPerson (includes duplicates).
            //foreach (var album in salesPersonAlbumSales)
            //{
            //    Console.WriteLine($"{album.Name}\n");
            //}

            //// How many times an album was sold by a SalesPerson
            //foreach (var album in albumCounts)
            //{
            //    Console.WriteLine($"{album.Name}: {album.Count}\n");
            //}

            #endregion

            // Get a list of Sales with all album data for that sale.
            //var salesPersonAlbumSales = from sp in salesPersons
            //                            join s in sales on sp.Id equals s.SalesPersonId                                        
            //                            join als in albumSales on s.Id equals als.SaleId
            //                            join a in albums on als.AlbumId equals a.Id into subAlbums
            //                            from a in subAlbums.DefaultIfEmpty()
            //                            where sp.Id == 2
            //                            select (subAlbums);

            //var salesPersonSales = (from sp in salesPersons
            //                       join s in sales on sp.Id equals s.SalesPersonId into subSales
            //                       from s in subSales
            //                       where s.SaleDateTime.Month == 1
            //                       select (Sales: subSales, SalesPerson: sp)).Distinct();

            //foreach (var salesPersonSale in salesPersonSales)
            //{
            //    Console.WriteLine($"SalesPerson: {salesPersonSale.SalesPerson.Name}");

            //    int saleNumber = 0;

            //    foreach (var sale in salesPersonSale.Sales)
            //    {
            //        Console.WriteLine($"saleId: {sale.Id}\n" +
            //                          $"total: {sale.Total}\n");
            //        saleNumber++;
            //    }                                 
            //}

            var salesPersonAlbumSales = (from sp in salesPersons
                                        join s in sales on sp.Id equals s.SalesPersonId into subSales
                                        from ss in subSales.DefaultIfEmpty()

                                        join als in albumSales on ss.Id equals als.SaleId
                                        join a in albums on als.AlbumId equals a.Id into subAlbums
                                        from a in subAlbums
                                        where ss.SaleDateTime.Month == 1
                                        select (Sale: ss, SalesPerson: sp, Albums: subAlbums));

            foreach (var salesPersonAlbumSale in salesPersonAlbumSales)
            {
                Console.WriteLine($"SalesPerson: {salesPersonAlbumSale.SalesPerson.Name}");
                Console.WriteLine($"SaleId: {salesPersonAlbumSale.Sale.Id} - Total: {salesPersonAlbumSale.Sale.Total}");
                foreach (var album in salesPersonAlbumSale.Albums)
                {
                    Console.WriteLine($"SalesPerson: {album.Name}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
