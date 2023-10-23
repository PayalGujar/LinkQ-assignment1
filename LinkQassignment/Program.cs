﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQassignment
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Product{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Product{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Product{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Product{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };

            //Display All Products
            var res=from p in products select p;
            //Display Products whoes price is > 1500
             var res2=from p in products
                        where p.Price>1500
                        select p;
            //Diplay products whoes price is between 10000 and 40000
            var res3=from p in products
                     where p.Price >= 10000 && p.Price <= 40000
                     select p;
            //Display products of Dell Company
            var res4=from p in products
                     where p.CompanyName=="dell"
                     select p;
            //Display all company laptops
            var res5 = from p in products
                       where p.Name == "Laptop"
                       select p;
            //Display products whose company name starts with M
            var res6=from p in products
            where p.CompanyName.StartsWith("M")
            select p;
                     //Display all company mouse whose price is less than 1000
                     var res7=from p in products
                     where p.Name=="Mouse" && p.Price < 1000
                     select p;
            //Display all products descending order by their price
            var res8=from p in products
                     orderby p.Price descending 
                     select p;
            //Display all products accessing order by their company name
            var res9=from p in products
                     orderby p.Name
                     select p;
            //Display all keyboards accessing order by their price
            var res10 = from p in products
                        orderby p.Price
                        where p.Name == "keyboards"
                        select p;
            //Display all products descending order by their price
            var res11=products.OrderBy(x=> x.Price).ToList();
            //Display product whose Id is 5
            var res12 = products.Where(x => x.Id =='5').ToList();
            //Display all products whose price less than 5000
            var res13=products.Where(x=>x.Price<5000).ToList();
            //Display 3 products which have maximum price
            var res14=products.OrderByDescending(x => x.Price).ToList();
            //Display 5 products which have minimum price
            var res15=products.OrderBy(x=>x.Price).ToList();




            foreach (Product item in res10)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
            }
        }
    }
}









