using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SalesTaxesTest.Entities;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Infrastracture
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ProductProfile>();
            });
        }
    }

    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductModel>();
        }
    }
}