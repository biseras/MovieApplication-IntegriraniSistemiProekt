﻿using Movie.Domain.Domain;
using Movie.Repository.Interface;
using Movie.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderDetails(BaseEntity model)
        {
            return _orderRepository.GetOrderDetails(model);
        }
    }
}