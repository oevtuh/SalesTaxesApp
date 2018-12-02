using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesTaxesTest.Abstract;
using SalesTaxesTest.Entities;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Services
{
    public class ProductService : IProductService
    {
        private List<Product> Products
        {
            get
            {
                return new List<Product>()
                {
                    new Product()
                    {
                        Id = 1,
                        Name = "New Book",
                        Price = 12.49M,
                        Category = new ProductCategory()
                        {
                            Id = 1,
                            Name = "Books",

                        }
                    },
                    new Product()
                    {
                        Id = 2,
                        Name = "Music SD - Best Music",
                        Price = 14.99M,
                        Category = new ProductCategory()
                        {
                            Id = 5,
                            Name = "CDs",

                        }
                    },
                    new Product()
                    {
                        Id = 3,
                        Name = "Chocolate bar",
                        Price = 0.85M,
                        Category = new ProductCategory()
                        {
                            Id = 2,
                            Name = "Food",

                        }
                    },
                    new Product()
                    {
                        Id = 4,
                        Name = "Imported box of chocolates",
                        Price = 10.00M,
                        Imported = true,
                        Category = new ProductCategory()
                        {
                            Id = 2,
                            Name = "Food"
                        }
                    },
                    new Product()
                    {
                        Id = 5,
                        Name = "Imported bottle of perfume",
                        Price = 47.50M,
                        Imported = true,
                        Category = new ProductCategory()
                        {
                            Id = 4,
                            Name = "Parfums"
                        }
                    },
                    new Product()
                    {
                        Id = 6,
                        Name = "Imported bottle of perfume",
                        Price = 27.99M,
                        Imported = true,
                        Category = new ProductCategory()
                        {
                            Id = 6,
                            Name = "Parfums"
                        }
                    },
                    new Product()
                    {
                        Id = 7,
                        Name = "Bottle of perfume",
                        Price = 18.99M,
                        Category = new ProductCategory()
                        {
                            Id = 4,
                            Name = "Parfums"
                        }
                    },
                    new Product()
                    {
                        Id = 8,
                        Name = "Packet of headache pills",
                        Price = 9.75M,
                        Category = new ProductCategory()
                        {
                            Id = 3,
                            Name = "Medical"
                        }
                    },
                    new Product()
                    {
                        Id = 9,
                        Name = "Box of imported chocolates",
                        Price = 11.25M,
                        Imported = true,
                        Category = new ProductCategory()
                        {
                            Id = 2,
                            Name = "Food"
                        }
                    }
                };
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return Products;
        }

        public Product GetById(int id) => Products.FirstOrDefault(x => x.Id == id);
    }
}