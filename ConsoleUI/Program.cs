﻿using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.Inmemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            
            //CategoryTest();
            
        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAll();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    //Console.WriteLine("Ürün adı: " + product.ProductName + " Fiyatı: " + product.UnitPrice + " Stok " + product.UnitsInStock);
                    //Console.WriteLine(product.ProductName + "   Unit Stock  " + product.UnitsInStock + "    UnitPrice:   " + product.UnitPrice);
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
