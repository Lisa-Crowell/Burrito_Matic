using BurritoMatic.Models;

namespace BurritoMatic.Services;

/// <summary>
/// Point of Sale Service is responsible for handling all the business logic for the Point of Sale,
/// including calculating the subtotal, tax, total, and handling the payment.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public interface IPointOfSaleService
{
    /// <summary>
    /// This method will iterate over the list of items in the order and calculate the subtotal.
    /// </summary>
    /// <param name="order">the order to process</param>
    /// <returns>the subtotal</returns>
    public decimal CalculateSubtotal(Order order);
    
    /// <summary>
    /// This method will iterate over the list of items in the order and calculate the tax.
    /// </summary>
    /// <param name="order">the order to process</param>
    /// <returns>the tax</returns>
    public decimal CalculateTax(Order order);
    
    /// <summary>
    /// This method will iterate over the list of items in the order and calculate the total.
    /// </summary>
    /// <param name="order">the order to process</param>
    /// <returns>the total</returns>
    public decimal CalculateTotal(Order order);
    
    /// <summary>
    /// This method will handle the payment for the order.
    /// </summary>
    /// <param name="order">the order to process</param>
    /// <returns>if the payment processed successfully</returns>
    public bool ProcessPayment(Order order);
}