using Exercise65.Models;

Product candy = new Product("Candy", "Halls", 4.99, 40);
Product cookie = new Product("Cookie", "Oreo", 10, 60);
Product rice = new Product("Rice", "Camil", 30, 20);

Stock stock = new Stock();
stock.AddProduct(candy);
stock.AddProduct(cookie);
stock.AddProduct(rice);
stock.DisplayProducts();
