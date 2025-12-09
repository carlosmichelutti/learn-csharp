using Exercise59.Models;

Product product = new Product("Blue Pen", 20);
product.RemoveFromStock(5);
product.DisplayStock();
product.RemoveFromStock(30);
