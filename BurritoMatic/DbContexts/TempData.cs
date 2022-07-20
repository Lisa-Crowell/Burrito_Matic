using System.Collections.Generic;
using BurritoMatic.Models;

namespace BurritoMatic.DbContexts;

/// <summary>
/// This is a DbContext for the Burrito Matic database. It is used as a temporary
/// database for the application. It is not intended to be used in production.
/// </summary>
/// <author>lisa.l.crowell@gmail.com</author>
public class TempData
{
    public static List<Category> Categories = new List<Category>()
    {
        new Category()
        {
            Id = 1,
            Name = "Entrees",
            Description = "Main course of the meal",
            ImageUrl = "This is the image url for the entree category"
        },
        new Category()
        {
            Id = 2,
            Name = "Sides",
            Description = "Side dish for the meal",
            ImageUrl = "This is the image url for the side category"
        },
        new Category()
        {
            Id = 3,
            Name = "Drinks",
            Description = "Drink for the meal",
            ImageUrl = "This is the image url for the drink category"
        },
        new Category()
        {
            Id = 4,
            Name = "Desserts",
            Description = "Dessert for the meal",
            ImageUrl = "This is the image url for the dessert category"
        }
    };
    
    public static List<Burrito> Entrees = new List<Burrito>()
    {
        new Burrito()
        {
            Id = 1,
            Name = "Burrito-in-a-Bowl",
            Description = "Burrito in a bowl with rice (optional), and your choice of one meat and a salsa",
            Price = 3.99m,
            ImageUrl = "This would be the image url",
        },
        new Burrito()
        {
            Id = 2,
            Name = "2 Ingredient Burrito",
            Description = "Burrito with rice (optional), and your choice of one meat and a salsa",
            Price = 3.99m,
            ImageUrl = "This would be the image url",
        },
        new Burrito()
        {
            Id = 3,
            Name = "3 Ingredient Burrito",
            Description = "Burrito with rice (optional), and your choice of one meat, one topping, and a salsa",
            Price = 4.99m,
            ImageUrl = "This would be the image url"
        },

        new Burrito()
        {
            Id = 4,
            Name = "Burrito-a-la-cart",
            Description = "Burrito with rice (optional), and your choice of meats, toppings, and salsas",
            Price = 5.99m,
            ImageUrl = "This would be the image url"
        }
    };
    
    public static List<Side> Sides = new List<Side>()
    {
        new Side()
        {
            Id = 1,
            Name = "Chips",
            Description = "Your choice of chips to go with your burrito",
            Price = 2.00m,
            ImageUrl = "This would be the image url"
        },
    };

    public static List<Drink> Drinks = new List<Drink>()
    {
        new Drink()
        {
            Id = 1,
            Name = "Soda",
            Description = "Soda to go with your burrito",
            Price = 1.25m,
            ImageUrl = "This would be the image url"
        },
        new Drink()
        {
            Id = 2,
            Name = "Water",
            Description = "Water to go with your burrito",
            Price = 1.25m,
            ImageUrl = "This would be the image url"
        },
        new Drink()
        {
            Id = 3,
            Name = "Iced Tea",
            Description = "Iced tea to go with your burrito",
            Price = 1.25m,
            ImageUrl = "This would be the image url"
        }
    };

    public static List<Dessert> Desserts = new List<Dessert>()
    {
        new Dessert()
        {
            Id = 1,
            Name = "Brownie",
            Description = "Brownie to go with your burrito",
            Price = 1.50m,
            ImageUrl = "This would be the image url"
        }
    };
}
