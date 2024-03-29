﻿// <auto-generated />

namespace Yousource.Services.Order.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Yousource.Services.Order.Data.Entities;

    public interface IOrderDataGateway
    {
        Task InsertOrderAsync(OrderEntity order);

        Task<IEnumerable<OrderEntity>> GetOrdersAsync();

    }
}
