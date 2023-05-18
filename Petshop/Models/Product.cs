using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Petshop.Context;
using AutoMapper;
using Microsoft.Ajax.Utilities;

namespace Petshop.Models
{
    public class Product
    {
        MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ProductModel, Context.Product>();
            cfg.CreateMap<Context.Product, ProductModel>();
        });
    }
    public class ProductModel : Context.Product
    {

    }
}