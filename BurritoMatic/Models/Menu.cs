using System.Collections.Generic;

namespace BurritoMatic.Models;

/// <summary>
/// This class represents the menu items on the Burrito Matic menu.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class Menu
{
    public List<MenuItemBase> MenuItems { get; set; }
}