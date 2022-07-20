using System.Collections.Generic;

namespace BurritoMatic.Models;

/// <summary>
/// This class represents a burrito item on the BurritoMatic menu.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class BurritoItem : OrderItemBase
{
    public List<Meat> Meats { get; set; }
    public List<Topping> Toppings { get; set; }
    public List<Salsa> Salsas { get; set; }
    public List<Foundation> Foundations { get; set; }
}