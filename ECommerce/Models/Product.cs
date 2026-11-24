namespace ECommerce.Models;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryID { get; set; }
    public Category Category { get; set; } = null!;

    public ICollection<OrderDetail> OrderDetails { get; set; } = new HashSet<OrderDetail>();
}