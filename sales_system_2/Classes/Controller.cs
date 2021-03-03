using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Controller
    {

        Product[] Products = new Product[50];
        int productsCount = 0;

        Sale[] Sales = new Sale[50];
        int salesCount = 0;

        SalesMan[] SalesMen = new SalesMan[50];
        int salesMenCount = 0;

        public void AddSalesMan(SalesMan newSalesMan)
        {
            SalesMen[salesMenCount] = newSalesMan;
            salesMenCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productsCount] = newProduct;
            productsCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }

        public int TotalSales()
        {
            int count = 0;
            for (int i = 0; i < salesCount; i++)
            {
                if (Sales[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

        //1. Who's the seller (sales man name), who has sold the cheapest product.
        public string CheapestSaleMadeBySalesMan()
        {
            string Products = "";
            int c = 0;
            double Cheaper = Sales[c].Product.Price;
            for (int e = 1; e < salesCount; e++)
            {
                if (Sales[e].Product.Price < Cheaper)
                {
                    Cheaper = Sales[c].Product.Price;
                    Products = Sales[c].SalesMan.Name;
                }
            }
            return Products;
        }

        //2. Products price average.
        public double Average()
        {
            double average = 0;
            double saleTotal = 0;
            for (int i = 0; i < salesCount; i++)
            {
                saleTotal = saleTotal + Sales[i].Product.Price;
                average = saleTotal / ProductsSold();
            }
            return average;
        }

        //3. How many unit of the product has been sold.
        public int ProductsSold()
        {
            int count = 0;
            for (int i = 0; i < productsCount; i++)
            {
                count++;
            }
            return count;
        }

        //4. What's the most expensive product.
        public string ExpensiveProduct()
        {
            double mostExpensive = 0;
            string product = " ";
            for (int i = 0; i < salesCount; i++)
            {
                if (Sales[i].Product.Price > mostExpensive)
                {
                    mostExpensive = Sales[i].Product.Price;
                    product = Sales[i].Product.Name;
                }
            }
            return product;
        }
    }
}
