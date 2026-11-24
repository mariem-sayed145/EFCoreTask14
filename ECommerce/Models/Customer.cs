namespace ECommerce.Models;

public class Customer
{
    public int ID { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }

    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
}