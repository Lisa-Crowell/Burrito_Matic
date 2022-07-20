namespace BurritoMatic.Models;

/// <summary>
/// This class represents a burrito.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class Burrito : MenuItemBase
{
    public int MaxMeat { get; set; }
    public int MaxToppings { get; set; }
    public int MaxSalsas { get; set; }
    public decimal Price { get; set; }
}