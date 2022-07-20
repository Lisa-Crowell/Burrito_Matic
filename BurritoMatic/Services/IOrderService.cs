using System.Collections.Generic;
using BurritoMatic.Models;

namespace BurritoMatic.Services;

/// <summary>
/// Order Service is responsible for handling all the business logic for the Order, 
/// including the creation of the order, the updating of the order, and delivery of the order
/// to the robots.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public interface IOrderService
{
    /// <summary>
    /// Receives a list of order items, the payment record, and returns the order.
    /// </summary>
    /// <param name="orderItems">the items in the order</param>
    /// <returns>the order</returns>
    Order CreateOrder(List<OrderItemBase> orderItems, PaymentRecord paymentRecord);
    
    /// <summary>
    /// Cancels the order.
    /// </summary>
    /// <param name="order">the cancelled order</param>
    /// <returns>the cancelled order</returns>
    Order CancelOrder(Order order);
    
    /// <summary>
    /// Completes the order
    /// </summary>
    /// <param name="order">the completed order</param>
    /// <returns>the completed order</returns>
    Order CompleteOrder(Order order);
    
    /// <summary>
    /// Transmits the order to the robots to make the order.
    /// </summary>
    /// <param name="order">the order to transmit</param>
    /// <returns>if the order was transmitted successfully</returns>
    bool TransmitOrder(Order order);
}