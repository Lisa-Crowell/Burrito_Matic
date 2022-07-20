namespace BurritoMatic.Models;

/// <summary>
/// This abstract class is the base class for Burrito Matic's menu items.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public abstract class MenuItemBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}