using System;

namespace BurritoMatic.Models;

/// <summary>
/// This class represents a payment record for Burrito Matic for an order.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class PaymentRecord
{
    public int PaymentRecordId { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
    public bool IsPaid { get; set; }
    public DateTime DatePaid { get; set; }
    public string ConfirmationNumber { get; set; }
}