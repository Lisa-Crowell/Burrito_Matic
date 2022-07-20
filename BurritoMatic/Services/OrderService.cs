using System.Collections.Generic;
using BurritoMatic.Models;

namespace BurritoMatic.Services;

/// <summary>
/// The implementation of the Burrito Matic IOrderService.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class OrderService : IOrderService
{
    public Order CreateOrder(List<OrderItemBase> orderItems, PaymentRecord paymentRecord)
    {
        throw new System.NotImplementedException();
    }

    public Order CancelOrder(Order order)
    {
        throw new System.NotImplementedException();
    }

    public Order CompleteOrder(Order order)
    {
        throw new System.NotImplementedException();
    }

    public bool TransmitOrder(Order order)
    {
        throw new System.NotImplementedException();
    }
}