using shoppingapp.Entities;
using shoppingapp;

Item item1 = new Item() {Id=1, Name="Mjölk", Quantity= 1, Price= 11.99M };

Cart cart = new Cart();

IObserver shoppingDisplay = new ShoppingListDisplay(cart);
var budgetDisplayElement = new BudgetDisplayElement(cart, 500);
cart.AddItemToCart(item1);
