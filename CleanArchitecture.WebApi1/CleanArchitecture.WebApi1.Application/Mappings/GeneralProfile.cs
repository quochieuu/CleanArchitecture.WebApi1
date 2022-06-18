using AutoMapper;
using CleanArchitecture.WebApi1.Application.Features.Products.Commands.CreateProduct;
using CleanArchitecture.WebApi1.Application.Features.Products.Queries.GetAllProducts;
using CleanArchitecture.WebApi1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.WebApi1.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
