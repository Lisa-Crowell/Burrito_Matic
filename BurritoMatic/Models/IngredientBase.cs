namespace BurritoMatic.Models;

/// <summary>
/// This is the abstract base class for Burrito Matic's menu items.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public abstract class IngredientBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Surcharge { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
}