namespace BurritoMatic.Models;

/// <summary>
/// This class represents drink options for BurritoMatic.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class Drink : MenuItemBase
{
    /// <summary>
    /// This is the enum for the size of the drink in US ounces.
    /// </summary>
    public enum Size
    {
        Small = 16,
        Medium = 20,
        Large = 24
    }
    public Size DrinkSize { get; set; }
    public bool IsAlcoholic { get; set; }
    public decimal Price { get; set; }
}
