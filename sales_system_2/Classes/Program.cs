using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            //guys
            SalesMan sm1 = new SalesMan();
            sm1.Name = "Santiago Gomez";
            sm1.Age = 19;
            controller.AddSalesMan(sm1);

            SalesMan sm2 = new SalesMan();
            sm2.Name = "Camilo Grisales";
            sm2.Age = 20;
            controller.AddSalesMan(sm2);

            SalesMan sm3 = new SalesMan();
            sm3.Name = "Alejandro Preciado";
            sm3.Age = 19;
            controller.AddSalesMan(sm3);

            SalesMan sm4 = new SalesMan();
            sm4.Name = "Andres Duque";
            sm4.Age = 24;
            controller.AddSalesMan(sm4);

            //products
            Product p1 = new Product();
            p1.Name = "Peach";
            p1.Price = 850;
            controller.AddProduct(p1);

            Product p2 = new Product();
            p2.Name = "Apple";
            p2.Price = 800;
            controller.AddProduct(p2);

            Product p3 = new Product();
            p3.Name = "Pineapple";
            p3.Price = 950;
            controller.AddProduct(p3);

            Product p4 = new Product();
            p4.Name = "Strawberry";
            p4.Price = 400;
            controller.AddProduct(p4);

            //sales
            Sale s1 = new Sale();
            s1.Product = p1;
            s1.SalesMan = sm1;
            s1.Comments = "Delicious peach";
            controller.AddSale(s1);

            Sale s2 = new Sale();
            s2.Product = p2;
            s2.SalesMan = sm2;
            s2.Comments = "Delicious apple";
            controller.AddSale(s2);

            Sale s3 = new Sale();
            s3.Product = p3;
            s3.SalesMan = sm3;
            s3.Comments = "Delicious pineapple";
            controller.AddSale(s3);

            Sale s4 = new Sale();
            s4.Product = p4;
            s4.SalesMan = sm4;
            s4.Comments = "Delicious strawberry";
            controller.AddSale(s4);

            Sale s5 = new Sale();
            s5.Product = p1;
            s5.SalesMan = sm1;
            s5.Comments = "Delicious peach";
            controller.AddSale(s5);


            //First requirement
            int TotalSalesCount = controller.TotalSales();
            Console.WriteLine("Total sales: " + TotalSalesCount + ".\n");

            Console.WriteLine("Total sales price: " + (s1.Product.Price + s2.Product.Price + s3.Product.Price + s4.Product.Price + s5.Product.Price + ".\n"));

            ////1.Who's the seller (sales man name), who has sold the cheapest product.
            String nameSalemanLowerSaleNewMethod = controller.CheapestSaleMadeBySalesMan();
            Console.WriteLine("Sale Man who sold the cheapest product: " + nameSalemanLowerSaleNewMethod + ".\n");

            //2.Products price average.
            double averageProductNewMethod = controller.Average();
            Console.WriteLine("Average price of products: " + averageProductNewMethod + ".\n");

            //3.How many unit of the product has been sold.
            int countProductsNewMethod = controller.ProductsSold();
            Console.WriteLine("Units of products sold: " + countProductsNewMethod + ".\n");

            //4.What's the most expensive product.
            string nameProductNewMethod = controller.ExpensiveProduct();
            Console.WriteLine("Most expensive product: " + nameProductNewMethod + ".\n");
        }
    }
}
