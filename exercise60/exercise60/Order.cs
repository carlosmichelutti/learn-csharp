public class Order
{
    public string OrderNumber { get; set; }
    public string CustomerName { get; set; }
    public string Status { get; set; }

    public Order(string orderNumber, string customerName, string status)
    {
        OrderNumber = orderNumber;
        CustomerName = customerName;
        Status = status;
    }

    public void UpdateStatus(string newStatus)
    {
        if (Status != newStatus)
        {
            Status = newStatus;
        }
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Order: {OrderNumber}");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Status: {Status}\n");
    }
}
