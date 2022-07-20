namespace BurritoMatic.Models;

/// <summary>
/// This is the abstract base class for Burrito Matic's order items.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public abstract class OrderItemBase
{
    public MenuItemBase MenuItem { get; set; }
    public int Quantity { get; set; }
}