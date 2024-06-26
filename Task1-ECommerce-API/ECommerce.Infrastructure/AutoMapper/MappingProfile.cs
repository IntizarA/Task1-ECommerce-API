﻿using AutoMapper;
using ECommerce.Application.DTOs.Customer;
using ECommerce.Application.DTOs.Order;
using ECommerce.Application.DTOs.OrderDetail;
using ECommerce.Application.DTOs.Product;
using ECommerce.Domain.Entities;
using System.Linq.Expressions;

namespace ECommerce.Infrastructure.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //product
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductUpdateDTO>();
            CreateMap<Product, ProductRemoveDTO>();

            //customer
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();

            //order
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<Order, UpdateOrderDTO>();

            //order detail
            CreateMap<OrderDetail, OrderDetailDTO>();
            CreateMap<OrderDetailDTO, OrderDetail>();

        }
    }
}
