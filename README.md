## Programming Challenge | BurritoMatic
You have been contracted by an innovative fast casual restaurant chain to develop an application to manage making
burritos, dispensing burritos, and handling the point of sale: the BurritoMatic. The BurritoMatic is a combination point
of sale system and robotic burrito assembly system. Your prototype software will serve as the proof of concept for
managing the requests coming from the point of sale terminals and determining the final sales charge for the customer.


Not to worry though! Since it is just a proof of concept, your mission is to simply model the system.
Customer Interaction with the BurritoMatic
The BurritoMatic restaurant is a self-serve restaurant. There will be self-service terminals where customers can key in
their burrito orders. The customer will begin by selecting a burrito product, then the ingredients to go in the product,
one ingredient at a time. Once their burrito has been configured, they will confirm the sales price and checkout at which
point the burrito will be quickly made by the BurritoMatic robots!
### Currently, the menu consists of 3 basic entrees
 2-Ingredient Burrito-in-a-Bowl (no tortilla) ($3.99)

 2-Ingredient Burrito ($4.99)

 3-Ingredient Burrito ($5.99)

There are several kinds of ingredients, in four categories

####  Foundation (ingredients for the base of the burrito)

o Tortilla

o Rice

####  Meat

o Chicken

o Steak

####  Salsa

o Red Salsa

o Green Salsa

o Queso

####  Toppings

o Grated Cheese

o Sour Cream

o Guacamole

## Your Mission
Your mission, should you choose to accept it, is to design models that will represent the orders created at self-service
terminals. Please note: This does not need to be a web service or anything fancy, just a collection of public classes with
public methods.
Your model needs to showcase your talent for conceptualizing a problem and formulating a solution while adhering to
good programming practices. This challenge is meant to take 1-2 hours.
The rules for assembling a burrito are:

 The Burrito-in-a-bowl product can NOT have a tortilla

 On all products, rice is optional

 On all products, you can select only ONE meat ingredient

 On the 2-ingredient burrito, you may select (1) meat and (1) salsa

 On the 3-ingredient burrito, you may select (1) meat, (1) salsa, and (1) topping

 There is an additional charge for Guacamole ($1.25)

 There is an additional charge for Queso ($1.50)

Notes on Your Code:
1. Develop a system of classes to facilitate the creation of burrito orders and calculate order totals and subtotals.

2. Your code should be easily maintainable and readable.

3. Use a static in-memory method of storage to represent your database, such as a list, dictionary, or hash table.
   Some thoughts to keep in mind:

    You do not need a UI or any code to represent UI elements.

    The company may want to add new categories of ingredients, new ingredients to existing categories,
   add/modify the “additional fee” of ingredients (like guacamole / queso). Accomplishing this should require a
   minimal amount of code changes.

    Adding a new burrito product to the menu will happen several times a year and should require a minimal
   amount of code changes for the new product.

    Customers may want to order more than one burrito at a time.

    You do not need a database, but think about how it would be modeled in a database if the company were to
   transition from your application’s in-memory-only model, to a database backed storage solution. How could
   you structure your application such that this type of transition would require few code changes?
   Extra Credit

4. Support an A-La-Cart Burrito Product that allows the selection of any amount of ingredients-- within reasonable
   limits. For example, a customer may want both red salsa and queso... and/or both sour cream and guacamole... and/or
   double chicken. The A-La-Cart Burrito starts out like a 3-Ingredient burrito with a base price of ($5.99), but with
   additional charges for more than three ingredients. Each extra Meat chosen is an additional $0.50. For each extra salsa,
   its $0.50--- except for Queso which maintains its extra $1.50 charge. Each extra topping is $0.33--- except for
   Guacamole which maintains its extra $1.25 charge. For the purpose of calculating the price, assume the base ingredients
   are free and the 3 included ingredients consist of the 3 most expensive ingredients.

   a. An A-La-Cart Burrito with: tortilla, rice, chicken, red salsa, and sour cream is $5.99 -- this configuration is
   directly compatible with the 3-Ingredient Burrito product

   b. An A-La-Cart Burrito with: Tortilla, rice, chicken, red salsa, green salsa, and sour cream would cost: 6.32

   c. An A-La-Cart Burrito with: Tortilla, rice, chicken, steak, red salsa, queso, grated cheese and guacamole would
   cost: 7.32 --- Note that there was an extra charge for the chicken, steak and grated cheese.

5. Support non-burrito products:

   a. Soft drinks ($1.25)

   b. Brownie ($1.50)

   c. Chips ($2.00)