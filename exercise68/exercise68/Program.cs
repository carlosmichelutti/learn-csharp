using Exercise68.Models;

Item burger = new Item("Cheese Burger", 12, 15.90);
Item soda = new Item("Coca-Cola", 25, 6.50);
Item fries = new Item("French Fries", 8, 9.00);

Menu menu = new Menu();
menu.AddItem(burger);
menu.AddItem(soda);
menu.AddItem(fries);
menu.ShowItems();

Table table1 = new Table(1);
Table table2 = new Table(2);
Table table3 = new Table(3);
table1.ReserveTable();
table3.ReserveTable();

Restaurant restaurant = new Restaurant("Burger House", menu, new List<Table> { table1, table2, table3 });
restaurant.ShowAvailableTables();

Order order = new Order(1, burger, table1);
Console.WriteLine(order.DetailedDescription);
