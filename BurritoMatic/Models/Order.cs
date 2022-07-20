using System.Collections.Generic;

namespace BurritoMatic.Models;

/// <summary>
/// This class represents an order for Burrito Matic.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class Order
{
    public List<OrderItemBase> Items { get; set; }
    public int OrderId { get; set; }
    public PaymentRecord PaymentRecord { get; set; }
    public bool IsComplete { get; set; }
    public bool IsCancelled { get; set; }
}