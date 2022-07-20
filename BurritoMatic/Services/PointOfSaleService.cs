using BurritoMatic.Models;

namespace BurritoMatic.Services;

/// <summary>
/// The implementation of the BurritoMatic IPointOfSaleService 
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class PointOfSaleService : IPointOfSaleService
{
    public decimal CalculateSubtotal(Order order)
    {
        // this is where we will iterate over the ingredients of each order item
        // and calculate the subtotal for each item, such as the additional charges
        // for queso, guacamole, and a-la-carte items.
        throw new System.NotImplementedException();
    }

    public decimal CalculateTax(Order order)
    {
        throw new System.NotImplementedException();
    }

    public decimal CalculateTotal(Order order)
    {
        throw new System.NotImplementedException();
    }

    public bool ProcessPayment(Order order)
    {
        throw new System.NotImplementedException();
    }
}