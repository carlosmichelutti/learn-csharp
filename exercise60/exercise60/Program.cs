using Exercise60.Models;

Order order = new Order("001", "Ana Silva", "Pending");
order.DisplayOrder();
order.UpdateStatus("Sent");
order.DisplayOrder();
